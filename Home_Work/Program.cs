
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите число А: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int i = 2;
int tmp = NumberA;

while(i <= NumberB){
    NumberA = NumberA * tmp;
    i++;
}

System.Console.WriteLine($"Ваше число в натруральной степени {NumberA} ");