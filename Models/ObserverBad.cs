namespace TextEditor.Models;

class DisplayDevice0
{
    public void showTemp(float temp)
    {
        Console.WriteLine($"Current temperature: {temp} °C");
    }
}

class WeatherStation0
{
    private DisplayDevice0 displayDevice ;
    private float temp;

    public WeatherStation0(DisplayDevice0 displayDevice)
    {
        this.displayDevice = displayDevice;
    }

    public void setTemp(float temp)
    {
        this.temp = temp;
        notify();
    }

    public void notify()
    {
        displayDevice.showTemp(this.temp);
    }
}


public class ObserverBad
{
    public void Run()
    {
        DisplayDevice0 dv1 = new DisplayDevice0();
        WeatherStation0 ws = new WeatherStation0(dv1);
        
        ws.setTemp(10);
        ws.setTemp(20);
        ws.setTemp(30);
    }
}