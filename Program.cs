//Урок 4. Функции

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

 //Console.Write("Введите число А: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число степени B: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int res = a;
//for (int i = 1; i < b; i++)
//{
//    res = res * a;
//}
//Console.WriteLine(res);

//вариант 2
//if (b > 0)
//{
//    double res = Math.Pow(a, b);
//    Console.WriteLine(res);
//}
//else     
//Console.WriteLine("Вы ввели не натуральное число B");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int res = 0;
//while (num > 0)
//{
//    res = res + num % 10;
//    num = num / 10;
//}
//Console.Write(res);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
void random (int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0, 99);
        Console.Write(arr[i] + " ");
    }
}
random(array);