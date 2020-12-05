using Microsoft.AspNetCore.Mvc;

namespace GoLogs.Framework.Mvc
{
    public interface IProblemCollector
    {
        bool HasProblems { get; }
        void AddProblem(CodedProblemDetails problemDetails);
        ProblemDetails GetProblems();
    }
}