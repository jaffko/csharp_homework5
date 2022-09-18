// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1,1000);
    }
    return result;
}

int countEven (int[] arr)
{
    int result = 0;
    foreach(int item in arr)
    {
        if (item % 2 == 0) result++;
    }
    return result;
}

System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(N);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Количество четных чисел равно {countEven(array)}");
