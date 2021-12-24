namespace BlazorBasics.Client.Services;

public interface ICounterService
{
    // Event fired when the count was changed.
    event Action OnChanged;
    
    // The current count
    int Count { get; }
    
    // Method to be called to increase the count.
    void Increase(int quantity);
    
    // Method to be called to decrease the count.
    void Decrease(int quantity);
}
