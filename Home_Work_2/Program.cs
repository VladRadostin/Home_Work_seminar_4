
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов: ");
int Number = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[Number];

for (int i = 0; i < Number; i++)
{
    randomArray[i] = new Random().Next(1,99);
    Console.Write(randomArray[i] + " ");
}