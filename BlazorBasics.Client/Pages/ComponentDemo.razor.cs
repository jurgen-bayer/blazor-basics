using Microsoft.AspNetCore.Components;

namespace BlazorBasics.Client.Pages;

public partial class ComponentDemo
{
    [Parameter]
    public DateTime LastDate { get; set; }
    
    public void UpdateDate(DateTime date)
    {
        this.LastDate = date;
    }
}