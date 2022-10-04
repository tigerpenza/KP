using System;
using static System.Console;

string[] ChangeArray(string[] array)   
{                                                  
    int sizeNewArray = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            sizeNewArray++;

    string[] newArray = new string[sizeNewArray];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

void ShowArray(string[] array)
{
    Write($"[{String.Join(", ", array)}]");
}

Write("Enter an array of strings: ");
string[] startArr = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 

string[] newArr = ChangeArray(startArr);
ShowArray(startArr);
Write(" -> ");
ShowArray(newArr);