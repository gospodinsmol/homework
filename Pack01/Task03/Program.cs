﻿// Даны три переменные.Изменить значение этих переменных так, что бы
//в а хранилосьб значение a+b,  в  b хранилась разность старых значений с-а, 
//а в с хранилсь сумма старых значений а + b + c.  Например а=0 b=2 c=5,
//тогда новые переменные будут равны а=2, b=5, c=7

int a = 0;
int b = 2;
int c = 5;
int tempB = c - a;
a = a + b;
c = a + c;
b = tempB;
Console.WriteLine($"a = {a}, b = {b}, c = {c}");
