// See https://aka.ms/new-console-template for more information
using TestHoneywell;

Tasks.TwoThrees();


var inputNumbers1 = new List<int>(new[] { 5, 3, 3, 1, 0, 0, -2, -2, -5 });
var inputNumbers2 = new List<int>(new[] { 1, 2, 3, 3, 3, 4, 4, 10, 13, 15, 15, 17 });
var inputNumbers3 = new List<int>(new[] { 1, 2, 2 , 2, 3, 3, 3, 4, 4, 10, 13, 13, 15, 15, 17,18 });

Console.WriteLine(Tasks.CountDuplicates(inputNumbers1));
Console.WriteLine(Tasks.CountDuplicates(inputNumbers2));
Console.WriteLine(Tasks.CountDuplicates(inputNumbers3));

