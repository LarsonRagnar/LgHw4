// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (A > 0)
// {
//     int digit = A % 10;
//     count += digit;
//     A /= 10;
// }
// Console.WriteLine($"Сумма цифр в числе{A} равна {count}");

//  Напишите программу, которая задаёт 
//  массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] GetBinaryArray(int size)
// {
// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Введите число: ");
//     array[i] = int.Parse(Console.ReadLine());
// }
// return array;
// }
// int[] resultArray = GetBinaryArray(8);
// Console.WriteLine($"Массив:  [{String.Join(";", resultArray)}]");

// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Введите число A ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int C = 1;
// for (int i = 0; i < B; i++)
// {
//     C *= A;
// }
// Console.WriteLine($"Число {A} в Степени числа {B} будет {C} ");



