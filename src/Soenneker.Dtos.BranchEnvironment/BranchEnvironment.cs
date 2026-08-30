using Soenneker.Enums.DeployEnvironment;
using Soenneker.Enums.GitBranches;

namespace Soenneker.Dtos.BranchEnvironment;

/// <summary>
/// Associates a Git branch with a deployment environment.
/// </summary>
public sealed class BranchEnvironment
{
    /// <summary>
    /// Gets or sets the deployment environment (e.g., Development, Staging, Production).
    /// </summary>
    public DeployEnvironment DeployEnvironment { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Git branch.
    /// </summary>
    public GitBranch Branch { get; set; } = null!;
}
