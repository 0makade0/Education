namespace EventTask.Events;
public class AccountCountOfOperationsEvent
{
    public string Message { get; }
    public int CountOperation { get; }

    public AccountCountOfOperationsEvent(string message, int countOperation)
    {
        Message = message;
        CountOperation = countOperation;
    }
}