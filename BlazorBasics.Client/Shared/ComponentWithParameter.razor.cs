using Microsoft.AspNetCore.Components;

namespace BlazorBasics.Client.Shared;

public partial class ComponentWithParameter
{
    [Parameter]
    public int Value { get; set; }
}