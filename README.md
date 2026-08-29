[![](https://img.shields.io/nuget/v/soenneker.dtos.branchenvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.branchenvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.branchenvironment/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.branchenvironment/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.branchenvironment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.branchenvironment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.branchenvironment/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.branchenvironment/actions/workflows/codeql.yml)

# Soenneker.Dtos.BranchEnvironment

A class that represents the environment and branch type association.

## Install

```bash
dotnet add package Soenneker.Dtos.BranchEnvironment
```

## What you get

- `BranchEnvironment` — A class that represents the environment and branch type association.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `BranchEnvironment.DeployEnvironment` | Gets or sets the deployment environment (e.g., Development, Staging, Production). | Gets or sets the deployment environment (e.g., Development, Staging, Production). |
| `BranchEnvironment.Branch` | Gets or sets the branch type. | Gets or sets the branch type. |
