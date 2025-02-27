namespace TextEditor.Models;

public class GraphicEditor
{
    private int x;
    private int y;
    private string color;
    private string size;
    private string shapeType;
    
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public string Color { get => color; set => color = value; }
    public string Size { get => size; set => size = value; }
    public string ShapeType { get => shapeType; set => shapeType = value; }

    public string getGraphic()
    {
        return "Shape: "+ShapeType+", Position :( "+x+","+y+"), Size: "+size+", Color: "+color;
    }
}

class Handler
{
    
    private Stack<GraphicEditor> undo { get; set; }
    private Stack<GraphicEditor> redo { get; set; }

    public Handler()
    {
        this.undo = new();
        this.redo = new();
    }

    public void AddGraphic(GraphicEditor graphic)
    {
        this.undo.Push(graphic);
    }

    public void Undo()
    {
        if (this.undo.Count > 0)
        {
            this.redo.Push(this.undo.Pop());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nothing to undo");
            Console.ResetColor();
        }
    }

    public void Redo()
    {
        if (this.redo.Count > 0)
        {
            this.undo.Push(this.redo.Pop());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nothing to redo");
            Console.ResetColor();
        }
    }

    public GraphicEditor Print()
    {
        if (this.undo.Count > 0)
        {
            return this.undo.Pop();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nothing to print");
            Console.ResetColor();
        }

        return null;
    }
}


public class Editor2{}