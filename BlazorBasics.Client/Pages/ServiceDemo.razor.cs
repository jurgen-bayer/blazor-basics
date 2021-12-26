namespace BlazorBasics.Client.Pages;

public partial class ServiceDemo
{
    private int? LastCountFromOtherServiceUsingCounterService { get; set; }
    
    public int? LastCountFromNonServiceUsingCounterService { get; set; }

    private void GetCountFromOtherServiceUsingCounterService()
    {
        this.LastCountFromOtherServiceUsingCounterService = this.otherServiceUsingCounterService.GetCount();
    }
}