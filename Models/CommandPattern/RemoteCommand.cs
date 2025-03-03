namespace TextEditor.Models.CommandPattern;

public interface Appliance
{
    void turnOn();
    void turnOff();
}

public class LightCommandOn : Command
{
    private Light _light;

    public LightCommandOn(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.turnOn();
    }
}
public class LightCommandOff : Command
{
    private Light _light;

    public LightCommandOff(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.turnOff();
    }
}

public class FanCommandOn : Command
{
    private Fan _fan;

    public FanCommandOn(Fan fan)
    {
        _fan = fan;
    }

    public void Execute()
    {
        _fan.turnOn();
    }
}
public class FanCommandOff : Command
{
    private Fan _fan;

    public FanCommandOff(Fan fan)
    {
        _fan = fan;
    }

    public void Execute()
    {
        _fan.turnOff();
    }
}

public class Fan:Appliance 
{
    public void turnOn()
    {
        Console.WriteLine("Turning on the Fan");
    }

    public void turnOff()
    {
        Console.WriteLine("Turning off the Fan");
    }
}

public class Light:Appliance
{
    public void turnOn()
    {
        Console.WriteLine("Turning on the Light");
    }

    public void turnOff()
    {
        Console.WriteLine("Turning off the Light");
    }
}

