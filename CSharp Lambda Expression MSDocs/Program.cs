// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Func<int, int> square = x => x * x;
//Console.WriteLine(square(10));

//System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
//Console.WriteLine(e);

//Action<string> greet = name =>
//{
//    var str = "Hello " + name;
//    Console.WriteLine(str);
//};

//greet("xyz");

//Not passing any parameters
Console.WriteLine("Before Execution!!");
Action line = () => Console.WriteLine();
line();
Console.WriteLine("After Execution!!");

//Passing one parameter
Action<string> printMessage = (message) => Console.WriteLine(message);
printMessage("My Message!");

//Passing multiple Parameters
Func<int, int, bool> checkForEquality = (x, y) => x == y;
Console.WriteLine(checkForEquality(100, 100));

Console.ReadKey();  