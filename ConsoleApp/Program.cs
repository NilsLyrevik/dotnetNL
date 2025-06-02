using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        int uAmount = 0;
        string uName = "user";
        Introduction();
        uName = AskUserName();
        uAmount = AskUserBalance(uName);
        ExplainGame();

        int upperBoundI = AskUpperBound();
        int nGuesse = AskNumberOfGuesses(upperBoundI);

        HashSet<int> guesseSet = GenerateGuesses(nGuesse, upperBoundI);
        int bet = AskBet(uAmount);
        uAmount -= bet;

        int payout = CalculatePayout(upperBoundI, nGuesse, bet);

        Thread.Sleep(1000);
        Console.WriteLine("Ok, if you pick the same number as me, the payout will be: " + payout);

        Thread.Sleep(1000);
        Console.WriteLine("Please enter your guess: ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);

        Boolean isCollision = guesseSet.Contains(guess);
        if (isCollision)
        {
            uAmount += payout;
            Console.WriteLine("you won! your total balance is: " + uAmount);
        }
        else
        {
            Console.WriteLine("You lost... new balance is: " + uAmount);
        }
    }

    static void Introduction()
    {
        Console.WriteLine("(This is test code written by Nils Lyrevik to learn .NET and C#!)");
        Thread.Sleep(1000);
        Console.WriteLine("Hello! welcome to terminal gambling!");
        Thread.Sleep(1000);
    }

    static string AskUserName()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }

    static int AskUserBalance(string uName)
    {
        Console.WriteLine("How much balance does " + uName + " want to start with?");
        int amount = 0;
        while (amount < 10 || amount > 1000)
        {
            Console.WriteLine("please enter a number between 10 and 1000");
            string tempAmount = Console.ReadLine();
            amount = int.Parse(tempAmount);
        }
        Console.WriteLine("ok! amount is: " + amount);
        Thread.Sleep(1000);
        return amount;
    }

    static void ExplainGame()
    {
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
    }

    static int AskUpperBound()
    {
        Console.WriteLine("pick a max number:");
        int upperBoundI = 0;
        while (upperBoundI > 50000 || upperBoundI < 2)
        {
            string upperBoundS = Console.ReadLine();
            upperBoundI = int.Parse(upperBoundS);
        }
        return upperBoundI;
    }

    static int AskNumberOfGuesses(int upperBoundI)
    {
        Console.WriteLine("Ok, pick amount of guesses i get");
        int nGuesse = 0;
        while (nGuesse <= 0 || nGuesse >= upperBoundI)
        {
            string nGuesseS = Console.ReadLine();
            nGuesse = int.Parse(nGuesseS);
        }
        return nGuesse;
    }

    static HashSet<int> GenerateGuesses(int nGuesse, int upperBoundI)
    {
        HashSet<int> guesseSet = new HashSet<int>();
        Random rand = new Random();
        for (int i = 0; i < nGuesse; i++)
        {
            guesseSet.Add(rand.Next(0, upperBoundI + 1));
        }
        Console.WriteLine("Ok, I have picked " + nGuesse + " numbers now");
        return guesseSet;
    }

    static int AskBet(int currentAmount)
    {
        int bet = 0;
        while (bet < 1 || bet > currentAmount)
        {
            Console.WriteLine("Ok, please place your bet ( 1 - " + currentAmount + ")");
            string betString = Console.ReadLine();
            bet = int.Parse(betString);
        }
        return bet;
    }

    static int CalculatePayout(int upperBoundI, int nGuesse, int bet)
    {
        return (int)(((double)upperBoundI / nGuesse) * bet);
    }
}
