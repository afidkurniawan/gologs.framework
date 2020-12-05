# GoLogs.Framework

Reusable codes for Go-Logs .NET applications.

## GoLogs.Framework.Core

Codes that will be reused in common .NET projects.

## GoLogs.Framework.Mvc

Only codes that will be reused in .NET MVC projects.

## Coding Rules 📖

### General

- For every public method:
    - Validate all parameters (e.g. call `Check.NotNull<T>(T, string)` or any of its variations) at the beginning of the method for easier tracing in logs.
    - Document all the exceptions (use XML comments) that might be thrown by the method so that the calling code knows what to expect.
- For every async method:
    - Always append `Async` to its name.
    - If the method returns `Task` or `Task<T>` object, add `CancellationToken cancellationToken = default` as its **last** parameter.
    - If needed, call `ThrowIfCancellationRequested()` **before** calling another async method.
