namespace TextEditor.Models;

public class Editor
{
    private Stack<string> undo {get; set;}
    private Stack<string> redo {get; set;}
    private string content {get; set;} = string.Empty;
    public Editor()
    {
        this.undo = new();
        this.redo = new();
    }

    void Update()
    {
        content = string.Join("\n", undo.ToList().AsEnumerable().Reverse());
    }
    public string write(string text)
    {
        Console.WriteLine("Prv: "+this.content);
        this.undo.Push(text);
        this.Update();
        return this.content;
    }

    public string Undo()
    {
        if (this.undo.Count > 0)
        {
            this.redo.Push(this.undo.Pop());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The undo stack is empty.");
            Console.ResetColor();
        }
        this.Update();
        return content;
    }

    public string Redo()
    {
        if (this.redo.Count > 0)
        {
            this.undo.Push(this.redo.Pop());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The redo stack is empty.");
            Console.ResetColor();
        }
        this.Update();
        return this.content;
    }
}