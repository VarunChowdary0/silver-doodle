namespace TextEditor.Models;

public interface ISubject
{
    void NotifyAll();
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
}