using TextEditor.Models;

namespace TextEditor.views;

public class EditorApp
{
    private static Editor _editor = new();
    private static string? _content;
    
    public void Run()
    {
        Console.WriteLine(" ---------------- Hello World! ------------------ ");
        bool run = true;
        while (run)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----------  Editor ----------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_content);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            
            Console.WriteLine("1. Write\n2. Undo\n3. Redo");
            Console.ResetColor();
            Console.Write("Enter your choice: ");
            int? inp = Convert.ToInt32(Console.ReadLine());
            int op = inp ?? 0;
            if (op == 1)
            {
                Console.Write("Enter text: ");
                string? text = Console.ReadLine();
                _content = _editor.write(text ?? string.Empty);
            }
            else if (op == 2)
            {
                Console.WriteLine("Undo");
                _content = _editor.Undo();
            }
            else if (op == 3)
            {
                Console.WriteLine("Redo");
                _content = _editor.Redo();
            }
            else
            {
                run = false;
            }
            Console.Write("Continue [No-(n)]:>> ");
            string? clear = Console.ReadLine();
            if (clear != "n")
            {
                Console.Clear();
            }
        }
    }
}