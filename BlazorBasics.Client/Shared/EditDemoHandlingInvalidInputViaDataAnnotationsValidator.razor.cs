using System.Text.Json;
using BlazorBasics.Shared;
using Microsoft.JSInterop;

namespace BlazorBasics.Client.Shared;

public partial class EditDemoHandlingInvalidInputViaDataAnnotationsValidator
{
    private readonly Starship starship = new() { ProductionDate = DateTime.UtcNow };

    private void HandleValidSubmit()
    {
        this.logger.LogInformation("handleValidSubmit was called");
        
        // TODO: Process the valid form
        var jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        var starshipJson = JsonSerializer.Serialize(this.starship, jsonSerializerOptions);
        this.logger.LogInformation(starshipJson);
    }
}