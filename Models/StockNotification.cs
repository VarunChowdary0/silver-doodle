namespace TextEditor.Models;

public class StockHolder:IObserver0
{
    private string name;
    private int threshold = 0;
    public void Update(Stock stock,double newPrice)
    {
        double margin = newPrice - stock.Price;
        if (Math.Abs(margin) > threshold)
        {
            Console.Write($"User : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{name}");
            Console.ResetColor();
            Console.Write($" Stock : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{stock.Name}");  Console.ResetColor();
            Console.ResetColor();
            Console.Write($" Old Price : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{stock.Price}");
            Console.ResetColor();
            Console.Write($" New Price : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{newPrice}");
            Console.ResetColor();
            if (margin < 0)
            {
                Console.Write($" Margin : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{margin} 📉 \n");
                Console.ResetColor();
            }
            else
            {
                Console.Write($" Margin : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{margin} 📈 \n");
                Console.ResetColor();
            }
        }
    }

    public StockHolder(string name,int threshold)
    {
        this.name = name;
        this.threshold = threshold;
    }

    public string getName()
    {
        return name;
    }
}

public interface ISubject0
{
    void NotifyAll(Stock stock,double newPrice);
    void Subscribe(IObserver0 observer);
    void Unsubscribe(IObserver0 observer);
}

public class StockNotification:ISubject0
{

    private readonly List<IObserver0> _observers;

    public StockNotification()
    {
        this._observers = new List<IObserver0>();
    }
    public void NotifyAll(Stock stock,double newPrice)
    {
        _observers.ForEach(x=>x.Update(stock,newPrice));
        stock.Price = newPrice;
    }
    

    public void Subscribe(IObserver0 observer)
    {
        _observers.Add(observer);
        Console.WriteLine($"new Client -> {observer.getName()} subscribed");
    }

    public void Unsubscribe(IObserver0 observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"Client {observer.getName()} has been unsubscribed");
    }
}