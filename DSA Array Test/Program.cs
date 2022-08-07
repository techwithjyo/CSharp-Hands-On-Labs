// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr1 = { 1, 2, 3, 4, 5, 6 };

int[] arr2 = arr1;

arr1[0] = 10;

Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[0]);
Console.ReadLine();