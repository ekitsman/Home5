
// Д.з.1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i=0; i<size; i++) 
//         array[i]=new Random().Next(100,1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.WriteLine($"array[{i+1}] is {array[i]}");
//     }    
// }

// int Quantity (int[] array)
// {
//     int count=0;;
//     for(int i=0; i < array.Length; i+=2)
//     if( array[i] % 2 == 0) count ++;
//     return count;
// }

// Console.Write("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray (size);
// ShowArray(myArray); 

// int result = Quantity(myArray);
// Console.WriteLine ( $"Количество чётных чисел {result}");

// Д.з.2 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i=0; i<size; i++) 
//         array[i]=new Random().Next(minValue, maxValue+1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.Write($"{array[i]}"+" ");
//     }
// }

// int SumArray (int[] array) 
// {
//     int sum=0;
//     for(int i=1; i < array.Length; i+=2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }  

// Console.Write("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент:");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray (size, min, max);
// ShowArray(myArray); 
// int result = SumArray(myArray);
// Console.WriteLine ("Сумма нечетных элементов " + result);

// Д.з.3 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Nextdouble+int

// double[] CreateRandomArray(int size)
// {
//     double[] array = new double[size];
//     Random rand = new Random();
//     for(int i=0; i<array.Length; i++) 
//        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(),2) ;
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.WriteLine($"array[{i+1}] is {array[i]}");
//     }    
// }

// double Difference (double[] array)
// {   double result=0;
//     double max = array[0];
//     double min = array[0];

//     for(int i=0; i < array.Length; i++)
//        { 
//         if (array[i] > max) max=array[i];
//         if (array[i] < min) min=array[i];

//         result=max-min;
//        } 
//    return result;
// }

// Console.Write("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());

// double [] myArray = CreateRandomArray (size);
// ShowArray(myArray); 

// double result = Difference (myArray);
// Console.WriteLine ( $"Разница между максимальным и минимальным значениями {result}");