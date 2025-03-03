using TextEditor.Models;
using TextEditor.Models.CommandPattern;
using TextEditor.views;

public class Program
{
    static void Main(string[] args)
    {
        // EditorApp editorApp = new();
        // editorApp.Run();
        //
        // DestinationGame destinationGame = new();
        // destinationGame.Run();
        //
        // ObserverBad observerBad = new();
        // observerBad.Run();
        
        // ObserverApp observerApp = new();
        // observerApp.Run();
        
        // StockNotifyApp stockApp = new();
        // stockApp.Run();
        
        // CommandApp commandApp = new();
        // commandApp.Run();
        
        RemoterController controller = new RemoterController();
        controller.Run();
    }
}