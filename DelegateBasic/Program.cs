namespace DelegateBasic;

class Program
{
    delegate void LogDel(string text);   // define a delegate type, named LogDel, contains a definition for a method that does not return a value and contains one string parameter
    static void Main(string[] args)
    {
        Log log = new Log();
        LogDel LogTextToScreenDel, LogTextToFileDel;
        LogTextToScreenDel = new LogDel(log.LogTextToScreen);
        LogTextToFileDel = new LogDel(log.LogTextToFile);
        LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;
        //LogDel logDel = new LogDel(LogTextToScreen);
        Console.WriteLine("Please enter your name");
        var name = Console.ReadLine();
        LogText(LogTextToScreenDel, name);
        

        Console.ReadKey();

    }

    static void LogText(LogDel logDel, string text)
    {
        logDel(text);
    }


    public class Log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");  // write the text argument value to the screen
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }


}

