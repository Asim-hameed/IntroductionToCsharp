using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

//using IntroductionToCsharp;
/////
//int i = 0;
//do
//{
//    if(i == 5)
//    {
//        goto stop;
//    }
//    Console.WriteLine( i );
//    i++;
//} while (i<10);

//Console.WriteLine( "Loop terminates" );

//stop:
//Console.WriteLine("Program exits");

//int[,] array = new int[3,4]
//{
//    {1,2,3,4 },
//    {5,6,7,8 },
//    {9,10, 11, 12 } 
//};

//for(int i = 0; i < array.GetLength(0); i++)
//{
//    for(int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.WriteLine(array[i, j]);
//    }
//}

//string[] array = new string[] { "Asim", "Hameed" };
//foreach(var i in array) 
//{
//    Console.WriteLine(array[i]);
//}

// Jagged Array

//int[][] array = new int[3][];
//array[0] = new[] {1,2,3,4};
//array[1] = new[] {5,6,7,8,7,6,5};
//array[2] = new[] {9,10,11};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array[i].Length; j++)
//    {
//        Console.WriteLine(array[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//foreach(int[] i in array)
//{
//    foreach (int j in i)
//    {
//        Console.WriteLine(j);
//    }
//}

//Jagged Array end


//public class mainEntryPoint
//{

//    public static void Main(string[] args)
//    {
//        showNameAge("asim",25);
//    }
//    public static void showNameAge(string name,int age)
//    {
//        Console.WriteLine(name + " " + age);
//    }



//}

//static void addition(int num1,int num2)
//{
//    Console.WriteLine(num1 + num2);
//}
//static void subtraction(int num1, int num2)
//{
//    Console.WriteLine(num1 - num2);
//}
//static void multiplication(int num1, int num2)
//{
//    Console.WriteLine(num1 * num2);
//}
//static void division(int num1, int num2)
//{
//    Console.WriteLine(num1 / num2);
//}

//int num1, num2;

//Console.WriteLine("Enter num1: ");
//num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter num2: ");
//num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter operator ");
//char op = char.Parse(Console.ReadLine());

//if(op == '+')
//{
//    addition(num1,num2);
//}
//else if (op == '-')
//{
//    subtraction(num1,num2);
//}
//else if (op == '*')
//{
//    multiplication(num1,num2);
//}
//else if (op=='/')
//{
//    division(num1,num2);
//}

//namespace IntroductionToCsharp
//{

//    struct Employee
//    {
//        public int salary { get; set; }
//        public int age { get; set; }
//    }
//    public static void Main(string[] args)
//    {
//        Employee employee = new Employee();
//    }
//}

//void sum(ref int n1,ref int n2)
//{

//    Console.WriteLine(n1 + n2);
//    n1 += n2;
//}

//int n1 = 2,n2=5;
//sum(ref n1, ref n2);
//Console.WriteLine(n1);

//void passByOut(out int a)
//{
//    a = 20;
//    Console.WriteLine("Pass by out value is {0}",a);
//}

//int a;
//passByOut(out a);
//Console.WriteLine(a);

//var b = "asim";
//Console.WriteLine(b.GetType());

//dynamic a = "asim";
//a = 10;
//Console.WriteLine(a.GetType());

//void fun(dynamic a)
//{
//    Console.WriteLine(a);
//}

//// dynamic have no intellisense as they are compiled at run time
//// they can be assigned other data types for instance string to int to char
//// they can be passed as parameter in function
//// they can not be returned by return keyword
//// dynamic is reference 

//fun(a);
//fun(b);

namespace IntroductionToCsharp 
{
    class student
    {
        //int rollno;
        //string name;
        //int age;
        //int standard;

        //parametrized constructor start
        //int empId;
        //string empName;
        //public student(int empid,string name) 
        //{
        //    empId = empid;
        //    empName = name;
        //    Console.WriteLine("Constructor Called {0}{1}",empId,empName);
        //}



        //parametrized constructor end


        //public void setRollNo(int rollno,string name,int age,int standard)
        //{
        //    this.rollno = rollno;
        //    this.name = name;
        //    this.age = age;
        //    this.standard = standard;
        //}
        //public void getRollNo()
        //{
        //    Console.WriteLine("Roll no is {0}", this.rollno);
        //    Console.WriteLine("Name is {0}",this.name);
        //    Console.WriteLine("Age is {0}", this.age);
        //    Console.WriteLine("Standard is {0}",this.standard);
        //}

        static void Main(string[] args)
        {
            //student student = new student();

            //student.setRollNo(0365, "Asim", 25, 16);
            //student.getRollNo();
            //Console.ReadLine();

            //student student = new student(23,"Asim");


        }
    }


}