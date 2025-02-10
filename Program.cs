using TextEditor.Models;
using TextEditor.views;

public class Program
{
    static void Main(string[] args)
    {
        EditorApp editorApp = new();
        // editorApp.Run();
        
        DestinationGame destinationGame = new();
        destinationGame.Run();
        
    }
}