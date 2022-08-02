//Пользователь вводит число. Выведите на экран квадрат и куб этого числа

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат числа: {number * number}"); //либо есть метод Math.Pow() - возведение в степень
Console.WriteLine($"Число в кубе: {number * number * number}");