// Написать функцию, которая вычисляет длину строки, проиллюстрировать примером ее работу.


int LenthString(string str)
{
    //думаю так нельзя тут:
    //int lenthString = str.Length; 
    int lenthString = 0;
    foreach (var item in str)
    {
        lenthString++;
    }

    return lenthString;
}

//Example

string strTemp = "Рататататата";
Console.WriteLine(LenthString(strTemp));