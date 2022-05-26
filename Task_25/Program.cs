/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int stepen = Convert.ToInt32(Console.ReadLine());

int VozvVStepen (int chislo1, int chislo2)
{
    int result = 1;
    int i = 0;
    while (i < chislo2)
    {
        result = result * chislo1;
        i++;
    }
    return result;
}
int res = VozvVStepen(a, stepen);
Console.WriteLine($"{a} в степени {stepen} равняется {res}");

