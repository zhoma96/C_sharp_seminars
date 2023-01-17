// int number = new Random().Next(10, 100);
// Console.WriteLine(number);
// int firstNum = number / 10;
// int secondNum = number % 10;
// int max = 0;
// if (firstNum > secondNum) max = firstNum;
// else max = secondNum;
// Console.WriteLine("Greatest digit " + number + "=" + max);

// INT.TryPARSE

// if(int.TryParse(Console.ReadLine(), out int number))
//     Console.WriteLine("Прочитали число: " + number);
// else
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int firstDig = number / 100;
// int secondDig = (number / 10) % 10;
// int thirdDig = number % 10;
// int newNumber = firstDig * 10 + thirdDig;
// Console.WriteLine(newNumber);


// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является 
// ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
//  выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0) Console.WriteLine("кратно");
// else
// {
//     Console.WriteLine("не кратно, остаток " + number1 % number2);
//     // int ostatok = number1 % number2;
//     // Console.WriteLine("не кратно, остаток " + ostatok);
// }

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == 0 || number2 == 0) {
//     System.Console.WriteLine("Одно из чисел является нулём");
//     return;
// }


// int result = number1 % number2;

// if (result == 0)     
//     Console.WriteLine("кратно"); 
// else     
//     Console.WriteLine("не кратно, остаток " + result);



// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число для проверки на кратность 7 и 23: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (number1 == 0)
// {
//     Console.WriteLine("Вы ввели 0");
//     return;
// }

// if (number1 % 7 == 0 && number1 % 23 == 0)
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("Нет");

// 16. Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да


// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == 0 || number2 == 0) {
//     System.Console.WriteLine("Одно из чисел является нулём");
//     return;
// }

// if (number1 * number1 == number2 || number2 / number1 == number1) Console.WriteLine("Да");
// else Console.WriteLine("Нет");