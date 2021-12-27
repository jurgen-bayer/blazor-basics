using BlazorBasics.Shared;

namespace BlazorBasics.Client.Pages;

public partial class EditDemo
{
    private readonly Starship starship = new() { ProductionDate = DateTime.UtcNow };

    private void handleValidSubmit()
    {
        this.logger.LogInformation("handleValidSubmit was called");
        
        // TODO: Process the valid form
    }
}