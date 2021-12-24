namespace BlazorBasics.Client.Shared;

public partial class ComponentWithService
{
    public void IncreaseCount()
    {
        this.counterService.Increase(1);
    }
    
    public void DecreaseCount()
    {
        this.counterService.Decrease(1);
    }
}