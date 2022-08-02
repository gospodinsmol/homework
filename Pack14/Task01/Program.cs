//Реализовать 4 функции на простейшие арифметические операции (+,-,*,/).
//Каждая функция должна принимать два вещественных числа
//и возвращать результат операции в виде вещественного числа.
//Напишите функцию, которая принимает указатель на функцию в качестве параметра.
//Добавьте меню, в котором пользователь может выбрать желаемую операцию.
//Меню реализовать двумя способами.
void Menu() //2й вариант меню через рекурсию и ifы, реализовал в следующей задаче
{
    Console.WriteLine("Введите число а");
    var a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число b");
    var b = int.Parse(Console.ReadLine());
    void Result(int res) => Console.WriteLine($"Результат операции: {res}");
    while (true)
    {
        Console.WriteLine("Выберите пункт меню:");
        Console.WriteLine("'1' - а + b");
        Console.WriteLine("'2' - a - b");
        Console.WriteLine("'3' - a * b");
        Console.WriteLine("'4' - a / b");

        switch (Console.ReadLine())
        {
            case "1":
                Result(Addition(a, b));
                break;
            case "2":
                Result(Subraction(a, b));
                break;
            case "3":
                Result(Multiplication(a, b));
                break;
            case "4":
                Result(Division(a, b));
                break;
            default:
                Console.WriteLine("Пожалуйста, вводите действительный пункт меню");
                break;
        }
    }
}

int Addition(int value1, int value2) => value1 + value2;

int Subraction(int value1, int value2) => value1 - value2;

int Multiplication(int value1, int value2) => value1 * value2;

int Division(int value1, int value2) => value1 / value2;

Menu();