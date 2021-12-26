namespace BlazorBasics.Client.Services;

public class OtherServiceUsingCounterService: IOtherServiceUsingCounterService
{
    private readonly ICounterService counterService;

    public OtherServiceUsingCounterService(ICounterService counterService)
    {
        this.counterService = counterService;
    }

    public int GetCount()
    {
        return this.counterService.Count;
    }
}