/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
while (true)
{
    Console.Write("Введите число A: ");
    double a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    double stepen = Convert.ToInt32(Console.ReadLine());
    double result = Math.Pow(a, stepen);
    Console.WriteLine($"{a} в степени {stepen} равняется {result}");
}
