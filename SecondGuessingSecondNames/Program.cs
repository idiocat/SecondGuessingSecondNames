using System;

namespace SecondGuessingSecondNames;
class Program
{
    static void Main()
    {
        InputInteractor interactor = new InputInteractor();
        interactor.InputIdentifiedEvent += FirstGuess;

        while (true)
        {
            try { interactor.IdentifyInput(); }
            catch (IncorrectException) { Console.WriteLine("Input is incorrect, try again... "); }
        }
    }
    static List<string> SecondGuess(List<string> secondNames, bool reverse = false)
    {
        if (reverse) { secondNames.Sort((x, y) => string.Compare(y, x)); }
        else { secondNames.Sort((x, y) => string.Compare(x, y)); }
        return secondNames;
    }
    static void ShowSecondNames(List<string> secondNames)
    {
        foreach (string secondName in secondNames) { Console.WriteLine(secondName); }
        Console.WriteLine();
    }
    static void FirstGuess(string input)
    {
        List<string> secondNames = ["Perry",
            "Figueroa",
            "Russell",
            "Santos",
            "Stevens",
            "Richards",
            "Foster",
            "Mcgee",
            "Houghton",
            "Ross"];

        switch (input)
        {
            case "1": ShowSecondNames(SecondGuess(secondNames)); break;
            case "2": ShowSecondNames(SecondGuess(secondNames, true)); break;
            case "3": System.Environment.Exit(0); break;
        }
    }
}