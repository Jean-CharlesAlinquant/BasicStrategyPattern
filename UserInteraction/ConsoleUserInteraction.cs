namespace BasicStrategyPattern.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string? InputFilter()
    {
        return Console.ReadLine();
    }
}
