/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();
Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
int SumChisel(int num)
{
    int sum = 0;
    int vremennoeChislo = num;
    while (vremennoeChislo > 0)
    {
        sum = sum + vremennoeChislo % 10;
        vremennoeChislo = vremennoeChislo / 10;
    }
    return sum;
}
int result = SumChisel(chislo);
Console.WriteLine($"Сумма чисел в числе {chislo} равна {result}");