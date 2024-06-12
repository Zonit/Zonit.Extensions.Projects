namespace Zonit.Extensions.Projects;

public interface ICatalogProvider
{
    /// <summary>
    /// Default design, write and read.
    /// </summary>
    public ProjectModel? Project { get; }

    /// <summary>
    /// Visible projects, read-only. E.g. displays things from several projects simultaneously.
    /// </summary>
    public Guid[] VisibleProjects { get; }

    /// <summary>
    /// Event that is triggered when the project changes.
    /// </summary>
    public event Action? OnChange;
}