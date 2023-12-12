namespace DelegateBasicExample;

class Program
{
    delegate void LogDel(string text);   // define a delegate type, named LogDel, contains a definition for a method that does not return a value and contains one string parameter
    static void Main(string[] args)
    {
        LogDel logDel = new LogDel(LogTextToScreen);
        Console.WriteLine("Please enter your name");
        var name = Console.ReadLine();
        logDel(name);
        Console.ReadKey();

    }

    static void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");  // write the text argument value to the screen
    }

    //static void LogTextToFile(string text)
    //{
       
    //}

}

