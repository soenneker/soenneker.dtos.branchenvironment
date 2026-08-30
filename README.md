[![](https://img.shields.io/nuget/v/soenneker.dtos.branchenvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.branchenvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.branchenvironment/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.branchenvironment/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.branchenvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.branchenvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.branchenvironment/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.branchenvironment/actions/workflows/codeql.yml)

# Soenneker.Dtos.BranchEnvironment

Associates a known Git branch with a deployment environment.

## Installation

```bash
dotnet add package Soenneker.Dtos.BranchEnvironment
```

## Usage

```csharp
using Soenneker.Dtos.BranchEnvironment;
using Soenneker.Enums.DeployEnvironment;
using Soenneker.Enums.GitBranches;

var mappings = new[]
{
    new BranchEnvironment
    {
        Branch = GitBranch.Develop,
        DeployEnvironment = DeployEnvironment.Development
    },
    new BranchEnvironment
    {
        Branch = GitBranch.Staging,
        DeployEnvironment = DeployEnvironment.Staging
    },
    new BranchEnvironment
    {
        Branch = GitBranch.Main,
        DeployEnvironment = DeployEnvironment.Production
    }
};
```

The DTO stores one association; it does not infer an environment from a branch, enforce a one-to-one mapping, read the current Git branch, or perform a deployment. Build the collection that matches your release process and perform lookup in the caller.

Both properties use Soenneker generated enum-value types rather than C# enums. `GitBranch` supplies `Develop`, `Staging`, and `Main`; `DeployEnvironment` supplies `Test`, `Local`, `E2E`, `Development`, `Staging`, and `Production`.

Properties are mutable and are not initialized by the parameterless constructor. Assign both before use. Serialization behavior comes from the enum-value types and the serializer configuration in your application; this DTO does not declare its own JSON property names or converters.
