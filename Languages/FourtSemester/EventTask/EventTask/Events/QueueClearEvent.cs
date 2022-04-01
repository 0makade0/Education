namespace EventTask.Events;

public class QueueClearEvent
{
    public string Message { get; }

    public QueueClearEvent(string message)
    {
        Message = message;
    }
}