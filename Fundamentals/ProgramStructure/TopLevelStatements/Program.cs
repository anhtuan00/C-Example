// using System.Text;

// StringBuilder builder = new();
// builder.AppendLine("Hello");
// builder.AppendLine("World!");

// Console.WriteLine(builder.ToString());

// MyClass.TestMethod();
// MyNamespace.MyClass.MyMethod();

// public class MyClass
// {
//     public static void TestMethod()
//     {
//         Console.WriteLine("Hello World!");
//     }

// }

// namespace MyNamespace
// {
//     class MyClass
//     {
//         public static void MyMethod()
//         {
//             Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
//         }
//     }
// }

// if (args.Length > 0)
// {
//     foreach (var arg in args)
//     {
//         Console.WriteLine($"Argument={arg}");
//     }
// }
// else
// {
//     Console.WriteLine("No arguments");
// }

// Console.Write("Hello ");
// await Task.Delay(5000);
// Console.WriteLine("World!");

// string? s = Console.ReadLine();

// int returnValue = int.Parse(s ?? "-1");
// return returnValue;

// public struct Coords
// {
//     public int x, y;

//     public Coords(int p1, int p2)
//     {
//         x = p1;
//         y = p2;
//     }
// }

// MyClass myClass = new MyClass();
// MyClass myClass2 = myClass;

// List<string> stringList = new List<string>();
// stringList.Add("String example");
// // compile time error adding a type other than a string:
// stringList.Add(4);

object anotherMessage = "This is another string of characters";
IEnumerable<char> someCharacters = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine(anotherMessage);
Console.WriteLine(someCharacters);