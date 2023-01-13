// Example 1
// Console.WriteLine("Enter number");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("Square num:" + num * num);


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Enter number 1:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number 2:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2 || num2 * num2 == num1)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }


// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Enter number of the week:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1)
// {
//     Console.WriteLine("Monday");
// }
// else if (num == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (num == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (num == 4)
// {
//     Console.WriteLine("Thursday");
// }
// else if (num == 5)
// {
//     Console.WriteLine("Friday");
// }
// else if (num == 6)
// {
//     Console.WriteLine("Saturday");
// }
// else if (num == 7)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("Wrong, enter numbers between 1 and 7");
// }

// Console.Write("Введите номер (от 1 до 7) дня недели:");
// int numDay = Convert.ToInt32( Console.ReadLine() ); // читаем из консоли номер недели

// switch (numDay)
// {
//    case 1:
//         Console.Write("Понедельник");
//         break;
//    case 2:
//         Console.Write("Вторник");
//         break;
//    case 3:
//         Console.Write("Среда");
//         break;
//    case 4:
//         Console.Write("Четверг");
//         break;
//    case 5:
//         Console.Write("Пятница");
//         break;
//    case 6:
//         Console.Write("Суббота");
//         break;
//    case 7:
//         Console.Write("Воскресенье");
//         break;

//     default:
//         Console.Write("Вы ввели не верный номер дня недели");
//         break;
// }


// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int number = Convert.ToInt32( Console.ReadLine() ); // читаем из консоли

if (number > 0)
    number *= -1; //number = number * (-1)

int endNumber = number * -1;

while (number <= endNumber) {
    Console.Write(number);

    if (number < endNumber)
        Console.Write(", ");
    
    number++;
}
