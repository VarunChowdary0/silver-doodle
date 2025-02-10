using System.Threading.Channels;

namespace TextEditor.views;

public class DestinationGame
{
    private static int dimentions = 10;
    private static int D_x = new Random().Next(0,dimentions);
    private static int D_y = new Random().Next(0,dimentions);
    private static string message = "";
    private static int X = 0;
    private static int Y = 0;

    private static int points = 0;
    private static int x_pts;
    private static int y_pts;
    
    private static int count = 0;
    
    private static DateTime startTime;
    private static DateTime endTime;
    private static int moves = -1;
    private static int reqMoves = Math.Abs(X - D_x) + Math.Abs(Y - D_y);

    private void Map()
    {
        if (count % 7 == 0)
        {
            x_pts = new Random().Next(0,dimentions);
            y_pts = new Random().Next(0,dimentions);
        }
        count+=new Random().Next(0,999);
        for (int x = 0; x < dimentions; x++)
        {
            for (int y = 0; y < dimentions; y++)
            {
                if ((D_x == x && D_y == y) && (X == x && Y == y))
                {
                    message = "Hurray!, Destination Reached ✅";
                    Console.Write(" ✅ ");

                }
                else if (D_x == x && D_y == y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" 👹 ");
                    count += new Random().Next(0,6);
                    Console.ResetColor();
                }
                else if (X == x && Y == y)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    double distance = Math.Sqrt(Math.Pow(X - x_pts, 2) + Math.Pow(Y - y_pts, 2));
                    // Console.Write(Convert.ToInt32(distance));
                    if (distance  == 0)
                    {
                        message = "bonus +25";
                        count = 7;

                        Console.Write(" Ⓜ️ ");
                        points += 25;
                    }
                    else if (distance <= 2)
                    {
                        message = "near(2) - Neighbour points! +10";
                        Console.Write(" Ⓜ ");
                        points += 10;
                    }
                    else if (dimentions <= 4)
                    {
                        message = "near(4) - Neighbour points! +5";
                        Console.Write(" Ⓜ ");
                        points += 5;
                    }
                    else
                    {
                        Console.Write(" Ⓜ ");
                    }
                    Console.ResetColor();
                }

               else if(x_pts == x && y_pts == y)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" 🅿 ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(" X ");
                }
            }
            Console.WriteLine();
            
        }
    }
    public void Run()
    {
        startTime = DateTime.Now;
        Console.WriteLine(" ---------------- Hello World! ---------------- ");
        Console.WriteLine($"dimentions : {dimentions} , dest : {D_x} , {D_y} ");
        ConsoleKeyInfo x = new(); 

        bool run = true;
        while (run)
        {
            Console.WriteLine("Contorls : \n" +
                              "⬅️⬆️⬇️➡️");
            switch (x.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Up Arrow Pressed");
                    if (X > 0)
                    { 
                        X--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down Arrow Pressed");
                    if (X < dimentions - 1)
                    { 
                        X++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Left Arrow Pressed");
                    if (Y > 0)
                    { 
                        Y--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Right Arrow Pressed");
                    if (Y < dimentions - 1)
                    { 
                        Y++;
                    }
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Exiting...");
                    message = x.KeyChar.ToString();
                    return;
            }

            if (X == D_x && Y == D_y)
            {
                message = "Hurray!, Destination Reached ✅";
                endTime = DateTime.Now;
                run = false;
            }
            else
            {
                message = "Keep Going 🫡";
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Message: {message} ,\nScore : {points}");
            Console.ResetColor();
            Map();
            Console.Write("Control>> ");
            x = Console.ReadKey();
            if (message != "Hurray!, Destination Reached ✅")
            {
                Console.Clear();
            }
            moves += 1;
        }

        Console.WriteLine(" ----------------------------------------------- ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Score: {points} pts," +
                          $"\nMoves Made: {moves}," +
                          $"\nMinimum required moves : {reqMoves}" +
                          $"\nTime Taken: {endTime - startTime}");
        Console.ResetColor();
    }
}