namespace BasicStrategyPattern.Strategy;

public class FilteringStrategySelector
{
    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies =
        new Dictionary<string, Func<int, bool>>
        {
            ["Even"] = number => number % 2 == 0,
            ["Odd"] = number => number % 2 == 1,
            ["Positive"] = number => number > 0,
            ["Negative"] = number => number < 0,
        };

    public IEnumerable<string> FilteringStrategiesNames =>
        _filteringStrategies.Keys;

    public Func<int, bool> Select(string filterType)
    {
        if (!_filteringStrategies.ContainsKey(filterType))
        {
            throw new NotSupportedException($"{filterType} is not a valid filter");
        }
        return _filteringStrategies[filterType];
    }
}
