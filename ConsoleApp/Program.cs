using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int uAmount = 0;
        string uName = "user";
        Console.WriteLine("(This is test code written by Nils Lyrevik to learn .NET and C#!)");
        Thread.Sleep(1000);

        Console.WriteLine("Hello! welcome to terminal gambling!");
        Thread.Sleep(1000);

        Console.WriteLine("What is your name? ");

        uName = Console.ReadLine();

        Console.WriteLine("How many coins does " + uName + " want to start with?");
        while (uAmount < 10 || uAmount > 1000)
        {
            Console.WriteLine("please enter a number between 10 and 1000");
            string tempAmount = Console.ReadLine();
            uAmount = int.Parse(tempAmount);
        }
        Console.WriteLine("ok! amount is: " + uAmount);
        Thread.Sleep(1000);
        Console.WriteLine("The game works as follows:");
        Thread.Sleep(1000);
        Console.WriteLine("Pick number in the range 2 - 50'000");
        Thread.Sleep(1000);
        Console.WriteLine("Pick amount of numbers I am going to pick from that range");
        Thread.Sleep(1000);
        Console.WriteLine("(Has to be less than roof AND more than 0)");
        Thread.Sleep(1000);
        Console.WriteLine("If you are right I will increase your bet accordingly");


        Console.WriteLine("Lets Begin!");
        Thread.Sleep(1000);
        Console.WriteLine("pick a max number:");
        int upperBoundI = 0;

        while (upperBoundI > 50000 || upperBoundI < 2)
        {
            string upperBoundS = Console.ReadLine();
            upperBoundI = int.Parse(upperBoundS);

        }

        Console.WriteLine("Ok, pick amount of guesses i get");

        int nGuesse = int.Parse(nGuesseS);
        while (nGuesse < 0 || nGuesse >= upperBoundI)
        {
            string nGuesseS = Console.ReadLine();
            int nGuesse = int.Parse(nGuesseS);

        }
        // skriv logik angående gissningar här, 
       
       // tänk på att printa ut resultat pch användarens pengar och sånt.

    }
    }