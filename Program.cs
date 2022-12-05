// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

 Console.WriteLine("Введите пятизначное число");
 int number = Convert.ToInt32(Console.ReadLine());
 int a = number / 1000;
 int b = number % 10/10;{
 
 
if (a == b)
{
     Console.WriteLine("Данное число является палиндромом");
     
}
else
{
     Console.WriteLine("Это не палиндром");
}

 }
 
    
