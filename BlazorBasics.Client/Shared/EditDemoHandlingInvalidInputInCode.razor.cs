using System.Text.Json;
using BlazorBasics.Shared;

namespace BlazorBasics.Client.Shared;

public partial class EditDemoHandlingInvalidInputInCode
{
    private readonly Starship starship = new() { ProductionDate = DateTime.UtcNow };

    private void HandleValidSubmit()
    {
        this.logger.LogInformation("HandleValidSubmit was called");
        
        // TODO: Process the valid form
        var jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        var starshipJson = JsonSerializer.Serialize(this.starship, jsonSerializerOptions);
        this.logger.LogInformation(starshipJson);
    }

    private void HandleInvalidSubmit()
    {
        this.logger.LogInformation("HandleInvalidSubmit was called");
        
        this.toastService.ShowWarning("You input is invalid.");
    }
}