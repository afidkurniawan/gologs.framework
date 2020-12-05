using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using Nirbito.Framework.Core;

// ReSharper disable ClassNeverInstantiated.Global

namespace GoLogs.Framework.Mvc
{
    public class ProblemCollector : IProblemCollector
    {
        private Collection<CodedProblemDetails> _problems;

        public bool HasProblems => _problems.Count > 0;

        public ProblemCollector()
        {
            _problems = new Collection<CodedProblemDetails>();
        }

        public void AddProblem(CodedProblemDetails problemDetails)
        {
            Check.NotNull(problemDetails, nameof(problemDetails));
            
            _problems.Add(problemDetails);
        }

        public ProblemDetails GetProblems()
        {
            if (_problems.Count == 0)
            {
                return null;
            }
            
            var result = new ProblemDetails();

            if (_problems.Count > 1)
            {
                result.Title = ProblemType.ERROR_MULTIPLE.ToString();
                result.Status = ProblemMapping.GetStatusCode(ProblemType.ERROR_MULTIPLE);
            }
            else
            {
                result.Title = _problems[0].Title;
                result.Status = ProblemMapping.GetStatusCode(_problems[0].ProblemType);
            }
            result.Type = ProblemMapping.GetProblemDetailType(result.Status.GetValueOrDefault());

            var problemObjects = new Collection<Dictionary<string, object>>();
            foreach (var problem in _problems)
            {
                problemObjects.Add(new Dictionary<string, object>
                {
                    {nameof(CodedProblemDetails.ObjectName).ToCamelCaseInvariant(), problem.ObjectName},
                    {nameof(CodedProblemDetails.ObjectValue).ToCamelCaseInvariant(), problem.ObjectValue}
                });
            }
            result.Extensions.Add("problemObjects", problemObjects);

            _problems = new Collection<CodedProblemDetails>();
            
            return result;
        }
    }
}
