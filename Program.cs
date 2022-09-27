
// program to print hello world
Console.WriteLine("Hello, World!");

// program for an empty line
Console.WriteLine("  ");

//program for declaring a string
string aname = "Abhishek";
Console.WriteLine(aname);

// empty line
Console.WriteLine("  ");

//program for string printing with some other details
Console.WriteLine("Hello friends, My name is " + aname);

// empty line
Console.WriteLine("  ");

// program to merge string with the another string
string bname = "Mandhare";
string cname = aname + " " + bname;
Console.WriteLine(cname);

// empty line
Console.WriteLine("  ");

// program for string manipulation using $
Console.WriteLine($"hello {cname}");

// empty line
Console.WriteLine("  ");

// program for finding length of the string
Console.WriteLine($"The name {aname} has {aname.Length} letters.");
Console.WriteLine($"The name {cname} has {cname.Length} letters.");

// empty line
Console.WriteLine("  ");

// program for using trim, trimstart and trimend
string greeting = "      Hello World!       ";
Console.WriteLine(greeting);
Console.WriteLine($"[{greeting}]");
// here we have used [] for showing from where the string is starting and ending 

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
// this will trim the starting spaces of the string 

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
// this will trim the ending spaces of the string

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
// this will trim the starting and ending spaces both from the string

// empty line
Console.WriteLine("  ");

// program for string replacement
string sayHello = "Hello Friends!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Hii");

Console.WriteLine(sayHello);

// empty line
Console.WriteLine("  ");

// program for using toUpper and toLower
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// empty line
Console.WriteLine("  ");

// program for find text in the string
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
// this will generate True as a output

Console.WriteLine(songLyrics.Contains("greetings"));
// this will generate False as a output

// empty line
Console.WriteLine("  ");

// program for use of startswith and endswith methods for searching inside string
string songLyrics2 = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics2.StartsWith("You")); //true
Console.WriteLine(songLyrics2.StartsWith("goodbye")); //false

Console.WriteLine(songLyrics2.EndsWith("hello")); // true
Console.WriteLine(songLyrics2.EndsWith("goodbye")); //false

// empty line
Console.WriteLine("  ");

// program for exploring integer math
int aint = 18;
int bint = 6;
int cint = aint + bint; // addition
Console.WriteLine($"The addition of {aint} and {bint} is {cint}");

int dint = aint - bint; // subtraction
Console.WriteLine($"The subtraction of {aint} and {bint} is {dint}");

int eint = aint * bint; // multiplication
Console.WriteLine($"The multiplication of {aint} and {bint} is {eint}");

int fint = aint / bint; // division
Console.WriteLine($"The Division of {aint} and {bint} is {fint}");

// empty line
Console.WriteLine("  ");

// it follows the BODMAS rule for calculation 
int gint = (aint + bint) - 6 * cint + (12 * 4) / 3 + 12;
Console.WriteLine(gint);

// empty line
Console.WriteLine("  ");

// program for exploring integer precision and limit
int a1 = 7;
int b1 = 4;
int c1 = 3;
int d1 = (a1 + b1) / c1;
int e1 = (a1 + b1) % c1;
Console.WriteLine($"quotient for 11 / 3 : {d1}");
Console.WriteLine($"remainder for 11 / 3 : {e1}");

// empty line
Console.WriteLine("  ");

// program for printing max and min values of integer
int maxint = int.MaxValue;
int minint = int.MinValue;
Console.WriteLine($"The range of integers is {minint} to {maxint}");

// empty line
Console.WriteLine("  ");

// program for integer overflow
int whatint = maxint + 3;
Console.WriteLine($"An example of overflow: {whatint}");
// if we add something in max value of integer, It starts again from the min value

// empty line
Console.WriteLine("  ");

// program for work with the double type 
double adouble = 5;
double bdouble = 4;
double cdouble = 2;
double ddouble = (adouble + bdouble) / cdouble;
Console.WriteLine(ddouble);// it will generate the answer with decimal values

// empty line
Console.WriteLine("  ");

// program for printing max and min values of double
double maxdouble = double.MaxValue;
double mindouble = double.MinValue;
Console.WriteLine($"The range of double is {mindouble} to {maxdouble}");

// empty line
Console.WriteLine("  ");

// program for work with decimal type
double a2 = 1.0;
double b2 = 3.0;
Console.WriteLine("answer for double data type "+a2 / b2);

decimal c2 = 1.0M; 
// M is for compiler that it is a decimal type not a double type
decimal d2 = 3.0M;
Console.WriteLine("answer for decimal data type " + c2 / d2);


// empty line
Console.WriteLine("  ");

// program for printing max and min values of decimal
decimal mindecimal = decimal.MinValue;
decimal maxdecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {mindecimal} to {maxdecimal}");

// empty line
Console.WriteLine("  ");

// program for printing max and min values of long
decimal minlong = long.MinValue;
decimal maxlong = long.MaxValue;
Console.WriteLine($"The range of the long type is {minlong} to {maxlong}");

// empty line
Console.WriteLine("  ");

// program for printing max and min values of short
decimal minshort = short.MinValue;
decimal maxshort = short.MaxValue;
Console.WriteLine($"The range of the short type is {minshort} to {maxshort}");

// empty line
Console.WriteLine("  ");

// program for getting the area of a circle
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

// empty line
Console.WriteLine("  ");

// program for performing if, else if & else statement
int a3 = 5;
int b3 = 6;
if (a3 + b3 > 10)
    Console.WriteLine("The answer is greater than 10.");
else if (a3 + b3 <10)
    Console.WriteLine("The answer is lesser than 10.");
else
    Console.WriteLine("The answer is equal to 10.");
//
int a31 = 1;
int b31 = 6;
if (a31 + b31 > 10)
    Console.WriteLine("The answer is greater than 10.");
else if (a31 + b31 < 10)
    Console.WriteLine("The answer is lesser than 10.");
else
    Console.WriteLine("The answer is equal to 10.");
//
int a32 = 5;
int b32 = 5;
if (a32 + b32 > 10)
    Console.WriteLine("The answer is greater than 10.");
else if (a32 + b32 < 10)
    Console.WriteLine("The answer is lesser than 10.");
else
    Console.WriteLine("The answer is equal to 10.");

// empty line
Console.WriteLine("  ");

// program for logical operators ( and, or and not )

int aand = 5;
int band = 3;
int cand = 4;
if ((aand + band + cand > 10) && (aand == band))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

// empty line
Console.WriteLine("  ");

int aor = 5;
int bor = 3;
int cor = 4;
if ((aor + bor + cor > 10) || (aor == bor))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

// empty line
Console.WriteLine("  ");

// program for performing while loop
int counter1 = 0;
while (counter1 < 10)
{
    Console.WriteLine($"Hello World! The counter in while loop is {counter1}");
    counter1++;
}

// empty line
Console.WriteLine("  ");

// program for performing do-while loop
int counter2 = 0;
do
{
    Console.WriteLine($"Hello World! The counter in do-while loop is {counter2}");
    counter2++;
} while (counter2 < 10);

// empty line
Console.WriteLine("  ");

// program for performing for-loop
for (int counter3 = 0; counter3 < 10; counter3++)
{
    Console.WriteLine($"Hello World! The counter in for-loop is {counter3}");

}

// empty line
Console.WriteLine("  ");

// program for performing nested loop

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

// empty line
Console.WriteLine("  ");

// program for combined statement and loop
//program to find the sum of all integers 1 through 20 that are divisible by 3
int sum1 = 0;
for (int number1 = 1; number1 <= 20; number1++)
{
    if (number1 % 3 == 0)
    {
        sum1 = sum1 + number1;
    }
}
Console.WriteLine($"The sum is {sum1}");

// empty line
Console.WriteLine("  ");

// program for declaring list
var names1 = new List<string> { "Abhishek", "luckey" };
foreach (var name in names1)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// empty line
Console.WriteLine("  ");

// program to perform adding and removing elements on list
Console.WriteLine();
names1.Add("Manoj");
names1.Add("Suresh");
names1.Remove("luckey");
names1.Add("Ramesh");
names1.Add("Gagan");
foreach (var name in names1)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// empty line
Console.WriteLine("  ");

// program for finding length of total elements in the list
Console.WriteLine($"The list has {names1.Count} people in it");

// empty line
Console.WriteLine("  ");

// program for getting the elements by giving index value in list
Console.WriteLine($"My name is {names1[0]}.");
Console.WriteLine($"I've added {names1[2]} and {names1[3]} to the list.");

// empty line
Console.WriteLine("  ");

// program to searching inside a list
var index1 = names1.IndexOf("Gagan");
if (index1 != -1)
    Console.WriteLine($"The name {names1[index1]} is at index {index1}");
else
    //var notFound1 = names1.IndexOf("Not Found");
    Console.WriteLine("item is not foundX");
//
var index2 = names1.IndexOf("Luckey");
if (index2 != -1)
    Console.WriteLine($"The name {names1[index2]} is at index {index2}");
else
    //var notFound2 = names1.IndexOf("Not Found");
    Console.WriteLine("item is not found");

// empty line
Console.WriteLine("  ");

// program to sort a list
names1.Sort();
foreach (var name in names1)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// empty line
Console.WriteLine("  ");

// program for declaring list for numbers
var fibonacciNumbers1 = new List<int> { 1, 1 };

var previous3 = fibonacciNumbers1[fibonacciNumbers1.Count - 1];
var previous4 = fibonacciNumbers1[fibonacciNumbers1.Count - 2];

fibonacciNumbers1.Add(previous3 + previous4);

foreach (var item in fibonacciNumbers1)
    Console.WriteLine(item);

// empty line
Console.WriteLine("  ");

// program to generate the first 20 numbers in the sequence of fibonacci series
var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);





























