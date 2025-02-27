namespace TextEditor.Models.CommandPattern;

public interface Command
{
    void Execute();
}

public class BoldCommand : Command
{
    private TextEditor _editor;

    public BoldCommand(TextEditor editor)
    {
        _editor = editor;
    }
    

    public void Execute()
    {
        _editor.boldText();
    }
}

public class ItalicCommand : Command
{
    private TextEditor _editor;

    public ItalicCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.italicizeText();
    }
}

public class UnderLineCommand : Command
{
    private TextEditor _editor;

    public UnderLineCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.underlineText();
    }
}


public class Button
{
    public Command Command { get; set; }
    
    public void click()
    {
        Command.Execute();
    }
}
public class TextEditor
{
    public void boldText()
    {
        Console.WriteLine("text has been bolded");
    }

    public void italicizeText()
    {
        Console.WriteLine("text has been italicize");
    }

    public void underlineText()
    {
        Console.WriteLine("text has been underlined");
    }
}
