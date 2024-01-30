using BasicStrategyPattern.Strategy;
using BasicStrategyPattern.UserInteraction;

namespace BasicStrategyPattern.App;

public class BasicStrategyPatternApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IDisplayResults _displayResults;
    public BasicStrategyPatternApp(
        IUserInteraction userInteraction,
         IDisplayResults displayResults)
    {
        _userInteraction = userInteraction;
        _displayResults = displayResults;
    }

    public void Run()
    {
        var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };
        var filteringStrategySelector = new FilteringStrategySelector();
        _userInteraction.PrintMessage("Select filter:");
        _userInteraction.PrintMessage(
            string.Join(
                Environment.NewLine,
                filteringStrategySelector.FilteringStrategiesNames));

        var userInput = _userInteraction.InputFilter();
        var filteringStrategy = filteringStrategySelector.Select(userInput);
        var result = new Filter().FilterBy(filteringStrategy, numbers);
        _displayResults.Print(result);

        // Passing a custom filter directly to the Filter class method 
        var words = new[] { "zebra", "ostrich", "otter" };
        var oWords = new Filter().FilterBy(word => word.StartsWith("o"), words);
        _displayResults.Print(oWords);
    }
}
