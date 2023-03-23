var upperBound = 10;
var someDict = new Dictionary<string, double>();
var someNewDict = new Dictionary<string, double>();
someFillingFunction(someDict);
someDict.Select(kvp => kvp.Key).ToList().ForEach(Key => { if (someDict[Key].Value < upperBound ) someNewDict.Add(Key, someDict[Key]);});
