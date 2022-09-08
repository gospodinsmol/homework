/* Создать структуру данных студент с полями:
ФИО 
ГРУППА 
НОМЕР ЗАЧЕТКИ 
Массив оценок
В массиве структур имеется следующая информация о студентах:
Иванов 4  456345   5 3 10
Петров  4  456348   4 8 4
Иванова  5 456340   5 3 5
Петрова  5 456349   4 5 4
Составить программу получения:
    	среднего балла каждого студента
    	общего среднего балла
    	общего списка, состоящего из фамилии, номера группы, номера зачетки, среднего балла.
    	списка отличников, состоящего из фамилии, номера группы, номера зачетки 
    	списка имеющих неудовлетворительные  оценки, состоящего из фамилии, номера группы, номера зачетки
    	Для проверки результатов информацию созданных списков вывести на экран.*/


var students = new Student[4];
students[0] = new Student("Иванов", 4, 456345, 5, 3, 10);
students[1] = new Student("Петров", 4, 456348, 4, 8, 4);
students[2] = new Student("Иванова", 5, 456340, 5, 3, 5);
students[3] = new Student("Петрова", 5, 456349, 4, 5, 4);

Menu(students);

void Menu(Student[] students)
{
    var flag = true;
    while (flag)
    {
        Console.WriteLine("Введите номер пункта меню или введите 'exit' для выхода");
        Console.WriteLine("1 - Средний бал каждого студента");
        Console.WriteLine("2 - Общий средний бал");
        Console.WriteLine("3 - Общий список со средним баллом");
        Console.WriteLine("4 - Список отличников");
        Console.WriteLine("5 - Список студентов, имеющих плохие оценки");
        Console.WriteLine("exit - выход");
        var input = Console.ReadLine();
        Console.WriteLine();
        switch (input)
        {
            case "1": PrintAverageScoreEverybody(students);
                break;
            case "2": PrintAverageScoreOfAll(students);
                break;
            case "3": PrintListOfStudents(students);
                break;
            case "4": PrintListOfGoodStudents(students);
                break;
            case "5": PrintListWithBadGrade(students);
                break;
            case "exit": flag = false;
            break;
        }
        Console.WriteLine();
    }
}

void PrintAverageScoreEverybody(Student[] students)
{
    Console.WriteLine("Средние баллы всех студентов");
    foreach (var student in students)
    {
        Console.WriteLine($"Средний балл, студент(ка) {student.name}: {student.GetAverageScore()}");
    }
}

void PrintAverageScoreOfAll(Student[] students)
{
    var averageScore = students.Sum(student => student.GetAverageScore()) / students.Length;
    Console.WriteLine($"Средний бал всех студентов: {averageScore}");
}

void PrintListOfStudents(Student[] students)
{
    foreach (var student in students)
    {
        Console.WriteLine($"Студент: {student.name}, группа: {student.group}, зачетка: {student.recordBook}, ср.бал: {student.GetAverageScore()}");
    }
}

void PrintListOfGoodStudents(Student[] students)
{
    Console.WriteLine("Студенты отличники (со средним баллом выше 5)");
    foreach (var student in students)
    {
        if (student.GetAverageScore() > 5)
        {
            Console.WriteLine($"Студент {student.name}, группа {student.group}, зачетка №{student.recordBook}");
        }
    }
}

void PrintListWithBadGrade(Student[] students)
{
    Console.WriteLine("Студенты, имеющие плохие оценки");
    foreach (var student in students)
    {
        foreach (var grade in student.grades)
        {
            if (grade < 4)
            {
                Console.WriteLine($"Студент {student.name}, группа {student.group}, зачетка №{student.recordBook}");
            }
        }
    }
}

class Student //класс отдельным файлом наверное надо?
{
    public string name; // идеальным решением было бы еще через свойства реализовать но думаю для задачи достаточно
    public int group;
    public int recordBook;
    public int[] grades;

    public Student(string inputName, int inputGroup, int inputRecordBook, params int[] inputGrades)
    {
        name = inputName;
        group = inputGroup;
        recordBook = inputRecordBook;
        grades = inputGrades;
    }
    
    public double GetAverageScore()
    {
        return Convert.ToDouble(grades.Sum()) / grades.Length;
    }
}

