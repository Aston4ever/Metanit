
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

Console.WriteLine( "*********************Literals*******************" );