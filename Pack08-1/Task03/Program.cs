// 3. Написать игру «Однорукий бандит». Игра должна имитировать работу игрового автомата
//с тремя барабанами, на которых расположены числа от 0 до 9.
// Пользователь делает ставку и запускает барабаны.
// Правила игры следующие:
// a. Ставка увеличивается на 130% если итоговое число будет вида 123, 234, 345, 456, ..
// b. Ставка увеличивается на 200% если итоговое число будет вида 111, 222, 333, 444, ..
// c. Джек-пот в размере депозит*100, если выпадает 777
// d. Пользователь проигрывает, если на барабанах выпало то, чего нет в пунктах 1 и 2
// e. Пользователь проигрывает, когда у него на счету нет больше денег.


Console.WriteLine("Вас приветствует игра 'Однорукий бандит'");
Console.WriteLine("Введите сумму на счет:");
double cash = Double.Parse(Console.ReadLine());

while (cash > 0)
{
    Console.WriteLine($"У Вас на счету {cash}$");
    Console.WriteLine("Введите размер ставки:");
    double bet = Double.Parse(Console.ReadLine());
    if (bet > 0 && bet <= cash)
    {
        Random rnd = new Random();
        var num1 = rnd.Next(0, 9);
        var num2 = rnd.Next(0, 9);
        var num3 = rnd.Next(0, 9);
        Console.WriteLine($"На барабанах выпали цифры: {num1} {num2} {num3}");
        if (num3 - num2 == 1 && num2 - num1 == 1)
        {
            Console.WriteLine($"Поздравляем, вы выйграли {Math.Round(bet * 1.3, 2)}");
            cash += Math.Round(bet * 1.3, 2);
        }
        else if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine($"Поздравляем, вы выйграли {bet * 2}");
            cash += bet * 2;
        }
        else if (num1 == 7 && num2 == 7 && num3 == 7)
        {
            Console.WriteLine($"Поздравляем! Джек-пот! Вы выйграли {cash * 100}");
            cash *= 101;
            Console.WriteLine($"У Вас на счете {cash}");
            break;
        }
        else
        {
            Console.WriteLine("Увы, Вы ничего не выиграли. Попробуйте еще раз!");
            cash -= bet;
        }
    }
    else
    {
        Console.WriteLine($"Введите корректную сумму от 0 до {cash}");
    }
}