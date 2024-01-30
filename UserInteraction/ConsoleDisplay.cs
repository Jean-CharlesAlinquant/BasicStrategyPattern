namespace BasicStrategyPattern.UserInteraction;

public class ConsoleDisplay : IDisplayResults
{
    private readonly IUserInteraction _userInteraction;

    public ConsoleDisplay(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }
    public void Print<T>(IEnumerable<T> items)
    {
        _userInteraction.PrintMessage(string.Join(", ", items));
    }
}
