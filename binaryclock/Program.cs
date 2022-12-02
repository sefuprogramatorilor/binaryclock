using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Timer timer = null;
        timer = new Timer(TimerCallback, null, 0, 1000);

        Console.ReadLine();
    }

    private static void TimerCallback(object o)
    {
        Console.Clear();
        Console.WriteLine($"Current time: {DateTime.Now.ToLongTimeString()}");
        Console.WriteLine($"Current time in binary: {Convert.ToString(DateTime.Now.Hour, 2)} : {Convert.ToString(DateTime.Now.Minute, 2)} : {Convert.ToString(DateTime.Now.Second, 2)}");
        Console.WriteLine("Press any key to stop.");

    }
}
