using TextEditor.Models;

namespace TextEditor.views;

public class StockNotifyApp
{
    StockNotification app = new StockNotification();
    public  void Run()
    {
        Stock s1 = new Stock()
        {
            Name = "Meta",
            Price = 23234.23
        };
        Stock s2 = new Stock()
        {
            Name = "Nvidia",
            Price = 98234.23
        };
        Stock s3 = new Stock()
        {
            Name = "OpenAI",
            Price = 5433.654
        };
        Stock s4 = new Stock()
        {
            Name = "CLN",
            Price = 514.23
        };
        
        StockHolder p1 = new StockHolder("Varun",400);
        StockHolder p2 = new StockHolder("Charn",1000);
        StockHolder p3 = new StockHolder("Chakram",60);
        StockHolder p4 = new StockHolder("Prashanta",0);

        app.Subscribe(p1);
        app.Subscribe(p2);
        app.Subscribe(p3);
        
        Console.WriteLine("--------------------------------------------------------------");
        app.NotifyAll(s3,newPrice:3023.1323);
        Console.WriteLine("--------------------------------------------------------------");
        app.Subscribe(p4);
        
        app.Unsubscribe(p3);
        Console.WriteLine("--------------------------------------------------------------");
        app.NotifyAll(s1,newPrice:73334.53);
        Console.WriteLine("--------------------------------------------------------------");
        
        app.Subscribe(p3);
        
        app.NotifyAll(s2,newPrice:123422.19);
        Console.WriteLine("--------------------------------------------------------------");
        app.NotifyAll(s4,newPrice:2625.19);
        Console.WriteLine("--------------------------------------------------------------");
        
        Console.WriteLine("--------------------------------------------------------------");
        app.NotifyAll(s3,323.554);
        Console.WriteLine("--------------------------------------------------------------"); 
        Console.WriteLine("--------------------------------------------------------------");
        app.NotifyAll(s3,445.40);
        Console.WriteLine("--------------------------------------------------------------");
    }

}