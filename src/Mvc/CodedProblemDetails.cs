using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nirbito.Framework.Core;

// ReSharper disable ClassNeverInstantiated.Global

namespace GoLogs.Framework.Mvc
{
    public class CodedProblemDetails : ProblemDetails
    {
        public new string Title => ProblemType.ToString();

        [JsonIgnore]
        public ProblemType ProblemType { get; }
        
        public string ObjectName { get; }
        
        public object ObjectValue { get; }

        public CodedProblemDetails(ProblemType problemType, string objectName, object objectValue)
        {
            Check.NotNull(problemType, nameof(problemType));
            Check.NotNullOrEmpty(objectName, nameof(objectName));
            Check.NotNull(objectValue, nameof(objectValue));
            
            ProblemType = problemType;
            ObjectName = objectName;
            ObjectValue = objectValue;
        }
    }
}
