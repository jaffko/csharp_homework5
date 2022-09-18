// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10,11);
    }
    return result;
}

int sumOddIndex(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2) result = result + array[i];
    return result;
}

System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(N);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Сумма всех элементов на нечетных позициях равна {sumOddIndex(array)}");
