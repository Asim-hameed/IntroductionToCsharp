// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter first Name: ");
//string fname= Console.ReadLine();
//Console.WriteLine("Enter Last Name: ");
//string lname= Console.ReadLine(); 
//Console.WriteLine("Your name is "+fname+" "+lname);  // String concatenation
//Console.WriteLine("Your name is {0} {1}",fname,lname);   //placeholder syntax

////Integer
//Console.WriteLine("Enter first number: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//int num2 = int.Parse(Console.ReadLine());
//int sum = num1 + num2;
//Console.WriteLine("Your sum is "+sum);

//Data types

//Console.WriteLine(int.MaxValue);
//Console.WriteLine(int.MinValue);
//Console.WriteLine(float.MaxValue);
//Console.WriteLine(float.MinValue);

//float a = 23.365f;
//double b = 567.2432d;
//decimal c = 123456789.123456789m;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);

// For putting quotes in console of strings (Escape sequences)

//string a = "\"WELCOME TO Csharp\"";
//string x = @"D:\Asim\Tutorials\Csharp";  //Verbatim literal (@) -More Readable

//Console.WriteLine(x);


// implicit and explicit conversion

//float a = 20.423f;
//int b = (int)a;

//string c = "50";
//string d = "60";
//Console.WriteLine(sum);
//int sum = Convert.ToInt32(c)+Convert.ToInt32(d);

// int.Parse(c) - string to int
// int c = (int)a; 
// int c = Convert.ToInt32(a)

//Constants

//const double pi = 3.14d;
//Console.WriteLine("Pi: "+pi);


//string x = Console.ReadLine();
//string y = Console.ReadLine();
//if (x == "Asim" && y== "Asim")
//{
//    Console.WriteLine("You are logged in");
//}
//else
//{
//    Console.WriteLine("Enter valid credentials");
//}

using IntroductionToCsharp;
///
int i = 0;
do
{
    if(i == 5)
    {
        goto stop;
    }
    Console.WriteLine( i );
    i++;
} while (i<10);

Console.WriteLine( "Loop terminates" );

stop:
Console.WriteLine("Program exits");

var obj = new Constants();
obj.


Console.ReadLine();
