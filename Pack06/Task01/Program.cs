// С помощью вложенных циклов напечатать таблицы
int n = 5;
for (int i = 1; i < n + 1; i++)
{
    string str = "";
    for (int j = 1; j < i + 1; j++)
    {
        str += $"{i * 2 * n} ";
    }
    Console.Write(str.PadRight(25));
    
    str = "";
    for (int j = n; j > i - 1; j--)
    {                      
        str += $"{i * n} ";
    }
    Console.Write(str.PadRight(25));
    
    str = "";
    for (int j = 1; j < i + 1; j++)        
    {                                      
        str += $"{(i - j)} ";    
    }                                      
    Console.Write(str.PadRight(25));
    
    str = "";
    for (int j = n; j > i - 1; j--)      
    {                                    
        str += $"{j + 2 - i} ";      
    }   
    Console.Write(str.PadRight(25));
    
    Console.WriteLine();
}
                                               