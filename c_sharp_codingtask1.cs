// declares and initializes the variable "upperBound" with the value 10
var upperBound = 10;
// creates a new empty dictionaries with a string and double parameter
var someDict = new Dictionary<string, double>();
// creates another empty dictionary with a string and double parameter
var someNewDict = new Dictionary<string, double>();
// calls the "someFillingFunction" with "someDict" as argument, function not shown here (so don't know what it really does)
someFillingFunction(someDict);
// selects in the dictionary "someDict" the kvp values and uses the lambda expression to collect the key attributes in a list
// for each list item (amout of keys in the list of kvp.Key) the if experession is iterated
someDict.Select(kvp => kvp.Key).ToList().ForEach(Key => {
    // checks if value of Key is smaller than the upperBound (10) and if this statement is true the Key is added to "someNewDict"
    if (someDict[Key].Value < upperBound ) someNewDict.Add(Key, someDict[Key]);
});
// additional task: pipe from C# to python
static void JsonPipe(Dictionary dict, string fileName){
    var jsonF = JsonSerializer.Serialize(dict);
    File.WriteAllText(CONST_PATH + fileName, jsonF);
}
// uses the (new) pipe function
JsonPipe(someDict, "file.json");