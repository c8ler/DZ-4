/* Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[amount];
for (int i = 0; i < amount; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i = 0; i < amount; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}
Console.Write("]");