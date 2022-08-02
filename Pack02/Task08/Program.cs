// Написать программу, которая по заданному количеству секунд,
//определяет количество часов, минут, секунд

Console.WriteLine("Введите целое число");
int num1 = int.Parse(Console.ReadLine());
int hours = num1 / 3600;
int minutes = (num1 - hours*3600)/60;
int seconds = num1 - hours*3600 - minutes*60;
Console.WriteLine($"{num1} секунд - это {hours} часов {minutes} минут и {seconds} секунд");