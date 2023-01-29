// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// void PrintArray(int[] array)
// {
//     System.Console.Write($"[{String.Join(",", array)}]\n");
// }

// int[] GenerateArr(int n, int min, int max)
// {
//     int[] arrNum = new int[n];

//     Random rnd = new Random();

//     for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

//     return arrNum;
// }

// int SumPositiveElements(int[] array) {
//     int result = 0;

//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] > 0)
//             result += array[i];
//     }

//     return result;
// }

// int SumNegativeElements(int[] array) {
//     int result = 0;

//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] < 0)
//             result += array[i];
//     }

//     return result;
// }


// int[] array = GenerateArr(12, -9, 9);
// PrintArray


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] GenerateArr(int n, int min, int max)
// {
//     int[] arrNum = new int[n];

//     Random rnd = new Random();

//     for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

//     return arrNum;
// }

// int[] ReverseSign(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }
//     return arr;
// }

// void PrintArray(int[] array1)
// {
//     System.Console.Write($"[{String.Join(",", array1)}]\n");
// }

// int[] array = GenerateArr(20, -9, 9);
// PrintArray(array);
// int[] reversedArray = ReverseSign(array);
// PrintArray(reversedArray);

// -------------------------------------------------------------------------------------

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// int[] GenerateArr(int n, int min, int max)
// {
//     int[] arrNum = new int[n];

//     Random rnd = new Random();

//     for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

//     return arrNum;
// }

// void PrintArray(int[] array1)
// {
//     System.Console.Write($"[{String.Join(",", array1)}]\n");
// }

// void FindNumber(int num, int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num)
//         {
//             Console.WriteLine("Yes);
//         }
//     }
// }



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GenerateArr(int n, int min, int max)
// {
//     int[] arrNum = new int[n];

//     Random rnd = new Random();

//     for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

//     return arrNum;
// }

// void PrintArray(int[] array1)
// {
//     System.Console.Write($"[{String.Join(",", array1)}]\n");
// }

// int CountDiapozon(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] => 10 && arr[i] <= 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] Array = GenerateArr(12, 0, 1000);
// PrintArray(Array);
// int countDia = CountDiapozon(Array);
// Console.WriteLine($"Кол-во в диапозоне [10, 99] = {countDia}");


// ---------------------------------------------------------------------------------------

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

void PrintArray(int[] array1)
{
    System.Console.Write($"[{String.Join(",", array1)}]\n");
}

int[] MultiplyPairs(int[] arr, int count)
{
    int[] NewArray = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        NewArray[0]
    }
}


// int[] numsArr = generateArr(6, 1, 9);
// int outArrLength = numsArr.Length / 2 + numsArr.Length % 2;
// int[] outNumsArr = new int[outArrLength];

// printArr(numsArr);
// for (int i = 0; i < outArrLength; i++) {
//     int j = numsArr.Length-i-1;
//     if (i < outArrLength-1){
//        outNumsArr[i] = numsArr[i] * numsArr[j];
//     } else {
//        outNumsArr[i] = numsArr[i];
//     }
// }
// printArr(outNumsArr);
