namespace BasicStrategyPattern.UserInteraction;

public interface IUserInteraction
{
    void PrintMessage(string message);
    string? InputFilter();
}
