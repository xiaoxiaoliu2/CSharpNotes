namespace CSharpNotes;

class Program
{
    static void Main(string[] args)
    {

        // 1. data, variable, and data type
        string characterName = "John";
        int characterAge;
        characterAge = 35;
        Console.WriteLine("There onece was a man named " + characterName);
        Console.WriteLine("He was " + characterAge + " years old.");
        Console.WriteLine("He really liked the name " + characterName);
        Console.WriteLine("But didn't like being " + characterAge);
        Console.WriteLine("Hello, World!");

        // data type: string, character(one single letter), numbers(integer, float, double, decimal), Boolean
        string phrase = "Hello, World!";
        char grade = 'A';
        int age = 30;
        double gpa = 3.2;
        bool isMale = true;


        // \n in string: return a new line
        Console.WriteLine("Hello, \n World!");
        Console.WriteLine("Hello, \" World!");
        Console.WriteLine(phrase);
        Console.WriteLine("Hello, World! " + "Hello back");
        // string method
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.Contains("Hello"));
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase.IndexOf("H"));
        Console.WriteLine(phrase.Substring(7));   //  start at index 7, get all characters left
        Console.WriteLine(phrase.Substring(7,5));  // [7, 13]  start from 7, get 5 characters

        // numbers: integer, decimal
        Console.WriteLine( 50 );
        Console.WriteLine( 2 + 3 );
        Console.WriteLine( 2 * 3 );
        Console.WriteLine( 5 % 2 );  // 1
        Console.WriteLine( 2 + 3 * 4);

        Console.WriteLine( 5 + 2.0 );  //7
        Console.WriteLine(5 + 2.1);  //7.1
        Console.WriteLine( 5 / 2 ); // 2
        int num = 6;
        num++;
        Console.WriteLine(num);

        Console.WriteLine(Math.Abs(-40));   // |-40| = 40
        Console.WriteLine(Math.Pow(3, 2));  // 3^2 = 9
        Console.WriteLine(Math.Sqrt(36));    //  6
        Console.WriteLine(Math.Max(56, 98));
        Console.WriteLine(Math.Min(56, 98));
        Console.WriteLine(Math.Round(56.98));

        // 2. get input from users
        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();     // ReadLine take what the user enter and store into the variable
        //Console.Write("Enter your age: ");
        //string yourage = Console.ReadLine();
        //Console.WriteLine("Hello " + name + " you are " + age);


        // practice
        //Console.Write("Enter a number: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter another number: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(num1 + num2);


        //Console.Write("Enter a number: ");
        //double num3 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter another number: ");
        //double num4 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine(num3 + num4);


        // 3. data structure: Arrays
        int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine(luckyNumbers[1]);
        luckyNumbers[1] = 900;              // change the element value
        string[] friends = new string[5];   // create an empty array with 5 elements
        friends[0] = "Jim";
        friends[1] = "Kelly";


        // 4. method/function
        SayHi("Mike", 21);
        SayHi("Tom", 12);

        // 5. return statements: void refers to return any type of value
        int cubedNumber = cube(5);
        Console.WriteLine(cubedNumber);

        // 6. if, switch, while, for
        bool isAMale = true;
        if (isAMale)
        {
            Console.WriteLine("You are male");
        } else
        {
            Console.WriteLine("You are not male");
        }

        // && and
        bool isTall = true;
        if (isAMale && isTall)
        {
            Console.WriteLine("You are male and tall");
        } else if (isAMale && !isTall)
        {
            Console.WriteLine("You are a short mail");
        } else if (!isAMale && isTall)
        {
            Console.WriteLine("Your are not a male but you are tall");
        } else
        {
            Console.WriteLine("You are not maile and not tall");
        }
        

        // || or
        if (isAMale || isTall)
        {
            Console.WriteLine("You are male or you are tall");
        }
        else
        {
            Console.WriteLine("You are not male and not tall");
        }

        Console.WriteLine(GetMax(2, 10));
        Console.WriteLine(GetMax3(2, 10, 15));


        // switch statement
        Console.WriteLine(GetDay(0));

        // while LOOP
        int index = 1;
        while (index <= 5)
        {
            Console.WriteLine(index);
            index++;
        }


        // game
        string secretWord = "giraffe";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;

        //while (guess != secretWord && !outOfGuesses)
        //{
        //    if(guessCount < guessLimit)
        //    {
        //        Console.Write("Enter guess: ");
        //    guess = Console.ReadLine();
        //    guessCount++;
        //    } else
        //    {
        //        outOfGuesses = true;
        //    }
        //}

        //if (outOfGuesses)
        //{
        //    Console.Write("Your lose!");
        //} else
        //{
        //    Console.Write("You win!");
        //}


        // for LOOP

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }


        for (int i = 0; i < luckyNumbers.Length; i++)
        {
            Console.WriteLine(luckyNumbers[i]);
        }


        // build an exponent method
        Console.WriteLine(GetPow(6, 3));

        // 2d Array
        int[,] numberGrid =
        {
            {1, 2 },
            {3, 4 },
            {5, 6 }
        };
        Console.WriteLine(numberGrid[0, 1]);

        int[,] myArray = new int[2, 3];  // an empty array: 2 rows, 3 colums


        // exception handling

        try
        {
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 / num2);
        }
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }

        // 7. OOP: Classes, Objects, Inheritance, static
        // class is basically just a specification for a new data type
        // class: a template of a book, a book data type, like string
        // object: an instance of a class
        // constructors: a special method in our class, called whenever we create an object of that class, a way to create object   


        Book book1 = new Book("Harry Potter", "JK Rowling", 400);
        //book1.title = "Harry Potter";
        //book1.author = "JK Rowling";
        //book1.pages = 400;
        Console.WriteLine(book1.pages);

        Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
        //book1.title = "Lord of the Rings";
        //book1.author = "Tolkein";
        //book1.pages = 700;
        Console.WriteLine(book2.pages);

        // object method

        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Pam", "Art", 3.6);

        Console.WriteLine(student1.HasHonors());
        Console.WriteLine(student2.HasHonors());


        // Getters, Setters: two methods, control the access to the attributes of those classes
        Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
        Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
        // G, PG, PG-13, R, NR
        
        Console.WriteLine(avengers.Rating);


        // Static attributes, a special attribute in a class, shared by all the objects and all the instances of that class

        Song holiday = new Song("Holiday", "Green Day", 200);
        Console.WriteLine(holiday.artist);    // attribute of the object
        Console.WriteLine(Song.songCount);   // attribute of the class
        Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
        Console.WriteLine(kashmir.artist);
        Console.WriteLine(Song.songCount);
        Console.WriteLine(kashmir.getSongCount());


        // Static Methods & Classes
        UsefulTools.SayHi("Mike");
        Console.WriteLine(Math.Sqrt(144)); // a Math class is a static class, cannot create an instance of that class, ise it directly

        // Inheritance: techique of C#, one class can have all the functionality of another class
        Chef chef = new Chef();  
        chef.MakeSpecialDish();

        ItalianChef italianChef = new ItalianChef();
        italianChef.MakeSpecialDish();




        Console.ReadLine();
    }

    






    // executed only when called
    // block some code to a new method/function meant to perform some specific task, can be reused 
    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello " + name + ", you are " + age);
    }

    static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }


    static int GetMax(int num1, int num2)
    {
        int result;
        if (num1 > num2)
        {
            result = num1;
        } else
        {
            result = num2;
        }
        return result;
    }

    static int GetMax3(int num1, int num2, int num3)
    {
        int result;
        if (num1 >= num2 && num1 >= num3)   // ==, !=, >=, <=
        {
            result = num1;
        } else if (num2 >= num1 && num2 >= num3)
        {
            result = num2;
        } else
        {
            result = num3;
        }
        return result;
    }

    static string GetDay(int dayNum)
    {
        string dayName;
        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid Day Number";
                break;
        }
        return dayName;
    }



    static int GetPow(int baseNum, int powNum)
    {
        int result = 1;
        for ( int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }

        return result;
    }


}

