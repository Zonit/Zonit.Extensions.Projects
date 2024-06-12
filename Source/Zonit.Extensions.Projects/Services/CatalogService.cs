
namespace Zonit.Extensions.Projects.Services;

internal class CatalogService : ICatalogProvider
{
    readonly ICatalogManager _catalogManager;

    public ProjectModel? Project
        => _catalogManager.Catalog?.Project;

    public Guid[] VisibleProjects
        => _catalogManager.Projects?.Select(x => x.Id).ToArray() ?? [];

    public event Action? OnChange;

    public CatalogService(ICatalogManager projectManager)
    {
        _catalogManager = projectManager;
        _catalogManager.OnChange += StateChanged;
    }

    public void StateChanged()
    {
        OnChange?.Invoke();
    }
}
