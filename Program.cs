// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNumber(int N)
// {
//     if (N <= 0)
//     {
//         return;
//     }
//     else if (N == 1)
//     {
//         Console.Write($"{N}");
//     }
//     else
//     {
//         PrintNumber(N - 1);
//         Console.Write($", {N}");
//     }
// }

// int GetNumber()
// {
//     Console.Write($"Введите значение числа: ");
//     int.TryParse(Console.ReadLine(), out int result);
//     return result;
// }

// int num = GetNumber();
// PrintNumber(num);



// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// void PrintNumber(int M, int N)
// {
//     if (M > N)
//     {
//         PrintNumber(M - 1, N);
//         Console.Write($", {M}");
//     }
//     else if (M < N)
//     {
//         PrintNumber(M, N - 1);
//         Console.Write($", {N}");
//     }
//     else if (M == N)
//     {
//         Console.Write($"{M}");
//     }
// }

// int GetNumber()
// {
//     Console.Write($"Введите значение числа: ");
//     int.TryParse(Console.ReadLine(), out int result);
//     return result;
// }

// int M = GetNumber();
// int N = GetNumber();
// PrintNumber(M, N);

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumOFDigits(int num)
// {
//     if (num == 0) return 0;
//     else
//     {
//         return num % 10 + SumOFDigits(num / 10);
//     }
// }


// Console.Write("Enter number: ");
// int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine();
// int res = SumOFDigits(n);
// Console.WriteLine($"Sum of digits {n} = {res}");


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int APowerB(int a, int b)
{
    if (b < 0) return 0
    {
        return Math.Abs(b) / a
    }
    else if (b == 0) return 1;
    else if (b == 1) return a;
    else
    {
        return a * APowerB(a, b - 1);
    }
}

Console.Write("Enter A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = APowerB(A, B);
Console.WriteLine(res);


// double PowNumbers(double numA, double numB)
// {
//     if (numB == 1)
//     {
//         return numA;
//     }
//     else if (numB == 0)
//     {
//         return 1;
//     }
//     else if (numB < 0)
//     {
//         return 1 / PowNumbers(numA, Math.Abs(numB));
//     }
//     else
//     {
//         return numA * PowNumbers(numA, numB - 1);
//     }
// }

// double GetNumber()
// {
//     Console.Write($"Введите значение числа: ");
//     double.TryParse(Console.ReadLine(), out double result);
//     return result;
// }

// double numberA = GetNumber();
// double numberB = GetNumber();
//     Console.WriteLine($"Число {numberA} в степени {numberB} = {PowNumbers(numberA, numberB)}");