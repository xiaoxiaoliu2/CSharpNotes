namespace DelegateBasic;

class Program
{
    public delegate bool FilterDelegate(Person p);
    static void Main(string[] args)
    {


        //list of names
        List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
        Console.WriteLine("----before----");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        names.RemoveAll(Filter);

        Console.WriteLine("----after----");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("----Create delegate----");
        Person p1 = new Person() { Name = "Aiden", Age = 41 };
        Person p2 = new Person() { Name = "Sif", Age = 69 };
        Person p3 = new Person() { Name = "Walter", Age = 12 };
        Person p4 = new Person() { Name = "Anatoli", Age = 25 };

        List<Person> people = new List<Person>() { p1, p2, p3, p4 };

        DisplayPeople("Kids", people, IsMinor);
        DisplayPeople("Adult", people, IsAdult);
        DisplayPeople("Senior", people, IsSenior);


        // anonymous method
        FilterDelegate filter = delegate (Person p)
        {
            return p.Age >= 20 && p.Age <= 30;
        };

        DisplayPeople("Between 20 and 30:", people, filter);
        DisplayPeople(
            "All: ",
            people,
            delegate (Person p) { return true; });


        // lambda expression: statement lambda
        string searchKeyword = "A";
        DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, (p) =>
        {
            if (p.Name.Contains(searchKeyword) && p.Age > 20)
            {
                return true;
            } else
            {
                return false;
            }
        });
        // lambda expression: expression lambda
        DisplayPeople("exactly 25: ", people, p => p.Age == 25);



    }

    static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
    {
        Console.WriteLine(title);
        foreach (Person p in people)
        {
            if (filter(p))
            {
                Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            }
        }
    }

    //===========FILTERS==============
    static bool IsMinor(Person p)
    {
        return p.Age < 18;
    }

    static bool IsAdult(Person p)
    {
        return p.Age >= 18;
    }

    static bool IsSenior(Person p)
    {
        return p.Age > 60;
    }




    // a method called Filter that takes a string
    static bool Filter(string s)
    {
        // return whether the string s contains the letter 'i'
        // the Contains method will return a bool which we will return as well
        return s.Contains("i");
    }
 
}



// define a delegate type, named LogDel, contains a definition for a method that does not return a value and contains one string parameter


//Log log = new Log();
//LogDel LogTextToScreenDel, LogTextToFileDel;
//LogTextToScreenDel = new LogDel(log.LogTextToScreen);
//LogTextToFileDel = new LogDel(log.LogTextToFile);
//LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;
////LogDel logDel = new LogDel(LogTextToScreen);
//Console.WriteLine("Please enter your name");
//var name = Console.ReadLine();
//LogText(LogTextToScreenDel, name);


//Console.ReadKey();

//static void LogText(LogDel logDel, string text)
//{
//    logDel(text);
//}

//public class Log
//{
//    public void LogTextToScreen(string text)
//    {
//        Console.WriteLine($"{DateTime.Now}: {text}");  // write the text argument value to the screen
//    }

//    public void LogTextToFile(string text)
//    {
//        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
//        {
//            sw.WriteLine($"{DateTime.Now}: {text}");
//        }
//}
//}
