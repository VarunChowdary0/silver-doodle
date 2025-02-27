using System.Collections;

namespace TextEditor.Models;

public interface IObserver
{
    string getName();
    void Update(float temp);
}

public class Device:IObserver
{
    private string name;
    public Device(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    public void Update(float temp)
    {
        Console.Write($"Device : ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{name}");
        Console.ResetColor();
        Console.Write($" Temperature : ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{temp}\n");
        Console.ResetColor();
    }
}

public class WeatherStation:ISubject
{
    private float _temperature;
    private List<IObserver> Devices { get; }

    public WeatherStation()
    {
        this.Devices = new List<IObserver>();
    }

    public void setTemperature(float temperature)
    {
        this._temperature = temperature;
        NotifyAll();
    }

    public void Subscribe(IObserver observer)
    {
        Devices.Add(observer);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Subscribed  <<<=|| {observer.getName()}");
        Console.ResetColor();
    }

    public void Unsubscribe(IObserver observer)
    {
        Devices.Remove(observer);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"UnSubscribed ||=>>>  {observer.getName()}: ");
        Console.ResetColor();
    }

    public void NotifyAll()
    {   
        Devices.ForEach(devi => devi.Update(_temperature));
    }
    
}

public class ObserverGood:WeatherStation
{   
    public ObserverGood():base(){}
}