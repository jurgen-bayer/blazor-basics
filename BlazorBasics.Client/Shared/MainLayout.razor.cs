namespace BlazorBasics.Client.Shared;

public partial class MainLayout: IDisposable
{
    protected override void OnInitialized()
    {
        // Add the StateHasChanged method of the component to the OnChanged 
        // event to inform the component that it needs to re-render when the 
        // count in the counter service has changed
        this.counterService.OnChanged += this.StateHasChanged;
    }
    
    public void Dispose()
    {
        // Unsubscribe from the OnChanged event of the counter service
        this.counterService.OnChanged += this.StateHasChanged;
    }
}