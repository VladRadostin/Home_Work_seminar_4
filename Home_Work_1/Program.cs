// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Amount(int num)
{
    string num1 = Convert.ToString(num);
    int len = num1.Length;
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр в числе {Number} равно: {Amount(Number)}");



