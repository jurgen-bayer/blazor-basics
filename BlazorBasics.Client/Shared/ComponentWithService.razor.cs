namespace BlazorBasics.Client.Shared;

public partial class ComponentWithService
{
    private void IncreaseCount()
    {
        this.counterService.Increase(1);
    }

    private void DecreaseCount()
    {
        this.counterService.Decrease(1);
    }
}