﻿int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

int[] arr2 = new int[5] { 5, 7, 5, 4, 3 };
int[] arr3 = { 5, 7, 5, 4, 3 }; // команду выделения памяти можно не использовать, когда задаём факсированный массив
