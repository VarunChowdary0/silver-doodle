namespace TextEditor.Models.CommandPattern;

public class CommandApp
{
    TextEditor Editor = new TextEditor();

    public void Run()
    {
        Button b1 = new Button();
        Button b2 = new Button();

        b1.Command = new BoldCommand(Editor);
        b1.click();
        
        b2.Command = new UnderLineCommand(Editor);
        b2.click();
    }
}