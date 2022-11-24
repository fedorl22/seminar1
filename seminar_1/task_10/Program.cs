// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98



int number = new Random().Next(100, 999);
int digit2 = number % 10;
int digit1 = number / 100;
int digit3 = number / 10;
Console.WriteLine($"Первая цифра = {digit1},первая и вторая = { digit3 }, третья цифра {digit2}");

Console.WriteLine(digit1*10+digit2);   
