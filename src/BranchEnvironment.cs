using Soenneker.Enums.DeployEnvironment;
using Soenneker.Enums.GitBranches;

namespace Soenneker.Dtos.BranchEnvironment;

/// <summary>
/// A class that represents the environment and branch type association.
/// </summary>
public class BranchEnvironment
{
    /// <summary>
    /// Gets or sets the deployment environment (e.g., Development, Staging, Production).
    /// </summary>
    public DeployEnvironment DeployEnvironment { get; set; } = null!;

    /// <summary>
    /// Gets or sets the branch type
    /// </summary>
    public GitBranch Branch { get; set; } = null!;
}