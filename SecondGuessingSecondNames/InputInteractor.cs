using System;

namespace SecondGuessingSecondNames;
class InputInteractor
{
    public delegate void InputIdentifiedDelegate(string input);
    public event InputIdentifiedDelegate InputIdentifiedEvent;
    public void IdentifyInput()
    {
        Console.Write("Enter [1 2 3]... ");
        string input = Console.ReadKey().KeyChar.ToString();
        Console.Write(Environment.NewLine);

        if (!new List<string> { "1", "2", "3" }.Contains(input)) { throw new IncorrectException(); }
        InputIdentified(input);
    }
    protected virtual void InputIdentified(string input)
    {
        InputIdentifiedEvent?.Invoke(input);
    }

}
