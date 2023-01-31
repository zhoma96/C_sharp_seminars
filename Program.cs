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

// int[] ReverseArray(int[] array)
// {
//     int[] resArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         resArray[array.Length - i - 1] = array[i];
//     }
//     return resArray;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Console.Write("Enter side 1: ");
// int.TryParse(Console.ReadLine(), out int side1);

// Console.Write("Enter side 2: ");
// int.TryParse(Console.ReadLine(), out int side2);

// Console.Write("Enter side 3: ");
// int.TryParse(Console.ReadLine(), out int side3);

// void CheckSides(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Yes");
//     else Console.WriteLine("No");
// }

// CheckSides(side1, side2, side3);



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// System.Console.Write("Введите десятичное число: ");
// int num = getVar();
// int tmpNum = num;
// int count = 0;

// while (tmpNum > 0) {   
//     count++;
//     tmpNum /= 2;
// }

// tmpNum = num;
// int[] arrNum = new int[count];
// for (int i = arrNum.Length; i > 0; i--) {
//     arrNum[i-1] = tmpNum % 2;
//     tmpNum /= 2;
// }

// printArr(num, arrNum);

// // --- FUNCs --- //
// int getVar(){
//     int varValue = 0;
//     bool isNumeric = false;

//     while (!isNumeric) {
//         Console.Write($"Введите проверяемое число: ");
//         isNumeric = int.TryParse(Console.ReadLine(), out varValue);
//         varValue = Math.Abs(varValue);
        
//         if (varValue < 0) {
//             isNumeric = false;
//         }
//     }

//     return varValue;
// }

// void printArr(int num, int[] nums){
//     System.Console.Write($"{num} -> {String.Join("", nums)}\n");
// }

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8





// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.
