// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int[] numbers = new int[8];
Console.Write("Случайно сгенерированный массив из 8 элементов: \n[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}

int[] myArray = numbers;
int largest = int.MinValue;
int second = int.MinValue;
foreach (int i in myArray)
{
    if (i > largest)
    {
        second = largest;
        largest = i;
    }
    else if (i > second)
        second = i;
}

Console.WriteLine($"\nВторой максимальный элемент = {second}");