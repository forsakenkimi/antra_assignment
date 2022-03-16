// See https://aka.ms/new-console-template for more information


//1.String / long
//double
//int
//enum/ int
//decimal
//string
//decimal
//double
//long
//long
//int

//2.
//value type variable contain data; reference type contain memory address
//Each variable has its own data; different variables reference to the same object
//Operation on one value type will not affect another; Operation on one reference type can affect another
//store in stack memory; store in heap memory
//cant be null; acccept null value

//boxing is process of converting value type to refernce type
//unboxing is process of extract the value from reference type
//3.
//The term "unmanaged resource" is usually used to describe something not directly under the control of the garbage collector or something gc won't know how to clean up after if it's abandoned.
//For example, a connection to a database server, Window handles.

//Managed resources basically mean anything managed by the CLR 

//4
//The garbage collector manages the allocation and release of memory for an application.





//1.
/*Console.WriteLine("sbyte: 1, byte: 1, short: 2, ushort: 2, int: 4, uint: 4, long: 8, ulong: 8, float: 4, double: 8, decimal: 16");
Console.WriteLine("sbyte: -128 to +127 " + "byte: 0 to 255 " + "short: -32,768 to 32,767" + "ushort: 0 to 65,535" + " int: -2,147,483,648 to 2,147,483,647 " + "uint: 0 to 4,294,967,295" + "long: -9,223,372,036,854,775,808  to 9,223,372,036,854,775,807" + "ulong: 0 to 18,446,744,073,709,551,615" + "float: ±1.0e-45 to ±3.4e38" + "double: ±5e-324 to ±1.7e308" + "decimal: ±1.0 ×10e-28 to ±7.9e28");*/

//2
/*string enter = Console.ReadLine();
int centuries = Int16.Parse(enter);
int years = 100 * centuries;
int days = centuries * 36524;
int hours = centuries * 876576;
int minutes = centuries * 52594560;
long seconds = 3155673600 * centuries;
long milliseconds = 3155673600000 * centuries;
long microseconds = 3155673600000000 * centuries;
long nanoseconds = 3155673600000000000 * centuries;*/

//Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {milliseconds} microseconds = {nanoseconds} nanoseconds");

//Test your Knowledge

//*int a = 2;
//Console.WriteLine(a / 0);
//System.DivideByZeroException: 'Attempted to divide by zero.'

//double b = 1.0;
//Console.WriteLine(b / 0);
//infinite

//short c = 999999999999999;
//Console.WriteLine(c);
//cant pass compliler 

// y is assgined to x first then y = y + 1
// y = y + 1 gets excecuted first then assign the value to x 

//The break statement terminates the closest enclosing iteration statement 
//The continue statement starts a new iteration of the closest enclosing iteration statement
//The return statement terminates execution of the function 

//The initializer section
//The condition section
//The iterator section
//All the sections of the for statement are optional

// = assignment operator
// == Equality operator

//yes

// System.Collections.IEnumerable; System.Collections.Generic.IEnumerable<T> 

//Practice loops and operators
//1
//int num = 10;
//for (int i = 1; i <= num; i++)
//{
//    if (i % 5 == 0 && i % 3 == 0)
//    {
//        Console.WriteLine("buzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("buzz");
//    }

//};

//1
int max = 500; for (byte i = 0; i < max; i++) { Console.WriteLine(i); }
//infinite loop
//if (max > 255) {
//    break;
//}


//2
int level = 9;
for (int i = 0; i < level; i++)
{
    int white = (level - i) / 2;
    if (i % 2 != 0)
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write(new String(' ', white));
        Console.WriteLine(new String('*', i + 1));
    }

}

//3
int correctNumber = newRandom().Next(3) + 1;
bool flag = true;
while (flag)
{
    int guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber == correctNumber)
    {
        Console.WriteLine("congratulation");
        flag = true;
    }
    else if (guessedNumber < 1 || guessedNumber > 3)
    {
        Console.WriteLine("Invalid");
    }
    else if (guessedNumber > correctNumber && guessedNumber <= 3)
    {
        Console.WriteLine("high");
    }
    else
    {
        Console.WriteLine("low");
    }
};


//4
DateTime today = DateTime.Now;
Console.WriteLine(today);
DateTime bday = DateTime.Parse("1.1.2000");
Console.WriteLine(bday);
var age = (today - bday);
Console.WriteLine(age);



//5
DateTime currentDateTime = DateTime.Now;
int currentHour = currentDateTime.Hour;
int startMorningHour = 5;
int startAfternoonHour = 12;
int startEveningHour = 18;
int startNightHour = 23;
if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
{
    Console.WriteLine("Good morning");
};
if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
{
    Console.WriteLine("Good Afternoon");
};
if (startEveningHour <= currentHour && currentHour < startNightHour)
{
    Console.WriteLine("Good Evening");
};
if (startNightHour <= currentHour || currentHour < startMorningHour)
{
    Console.WriteLine("Good Night");
};

//6
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j <= 24; j = j + i)
    {
        Console.Write(j + " ");
        j++;
    }
    Console.WriteLine(' ');
}



