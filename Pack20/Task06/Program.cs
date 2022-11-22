// Описать структуру, с именем TRAIN, содержащий следующие поля: 
// название пункта назначения; 
// номер поезда; 
// экспресс или нет.
// Создать массив структур, данные прочитать из файла Input.txt
// Реализовать  функции:
// вывод в файл Output.txt. информации о поездах, направляющихся в пункт, название которого введено с клавиатуры; 
// вывод в файл  Output.txt. всех поездов экспресс, направляющихся в заданный пункт назначения


const string path = @"/home/smol/homework/Pack20/Task06/Input.txt";
const string pathOfOutput = @"/home/smol/homework/Pack20/Task06/Output.txt";
var trainSchedule = GetTrainSchedule(File.ReadAllLines(path));
WriteToFileInformationByDestination(trainSchedule);
WriteToFileExpressTrain(trainSchedule);

void WriteToFileExpressTrain(Train[] schedule)
{
    foreach (var train in schedule)
    {
        if (train.IsExpress == true)
        {
            var temp = $"Поезд-экспресс направляется в {train.Destination}, имеет номер {train.TrainNumber}\n";
            File.AppendAllText(pathOfOutput, temp);
        }
    }
}
void WriteToFileInformationByDestination(Train[] schedule)
{
    Console.WriteLine("Введите название города");
    var destination = Console.ReadLine();
    foreach (var train in schedule)
    {
        if (train.Destination == destination)
        {
            var temp = $"Поезд направляющийся в {destination} имеет номер {train.TrainNumber}\n";
            File.AppendAllText(pathOfOutput, temp);
        }
    }
}

Train[] GetTrainSchedule(string[] arrayOfLines)
{
    var trainSchedule = new Train[arrayOfLines.Length];
    for (var item = 0; item < arrayOfLines.Length; item++)
    {
        var itemsFromLine = arrayOfLines[item].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        trainSchedule[item] = new Train(itemsFromLine[0], itemsFromLine[1], itemsFromLine[2]);
    }

    return trainSchedule;
}
class Train
{
    private string _destination;
    private string _trainNumber;
    private bool _isExpress;

    public Train(string destination, string trainNumber, string isExpress)
    {
        _destination = destination;
        _trainNumber = trainNumber;
        _isExpress = isExpress is "True" or "true" ? true : false;
    }

    public string Destination
    {
        get => _destination;
        set => _destination = value;
    }

    public bool IsExpress
    {
        get => _isExpress;
        set => _isExpress = value;
    }

    public string TrainNumber
    {
        get => _trainNumber;
        set => _trainNumber = value;
    }
}