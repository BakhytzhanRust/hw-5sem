// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// // Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }


// int[] GenerateArray(int Length)
// {
//   int[] array = new int[Length];
//   Random random = new Random();
//   for (int i = 0; i < Length; i++)
//   {
//     array[i] = random.Next(100, 1000);
//   }
//   return array;
// }

// int FindEven(int[] array)
// {
//   int EvenCount = 0; 
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] % 2 == 0)
//     {
//       EvenCount++;
//     }
//   }
//   return EvenCount;
// }

// void PrintArrayAndCount(int[] array, int EvenCount)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.Write("] -> ");
//   Console.WriteLine(EvenCount);
// }

// int length = Prompt("Length of massive ");
// int[] array = GenerateArray(length);
// int evenAmount = FindEven(array);
// PrintArrayAndCount(array, evenAmount);





// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

// Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }

// int[] GenerateArray(int Length)
// {
//   int[] array = new int[Length];
//   Random random = new Random();
//   for (int i = 0; i < Length; i++)
//   {
//     array[i] = random.Next(-500, 500); // Решил, что это будет оптимальным на данный момент, так как задача не обозначает конкретные рамки, а делать бесконечность не умею.
//   }
//   return array;
// }

// int FindOddCountsSum(int[] array)
// {
//   int OddSum = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (i % 2 == 0) // Я решил, что нечётная позиция - это чётный индекс, так как в жизни отчёт вещей начинается с 1.
//     {
//       OddSum = OddSum + array[i];
//     }
//   }
//   return OddSum;
// }

// void PrintArrayAndSum(int[] array, int OddSum)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.Write("] -> ");
//   Console.WriteLine(OddSum);
// }
// int length = Prompt("Length of massive "); // Длину массива можно будет выбирать пользователю.
// int[] array = GenerateArray(length);
// int oddCountsum = FindOddCountsSum(array);
// FindOddCountsSum(array);
// PrintArrayAndSum(array, oddCountsum);




// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }



// double[] GenerateArray(int Length)
// {
//   double[] array = new double[Length];
//   Random random = new Random();
//   for (int i = 0; i < Length; i++)
//   {
//     array[i] = random.Next(-500, 500); // Решил, что это будет оптимальным на данный момент, так как задача не обозначает конкретные рамки, а делать бесконечность не умею.
//   }
//   return array;
// }

// double MaxMinDiff(double[] array)
// {
//    double max = array[0];
//     double min = array[0];
//   for (int i = 0; i < array.Length; i++)
//   {
   
//     if (array[i] > max)
//     {
//       max = array[i];
//     }
//     else if (array[i] < min)
//     {
//       min = array[i];
//     }
//   }
//   double dif = max - min; // оставляю именно так, так как разница в данном случае, это разница между значениями, которая как раз будет исчисляться как по модулю
//   return dif;
// }


// void PrintArrayAndSum(double[] array, double dif)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.Write("] -> ");
//   Console.WriteLine(dif);
// }


// int length = Prompt("Write length ");
// double[] array = GenerateArray(length);
// double diff = MaxMinDiff(array);
// PrintArrayAndSum(array, diff);


