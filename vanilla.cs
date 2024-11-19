using System; //The only one namespace we're using in this program.

    class Program //Gives the structure of the program.
    {
        static void Main() //Entry point of the program.
        {
        Console.WriteLine("Academy of Learning Career College"); //Writing out the string.
        Console.WriteLine("Student Daily Report"); //Writing out the string.
        Console.WriteLine("What is your name?"); //Writing out the string.
        string name = Console.ReadLine(); //Storing the answer in the variable.
        Console.WriteLine("What course are you on?"); //Writing out the string.
        string course = Console.ReadLine(); //Storing the answer in the variable.
        Console.WriteLine("What page number?"); //Writing out the string.
        int pageNo = Convert.ToInt32(Console.ReadLine()); //Converting and Storing the answer in the variable.
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //Writing out the string.
        bool isHelpNeeded = bool.Parse(Console.ReadLine()); //Converting and Storing the answer in the variable.
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //Writing out the string.
        string posExp = Console.ReadLine(); //Storing the answer in the variable.
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //Writing out the string.
        string feedback = Console.ReadLine(); //Storing the answer in the variable.
        Console.WriteLine("How many hours did you study today?"); //Writing out the string.
        int studyHours = Convert.ToInt32(Console.ReadLine()); //Converting and Storing the answer in the variable.
        Console.WriteLine("Thank you for your answers.\nAn instructor will respond shortly.\nHave a great day!"); //Writing out the string.

        Console.ReadLine(); //Keeping the Console open.
    }
    }
