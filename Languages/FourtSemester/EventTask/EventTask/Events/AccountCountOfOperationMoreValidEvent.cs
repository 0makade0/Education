namespace EventTask.Events;

public class AccountCountOfOperationMoreValidEvent
{
    public string Message { get; }

    public AccountCountOfOperationMoreValidEvent(string message)
    {
        Message = message;
    }
}