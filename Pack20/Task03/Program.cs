// Задан текстовый файл, содержащий информацию о студентах в следующем виде :
// Фамилия пробел ГРУППА пробел НОМЕР ЗАЧЕТКИ пробел Оценка пробел Оценка пробел Оценка 
//Составить программу получения:
//    	среднего балла каждого студента
//    	общего среднего балла
//    	общего списка, состоящего из фамилии, номера группы, номера зачетки, среднего балла.
//    	списка отличников, состоящего из фамилии, номера группы, номера зачетки 
//    	списка имеющих неудовлетворительные  оценки, состоящего из фамилии, номера группы, номера зачетки
//    	Для проверки результатов информацию созданных списков вывести на экран.
//    Все  полученные списки записать  в текстовые файлы OutAll.txt, OutО.txt  и OutN.txt, упорядочив списки по группам, каждую группу по фамилиям  в алфавитном порядке (используя  свою  и стандартную процедуры сортировки)  и вывести на экран. 
//    Общий средний балл записать первой строкой в файл OutAll.txt.

const string path = @"/home/smol/homework/Pack20/Task03/ListOfStudents.txt";
const string catalogPath = @"/home/smol/homework/Pack20/Task03/";
PrintLists(path);
WriteInfoToFiles(GetListOfStudent(path));
void PrintLists(string filePath)
{
    var listStudents = GetListOfStudent(filePath);
    var students = SortListOfStudetns(listStudents);
    Console.WriteLine("Общий список:");
    PrintInfoAboutStudents(students);
    Console.WriteLine();
    Console.WriteLine("Cписок отличников (ср.бал>4,5):");
    PrintInfoAboutGreatStudents(students);
    Console.WriteLine();
    Console.WriteLine("Список студентов имеющих двойки");
    PrintStudentsWithBadMarks(students);
}

void WriteInfoToFiles(IEnumerable<Student> listOfStudents)
{
    var students = SortListOfStudetns(listOfStudents);
    var greatStudents = students
        .Where(item => item.AverageRating > 4.5)
        .Aggregate("", (current, student) => current + $"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}\n");
    var studentsWithBadMarks = students
        .Where(item => item.HaveBadMarks() == true)
        .Aggregate("", (current, student) => current + $"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}\n");
    var listAllStudents = students.Aggregate("", (current, student) => current + $"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}\n");
    File.WriteAllText(string.Concat(catalogPath, @"OutAll.txt"), $"Средний бал всех студентов - {GetAveragesMarksAllStudents(students)}\n");
    File.WriteAllText(string.Concat(catalogPath, @"OutO.txt"), greatStudents);
    File.WriteAllText(string.Concat(catalogPath, @"OutN.txt"), studentsWithBadMarks);
    File.AppendAllText(string.Concat(catalogPath, @"OutAll.txt"), listAllStudents);
}

IEnumerable<Student> SortListOfStudetns(IEnumerable<Student> students)
{
    return 
        from s in students 
        orderby s.Group, s.Name 
        select s;
}

double GetAveragesMarksAllStudents(IEnumerable<Student> students)
{
    return students.Sum(item => item.AverageRating) / students.Count();
}

void PrintInfoAboutStudents(IEnumerable<Student> students)
{
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}");
    }
}

void PrintInfoAboutGreatStudents(IEnumerable<Student> students)
{
    foreach (var student in students.Where(item => item.AverageRating > 4.5))
    {
        Console.WriteLine($"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}");
    }
}

void PrintStudentsWithBadMarks(IEnumerable<Student> students)
{
    foreach (var student in students.Where(item => item.HaveBadMarks() == true))
    {
        Console.WriteLine($"{student.Name} {student.Group} {student.RecordBook} {student.AverageRating}");
    }
}

IEnumerable<Student> GetListOfStudent(string pathToTheFile)
{
    var inputArray = File.ReadAllLines(pathToTheFile);
    var students = new Student[inputArray.Length];
    for (var item = 0; item < inputArray.Length; item++)
    {
        students[item] = new Student(inputArray[item]);
    }

    return students;
}

class Student
{
    private string name;
    private string group;
    private string recordBook;
    private int[] marks;
    
    public Student(string discription)
    {
        var arr = discription.Split(' ');
        name = arr[0];
        group = arr[1];
        recordBook = arr[2];
        marks = new int[] { int.Parse(arr[3]), int.Parse(arr[4]), int.Parse(arr[5]) };
    }

    public bool HaveBadMarks()
    {
        return marks.Any(item => item < 3);
    }
    public double AverageRating => marks.Sum()/(double)marks.Length;
    public string Name => name;
    public string Group => group;
    public string RecordBook => recordBook;
    public int[] Marks => marks;
}