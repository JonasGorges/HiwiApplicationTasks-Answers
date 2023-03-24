// declares and initializes the variable "upperBound" with the value 10
var upperBound = 10;
// creates a new empty dictionaries with a string and double parameter
var someDict = new Dictionary<string, double>();
// creates another empty dictionary with a string and double parameter
var someNewDict = new Dictionary<string, double>();
// calls the "someFillingFunction" with "someDict" as argument, function not shown here (so don't know what it really does)
someFillingFunction(someDict);
// Niklas ist doof
someDict.Select(kvp => kvp.Key).ToList().ForEach(Key => { if (someDict[Key].Value < upperBound ) someNewDict.Add(Key, someDict[Key]);});
