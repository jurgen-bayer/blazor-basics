using Microsoft.AspNetCore.Components;

namespace BlazorBasics.Client.Shared;

public partial class ComponentWithEvent
{
    [Parameter]
    public EventCallback<DateTime> UpdateDate { get; set; }
    
    // Method called by the button to raise the event.
    public async Task RaiseUpdateDateEvent()
    {
        await this.UpdateDate.InvokeAsync(DateTime.Now);
    }
}