using Microsoft.AspNetCore.Components;
using Zonit.Extensions.Projects;

namespace Zonit.Extensions;

public sealed class ZonitProjectsExtension : ComponentBase, IDisposable
{
    [Inject]
    ICatalogManager Project { get; set; } = default!;

    [Inject]
    PersistentComponentState ApplicationState { get; set; } = default!;

    StateModel? State { get; set; }

    PersistingComponentStateSubscription persistingSubscription;

    protected override void OnInitialized()
    {
        persistingSubscription = ApplicationState.RegisterOnPersisting(PersistData);

        if (!ApplicationState.TryTakeFromJson<StateModel>("ZonitProjectsExtension", out var restored))
            State = Project.State;
        else
            State = restored!;

        if (State is not null)
            Project.Inicjalize(State);
    }

    private Task PersistData()
    {
        ApplicationState.PersistAsJson("ZonitProjectsExtension", State);

        return Task.CompletedTask;
    }

    public void Dispose()
        => persistingSubscription.Dispose();
}