// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void GetEvenNums(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

int userNum = ReadInt("Введите число");
int[] arr = GenerateArray(userNum);
ShowArray(arr);
System.Console.WriteLine();
GetEvenNums(arr);


