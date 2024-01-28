﻿
{
    Console.WriteLine("***************" );
    Console.WriteLine( "Hello, World!" );
}
Console.WriteLine( "*********************Vars Const*******************" );
int i = 27; 
float b = 26f;
double _D = 34.554;     //первый символ должен быть буква или _
string str = "Aston";
char c;
c = 'B';
Console.WriteLine( i );
Console.WriteLine( b );
Console.WriteLine( _D );
Console.WriteLine( str );
Console.WriteLine( c );
c = 'g';
Console.WriteLine( c );
const int con = 4; //Нельзя изменять константы
// con = 5;
// Должна быть проинициализирована

Console.WriteLine( "*********************Literals*******************" );
//Логический литерал
Console.WriteLine( true ); //false
// целочисленный литерал
Console.WriteLine( 109 ); //десятичная форма
Console.WriteLine( 0b10001 ); //двоичная форма
Console.WriteLine(0xA1); //Шестнадцатиричная форма
//Вещественные литералы (c с плавающей точной
    // 3.14
    // 100.001
    // -0.38
    //экспоненциальная форма
Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
//Символьные литералы
Console.WriteLine('2');
Console.WriteLine('A');
Console.WriteLine('T');
    //управляющие последовательности
/*
'\n' - перевод строки
'\t' - табуляция
'\\' - слеш
*/
    //использование шестнадцатеричных кодов ASCII \x
Console.WriteLine('\x78');    // x
Console.WriteLine('\x5A');    // Z
    //применение кодов из таблицы символов Unicode \u
Console.WriteLine('\u0420');    // Р
Console.WriteLine('\u0421');    // С
//Строковые литералы
Console.WriteLine("Компания \"Рога и копыта\""); // \ - escape ситмвол
Console.WriteLine("Привет \nмир"); // управляющая последовательность в строке

Console.WriteLine( "*********************Types of data*******************" );

string name = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;
 
Console.WriteLine($"Имя: {name}");  // интерполяция
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

//Неявная типизация
var hello = "Hell to World";
// hello = 123;  не может быть после сменен тип. 

/*var a;     // этот код не работает
a = 20;*/
//var c=null;  этот код не работает

Console.WriteLine( "*********************Console I/O*******************" );

Console.Write( "Enter your name: " );
string? userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}");

Console.WriteLine( "********************* assignment *******************" );

int x, y, z;   //multiple assign
y = x = z = 34;
/*
 +=: присваивание после сложения. Присваивает левому операнду сумму левого и правого операндов: выражение A += B равнозначно выражению A = A + B

-=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов: A -= B эквивалентно A = A - B

*=: присваивание после умножения. Присваивает левому операнду произведение левого и правого операндов: A *= B эквивалентно A = A * B

/=: присваивание после деления. Присваивает левому операнду частное левого и правого операндов: A /= B эквивалентно A = A / B

%=: присваивание после деления по модулю. Присваивает левому операнду остаток от целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B

&=: присваивание после поразрядной конъюнкции. Присваивает левому операнду результат поразрядной конъюнкции его битового представления с битовым представлением правого операнда: A &= B эквивалентно A = A & B

|=: присваивание после поразрядной дизъюнкции. Присваивает левому операнду результат поразрядной дизъюнкции его битового представления с битовым представлением правого операнда: A |= B эквивалентно A = A | B

^=: присваивание после операции исключающего ИЛИ. Присваивает левому операнду результат операции исключающего ИЛИ его битового представления с битовым представлением правого операнда: A ^= B эквивалентно A = A ^ B

<<=: присваивание после сдвига разрядов влево. Присваивает левому операнду результат сдвига его битового представления влево на определенное количество разрядов, равное значению правого операнда: A <<= B эквивалентно A = A << B

>>=: присваивание после сдвига разрядов вправо. Присваивает левому операнду результат сдвига его битового представления вправо на определенное количество разрядов, равное значению правого операнда: A >>= B эквивалентно A = A >> B
 */
 
Console.WriteLine( "********************* Basic types conversion *******************" );

// byte a = 4;
// byte b = a + 70;  // ошибка, числу а типа Байт пытаемся присвоить тип инт. При сложении разных типов байт + инт на выходе получаем инт.
byte a = 4;     // 0000100
ushort м = a;   // 000000000000100 - расширение
ushort s = 4;
byte d = (byte) s;  // сужение, явное преобразование.