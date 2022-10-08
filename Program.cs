// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВведите степень возведения: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int NumStepen = 1;
//   for(int i=0; i<num2; i++) 
//   {
//    NumStepen = NumStepen*num1;
//   }
//   Console.WriteLine("{0} ^ {1} = {2}", num1, num2, NumStepen);


// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numSum = 0; 

// while (0 < num)
// {
//     numSum = (num % 10) + numSum;
//     num = num / 10;
// }
//     Console.WriteLine($"Сумма цифр в числе: {numSum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int [] array = new int [8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,100);
//     Console.Write($"{array[i]} ");
// }