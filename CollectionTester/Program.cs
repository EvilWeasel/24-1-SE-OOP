using MyCollections;

/*
  var intList = new List<int>();
  var strList = new List<string>();
  var decimalList = new List<decimal>();
  var listListString = new List<List<string>>();
*/

var myList = new MyList();
// Todo: Unsere Liste für alle Datentypen generalisieren!
// eg. var myListListString = new MyList<MyList<string>>();

myList.Add(1); // index 0
myList.Add(2); // index 1
myList.Add(3); // index 2

Console.WriteLine(myList.Get(1));
