using System.IO;
/*
const double pi = 3.14; // флаг const - неизменяемое значение
int n; //объявление без инициализации
int x = 1; //объявление с инициализацией

// Целые числа
byte a = 1; // от 0 до 255  1 Byte
short b = 1; // от -32768 до 32767 int16 2 Byte
int c = 1; // от -2,1В до 2,1В 4 Byte
long l = 1; // 8 Byte еще больше чем int

// Вещественные числа
float f = 1.6f; // 4 Byte
double d = 1.6; // 8 Byte по умолчанию все double
decimal e = 1.6m; // 16 Byte

char H = 'A'; // Символ
string J = "ABC"; // Строка
bool G = true; // true/false

var N = 2.55; // var автоматически определяет тип переменной 
*/

/////////////////////////////////////////////////////////////////////////////////

/*
// {0} подставляет первую указанную переменную
string name = "Pavel";
Console.WriteLine("My name is " + name);
Console.WriteLine("My name is {0} " , name);
*/

// Преобразование типов

/*
//1
int y = 200;
byte x = (byte)y; // 

//Строку в число
string s = "5";
int n = Convert.ToInt32(s);
int q = int.Parse(s);

// Число в строку
string i = q.ToString();
*/

/////////////////////////////////////////////////////////////////////////////////

/*
// Арифметические операторы

int a = 5;
int b = 3;

int c = a + b; // Оператор сложения
int d = a * b; // Оператор умножения
double e = (double)a / b; // Оператор деления
double f = 5 % 2; // Оператор деления по модулю, возвращает остаток от деления

a++; // Инкремент
b--; // Декримент
int q = 1; // 
int z = ++q; // Сначала увеличивает потом инициализирует
int l = q++; // Сначала инициализирует потом  увеличивает 
*/

/////////////////////////////////////////////////////////////////////////////////

// Операторы сравнения

/*
int a = 5;
int b = 6;
string res = null;

if (a == b) // Равно
    res = "Equal";
    

if (b != a) // Не равно 
    res = "Not equal";

if (a > b) // Больше
    res = "A more then B";

if (a < b) // Меньше 
    res = "A lower then B";

if (a >= b) // Больше либо равно
    res = "A more or equal then B";

if (a <= b) // Меньше либо равно 
    res = "A lower or equal then B";

bool x = false;
if (x) // x == true
    x = true;
*/

/////////////////////////////////////////////////////////////////////////////////

// Операторы присваивания
// a = a + i     ==     a += i
// a = a - i     ==     a -= i
// a = a * i     ==     a *= i
// a = a / i     ==     a /= i

/////////////////////////////////////////////////////////////////////////////////

// Логические операторы

//  && - and - проверяет выполнение первого условия, если false то остановит, затем второго и тогда уже идет дальше
//  & - and -  проверяет выполнение первого условия, если false то идет дальше, затем второго и тогда уже идет дальше
//  || - or или - проверяет выполнение первого или второго
//  ^ - or или - Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false

// a == 6 && b == 7   или a == 6 || b ==7 
// В данном случае если левая часть выражения false, то правая часть проверяться не будет.

// a == 6 & b ==7  или a == 6 | b ==7 
// В данном случае если левая часть выражения false, то правая часть проверяться  будет.

/////////////////////////////////////////////////////////////////////////////////

// Комментарии в Region

#region Comments
// sdsd
//sdsd
/* 
 sdsa
 asdas
  */
#endregion

/////////////////////////////////////////////////////////////////////////////////

// Классы
/*
var calc = new Calculator(); // создали новый экземпляр класса калькулятор
calc.X = 5;
calc.Y = 2;
Calculator.MultiplyPrint(6, 5);

public class Calculator  // public - чтобы можно было к нему обращаться
{
    public int X { get; set; }
    public int Y { get; set; }

    public static void MultiplyPrint(int a, int b) // static - ссылает экземпляр класса на единый метод а не индивидульный
    {
        Console.WriteLine(a*b);
    }

}
*/

/////////////////////////////////////////////////////////////////////////////////

// Структура
/*
public struct Point 
{
    public int X; 
    public int Y;
    public void Draw() 
    {
        Console.WriteLine(X + "; " + Y);
    }
}
*/

/////////////////////////////////////////////////////////////////////////////////


// Массивы
// тип_переменной[] название массива;
//int[] numberss; // массив целых чисел
// После определения переменной массива мы можем присвоить ей определенное значение:

//int[] nums = new int[4];
/* 
 * Здесь вначале мы объявили массив nums, который будет хранить данные типа int. 
 * Далее используя операцию new, мы выделили память для 4 элементов массива: new int[4]. 
 * Число 4 еще называется длиной массива. При таком определении все элементы получают значение по умолчанию, 
 * которое предусмотренно для их типа. Для типа int значение по умолчанию - 0.
 * Также мы сразу можем указать значения для этих элементов:
*/
//int[] nums2 = new int[4] { 1, 2, 3, 5 };

//int[] nums3 = new int[] { 1, 2, 3, 5 };

//int[] nums4 = new[] { 1, 2, 3, 5 };

//int[] nums5 = { 1, 2, 3, 5 };

//
//int[] numbers = { 1, 2, 3, 5 };

// получение элемента массива
//Console.WriteLine(numbers[3]);  // 5

// получение элемента массива в переменную
//var n = numbers[1];     // 2
//Console.WriteLine(n);  // 2

// Также мы можем изменить элемент массива по индексу:
//int[] numbers2 = { 1, 2, 3, 5 };

// изменим второй элемент массива
//numbers2[1] = 505;

//Console.WriteLine(numbers2[1]);  // 505

//Console.WriteLine(numbers.Length);  // 4 - поиск длины массива

//Console.WriteLine(numbers[numbers.Length - 1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[numbers.Length - 2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[numbers.Length - 3]);  // 2 - третий элемент с конца

/*
 * Однако при подобном подходе выражения типа numbers.Length - 1, 
 * смысл которых состоит в том, чтобы получить какой-то определенный элемент с конца массива, утяжеляют код. 
 * И, начиная, с версии C# 8.0 в язык был добавлен специальный оператор ^, с помощью которого можно задать индекс относительно конца коллекции.
    Перепишем предыдущий пример, применяя оператор ^:
*/

//Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца




// List - Списки



// Работа со строками
/*
using System.Text;

string name = "Pavel";
string surname = "Kolesnikov";

// Конкатенация
string fullName = name + " " + surname;
string myFullName = string.Format("{0} {1}", name, surname);
string myFinalName = $"{name} {surname}";

// Сепаратор через метод Join
string[] array = { "C:", "Users", "DeadDoctor", "AppData" };
string list = string.Join("/", array);
Console.WriteLine("List: " + list);

// Строки это список символов
char initialName = name[0];
char initialSurname = surname[0];
Console.WriteLine($"{initialName}{initialSurname}");

// Перенос строки
string newLine = "Hello, \n my name is Pavel"; // \n - перенос на другую строку
string newLineEnvironment = "Hello" + Environment.NewLine + "my name is Pavel."; // то же самое только с помощью Environment.NewLine

// Табуляция
string tab = "Hello, \t \t my name is Paul";
Console.WriteLine(tab);

// Другое
string path = @"C:\Users\DeadDoctor\AppData\";

string whiteSpace = "     Pavel";
// Перевод в загловные
Console.WriteLine(name.ToUpper());

// Перевод в малые
Console.WriteLine(name.ToLower());

// Убрать white space
Console.WriteLine(whiteSpace);
Console.WriteLine(whiteSpace.Trim());

// Поиск индекса буквы
Console.WriteLine(surname.IndexOf('a')); // вернет индексм первой попавшейся 'a'

// substrings
var Moscow = "Москва большой город.";
var bigcity = Moscow.Substring(7); // Вернет все что начинается с индекса 7
Console.WriteLine(bigcity);
var bigcity2 = Moscow.Substring(7,7); // Вернет от индекса 7, 7 индексов
Console.WriteLine(bigcity2);
*/

/*
string x = null;
string y = "";
string h = "    ";

if (String.IsNullOrEmpty(x))
    Console.WriteLine("x");
if (String.IsNullOrWhiteSpace(h))
    Console.WriteLine("y");
*/

/*
// Split
var splitted = Moscow.Split(' '); // Разделение слов по символу
foreach(var i in splitted) 
{
    Console.WriteLine(i);
}

// Конвертация
string s = "1256";
int another = Convert.ToInt32(s); // если s равно нулю или пусто то вернет default 0
int number = int.Parse(s); // в случае если s ноль или пусто то выдает исключение
string back = another.ToString(); // внутри ToString(формат)
string formatString = another.ToString("C0"); // $12,345 где 0 = кол-во знаков после запятой
// форматы format strings
// C - currency, D - decimal, E - exponential, F - fixed point, X - Hexadecimal

// Замена символов в строке
string name3 = "Pavel";
string name4 = "Kolesnikov";

var myString = new StringBuilder();
myString.Append(name4);
myString.Replace('K', 'P');
Console.WriteLine(myString);
*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Циклы

/*
// if else
// Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.
//  if (условие)
//  {
//      выполняемые инструкции
//  }

int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
// Если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки:
if (num1 > num2)
    Console.WriteLine($"Число {num1} больше числа {num2}");

// или так
if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");

// Но что, если мы захотим, чтобы при несоблюдении условия также выполнялись какие-либо действия? В этом случае мы можем добавить блок else:

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}

// Но в примере выше при сравнении чисел мы можем насчитать три состояния: первое число больше второго,
// первое число меньше второго и числа равны. Используя конструкцию else if, мы можем обрабатывать дополнительные условия:

string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Вас зовут Tomas");
else if (name == "Bob")
    Console.WriteLine("Вас зовут Robert");
else if (name == "Mike")
    Console.WriteLine("Вас зовут Michael");
else
    Console.WriteLine("Неизвестное имя");
*/

/*
Console.WriteLine("Введите номер операции: \n1.Сложение\n2.Вычитание\n3.Умножение");
string choice = Console.ReadLine();
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int result;
switch (choice) 
{
    case "1":
        result = x + y;
        Console.WriteLine(result);
        break;
    case "2":
        result = x - y;
        Console.WriteLine(result);
        break;
    case "3":
        result = x * y;
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("Неизвестно");
        break;
}
*/

// for


// Practice

// A1.8 - Дано целое число k (1 ≤ k ≤ 365).
// Присвоить целочисленной величине n значение 1, 2, …, 6 или 0 в зависимости от того,
// на какой день недели (понедельник, вторник, …, субботу или воскресенье) приходится k-й день года, в котором 1 января:
// а) понедельник;
// б) вторник;
// в) d - й день недели(если 1 января — понедельник, то d = 1, если вторник — d= 2, …, если воскресенье — d= 7).

// Получаю имя пользователя и конкатенирую с базовым путем
string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
userName = userName.Substring(userName.LastIndexOf('\\'));
string pathDirectory = @"C:\Users" + userName + @"\AppData\Local\Temp";

var testPath = Convert.ToString(Console.ReadLine()); ////////////////////////////////////////////////////////////////////////
// Получаем коллекцию имен файлов и каталогов по пути,признаку,подкаталогах
var directories = Directory.EnumerateFiles(testPath, "*",SearchOption.AllDirectories);
string[] extensions = {".log",".txt",".tmp",".json" };
string[] testextensions = {".tga", ".png", ".psd", ".spp", ".blend", ".zbr",".blend1",".ztl",".obj",".mtl",".max"}; /////////////////////////////////////////////////////////////////////////////////////

/* Другие варианты сортировки
 * foreach (var d in directories.Where(s => s.EndsWith(".txt") || s.EndsWith(".log") || s.EndsWith(".tmp") || s.EndsWith(".json")))
 * или 
 * string[] extensions = {".log",".txt",".tmp",".json" };
 * foreach (var d in directories.Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
 */

// Создаю новый список для отсортированных файлов
List<string> sortFilesPath = new List<string>();

// Циклом foreach перебираю пути к файлом с помощью фильтра и добавляю в список
foreach (var filePath in directories.Where(s => testextensions.Any(ext => ext == Path.GetExtension(s))))
{    
    sortFilesPath.Add(filePath);
}

// Создаю список для хранения размеров всех файлов
List<long> sizeList = new List<long>();
foreach (var length in sortFilesPath) 
{       
    long lengthFile = new System.IO.FileInfo(length).Length;        
    sizeList.Add(lengthFile);
}

var sizelist_count = sizeList.Count;
double sizeSum = sizeList.Sum();
if (sizeSum <= 1048576)
{
    sizeSum = sizeSum / 1048576;
    Console.WriteLine("Files: {1}\nAll size file: {0} Mb ", sizeSum, sizelist_count);
}
else if (sizeSum >= 1073741824)
{
    sizeSum = Math.Round((Convert.ToDouble(sizeSum) / 1073741824),2);
    Console.WriteLine("Files: {1}\nAll size file: {0} Gb ", sizeSum, sizelist_count);
}
else
{
    sizeSum = sizeSum / 1024;
    Console.WriteLine("Files: {1}\nAll size file: {0} Kb ", sizeSum, sizelist_count);
}




 