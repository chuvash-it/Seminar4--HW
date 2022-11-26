//Урок 4. Функции

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

 Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени B: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
for (int i = 1; i < b; i++)
{
   res = res * a;
}
Console.WriteLine(res);

//вариант 2
//if (b > 0)
//{
//    double res = Math.Pow(a, b);
//    Console.WriteLine(res);
//}
//else     
//Console.WriteLine("Вы ввели не натуральное число B");