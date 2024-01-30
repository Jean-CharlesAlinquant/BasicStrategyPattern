using BasicStrategyPattern.App;
using BasicStrategyPattern.UserInteraction;

var userInteraction = new ConsoleUserInteraction();
var displayResults = new ConsoleDisplay(userInteraction);
var app = new BasicStrategyPatternApp(userInteraction, displayResults);
app.Run();