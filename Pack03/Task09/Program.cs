// Дан номер месяца, выведите пору года

string num = Console.ReadLine();

var timeOfYear = num switch
{
    "1" or "2" or "12" => "Winter",
    "3" or "4" or "5" => "Spring",
    "6" or "7" or "8" => "Summer",
    "9" or "10" or "11" => "Autumn",
    _ => throw new ArgumentOutOfRangeException() 
};
Console.WriteLine(timeOfYear);