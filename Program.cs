/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] Array = new string[4] {"hello", "122", "world", ":))"};
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]}, ");
    if(Array[i].Length < 4)
    {
        count++;
    }
}
Console.WriteLine();

string[] Array1 = new string[count];
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length < 4)
    {
        Array1[j]=Array[i];
        Console.Write($"{Array1[j]}, ");
        j++;
    }
}