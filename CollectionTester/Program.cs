using MyCollections;

/*
  var intList = new List<int>();
  var strList = new List<string>();
  var decimalList = new List<decimal>();
  var listListString = new List<List<string>>();
*/

var myList = new MyList<int>();
// Todo: Unsere Liste für alle Datentypen generalisieren!
// eg. var myListListString = new MyList<MyList<string>>();

myList.Add(1); // index 0
myList.Add(2); // index 1
myList.Add(3); // index 2

Console.WriteLine(myList.Get(1));

var myStringList = new MyList<string>();
myStringList.Add("Generics"); // index 0
myStringList.Add("sind"); // index 1
myStringList.Add("toll"); // index 2
myStringList.Add(":)"); // index 3

Console.WriteLine(myStringList.Get(3));

var defaultList = new List<string>();
defaultList.Add("1");
defaultList.Add("2");
defaultList.Add("3");
defaultList.Add("3");
/*
  var x = defaultList.FindAll(
    (item) => item == "3"); // result ["3", "3"]
  defaultList.Distinct();
*/

// myStringList.Count = 42069; // private set restricts this...

// Iteration durch myStringList, print all strings in list
for (int i = 0; i < myStringList.Count; i++)
{
  Console.WriteLine(myStringList.Get(i));
}

Console.WriteLine("---Array-Indexer-implementiert---");

for (int i = 0; i < myStringList.Count; i++)
{
  Console.WriteLine(myStringList[i]);
}

Console.WriteLine("---Array-Indexer-Setter-implementiert---");

for (int i = 0; i < myStringList.Count; i++)
{
  myStringList[i] += ";";
  Console.WriteLine(myStringList[i]);
}

// foreach (var x in myStringList)
// {
//
// }
