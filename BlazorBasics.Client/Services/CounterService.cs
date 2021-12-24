namespace BlazorBasics.Client.Services;

public class CounterService : ICounterService
{
    // Event fired when the count was changed
    public event Action? OnChanged;
    
    // The current count
    public int Count { get; private set; } = 0;
    
    // Method to be called to increase the count
    public void Increase(int quantity)
    {
        this.Count += quantity;
        this.InvokeOnChange();
    }
    
    // Method to be called to decrease the count
    public void Decrease(int quantity)
    {
        this.Count -= quantity;
        this.InvokeOnChange();
    }
    
    // Method invoking the OnChanged event 
    private void InvokeOnChange()
    {
        if (this.OnChanged != null)
        {
            this.OnChanged.Invoke();
        }
    } 
}