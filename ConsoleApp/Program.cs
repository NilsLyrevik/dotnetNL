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

        }
    }