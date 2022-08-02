//Реализовать 3 функции, каждая из которых принимает вещественное число и возвращает вещественное число.
//Первая функция вычисляет квадратный корень числа, вторая – куб числа, третья – синус числа.
//Напишите функцию, которая принимает указатель на функцию в качестве параметра.
//Добавьте меню, в котором пользователь может выбрать желаемую операцию. Меню реализовать двумя способами.


void Menu()
{
    Console.WriteLine("Введите число для операции:");
    var num = Double.Parse(Console.ReadLine());
    Console.WriteLine("Выберите номер пункта меню:");
    Console.WriteLine("'1' - Квадратный корень числа");
    Console.WriteLine("'2' - Куб числа");
    Console.WriteLine("'3' - Синус числа");
    var choice = Console.ReadLine();
    var print = (double item) => Console.WriteLine($"Результат операции:{item} \n");
    if (choice == "1") print(SquareRoot(num));
    else if (choice == "2") print(Cube(num));
    else if (choice == "3") print(Sinus(num));
    else Console.WriteLine("Введите действительный номер меню");
    Menu();

}

double SquareRoot(double value)
{
    return Math.Sqrt(value);
}

double Cube(double value)
{
    return value * value * value;
}

double Sinus(double value)
{
    return Math.Sin(value);
}

Menu();