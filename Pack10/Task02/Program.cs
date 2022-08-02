// Написать программу «успеваемость». Пользователь вводит 10 оценок студента.
// Реализовать меню для пользователя
// Вывод оценок (вывод содержимого массива)
// Пересдача экзамена (пользователь вводит номер элемента массива и новую оценку)
// Выходит ли стипендия (стипендия выходит, если средний бал не ниже 7.7) 



Console.WriteLine("Введите 10 оценок студента:");
int[] rating = new int[10];
for (int i = 0; i < rating.Length; i++)
{
    rating[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Выберите и введите номер меню:");
Console.WriteLine("1 - Вывод оценок студента");
Console.WriteLine("2 - Пересдача экзамена");
Console.WriteLine("3 - Выходит ли стипендия");
Console.WriteLine("Для выхода введите любой другой символ");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.Write("Оценки студента: ");
        foreach (int i in rating)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        break;
    case "2":
        Console.WriteLine("Введите номер экзамена для пересдачи");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите оценку");
        int rate = int.Parse(Console.ReadLine());
        rating[num - 1] = rate;
        Console.WriteLine($"Теперь экзамен №{num} имеет оценку {rate}");
        Console.Write("Оценки студента: ");
        foreach (int i in rating)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        break;
    case "3":

        int sum = 0;
        foreach (int i in rating)
        {
            sum += i;
        }

        double average = sum / (double)rating.Length;
        Console.WriteLine($"Средний бал студента: {average}");
        string result = average >= 7.7 ? "Студент получит стипендию" : "Студент не получит стипендию";
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("Вы вышли из меню");
        break;
}