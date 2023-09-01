// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int endNum = 1;

// Console.WriteLine(PrintNumbers(num, endNum));
// string PrintNumbers(int start, int end)
// {
//     if(start==end)
//     {
//         return end.ToString();
//     }
//     return start+ " "+PrintNumbers(start-1, end);
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите начальное число промежутка");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конечное число промежутка");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (num1 < num2)
// {
//     Console.WriteLine(PrintNumbers(num1, num2));
// }
// else
// {
//     Console.WriteLine("Ввод не корректный");
// }

// int PrintNumbers(int num1, int num2)
// {
//     if(num1==num2)
//     {
//         return num2;
//     }
//     return sum+=num1 + PrintNumbers(num1+1, num2);
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Ack(num1, num2));

int Ack(int num1, int num2)
{
    if (num1==0)
    {
        return num2+1;
    }
    if (num2==0)
    {
        return Ack(num1-1, 1);
    }
    return Ack(num1-1, Ack(num1, num2-1));
}