// Имеется N черных и белых карточек, сложенных в стопку.
// Карточки раскладываются на столе в одну линию следующим образом: первая кладется на стол,
// вторая — вниз стопки, третья — на стол, четвертая — вниз стопки и т. д.,
// пока все карточки не будут выложены на стол.
// Напишите программу, которая определит, каким должно быть исходное расположение карточек в стопке,
// чтобы разложенные на столе карточки чередовались по цвету: белая, черная, белая, черная и т. д.


Console.WriteLine("Введите количество N черных и белых карточек");
var countN = int.Parse(Console.ReadLine());
const string cardBlack = "black";
const string cardWhite = "white";
var arrayOfCards = new List<string>();
for (var iteration = 0; iteration < countN; iteration++)
{
    arrayOfCards.Add(cardWhite);
    arrayOfCards.Add(cardBlack);
}
var arrayResult = new List<string>();
while (arrayOfCards.Count > 0)
{
    arrayResult.Add(arrayOfCards[0]);
    if (arrayOfCards.Count > 1)
    {
        arrayResult.Add(arrayOfCards[^1]);
        arrayOfCards.RemoveRange(arrayOfCards.Count - 1, 1);
    }
    arrayOfCards.RemoveRange(0, 1);
}
Console.WriteLine("Исходное положение карточек должно быть таким:");
foreach (var item in arrayResult)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
