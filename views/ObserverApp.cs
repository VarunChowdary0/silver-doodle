using TextEditor.Models;

namespace TextEditor.views;

public class ObserverApp
{
    public static ObserverGood station = new(); // 

    public void Run()
    {
        Device mobile0 = new Device("IQoo 9T");
        Device mobile1 = new Device("Samsung A21 F");
        Device Lap0 = new Device("Zenbook 14 OLED");
        Device Lap1 = new Device("Mac M2");
        
        station.Subscribe(mobile0);
        station.Subscribe(mobile1);
        station.setTemperature(42.2f);
        station.Unsubscribe(mobile1);
        
        station.Subscribe(mobile1);
        station.Subscribe(Lap1);
        station.setTemperature(19.7f);
        station.Subscribe(Lap0);
        station.setTemperature(32.0f);
        
        station.Unsubscribe(Lap1);
        station.setTemperature(29.8f);
    }
}