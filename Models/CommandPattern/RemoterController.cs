namespace TextEditor.Models.CommandPattern;

public class RemoterController
{
    private Light Light = new();
    private Fan Fan = new();

    public void Run()
    {
        LightCommandOn lightOn = new LightCommandOn(Light);
        FanCommandOn fanOn = new FanCommandOn(Fan);
        LightCommandOff lightOff = new LightCommandOff(Light);
        FanCommandOff fanOff = new FanCommandOff(Fan);
        
        lightOn.Execute();
        fanOn.Execute();
        
        lightOff.Execute();
        fanOff.Execute();
        
    }
}