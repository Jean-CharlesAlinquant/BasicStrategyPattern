namespace BasicStrategyPattern.UserInteraction;

public interface IDisplayResults
{
    void Print<T>(IEnumerable<T> numbers);
}
