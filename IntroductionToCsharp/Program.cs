using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    class Student
    {
        //public int rollno;
        //public string fname;
        //public string lname;
        //public int standard;
        //public static string schoolName = "SKKPHSSM";
        //public static int getFees()
        //{
        //    return 4000;
        //}
        //public static int getannualinc(int fee)
        //{
        //    return fee/10;
        //}

        //public static string pName = "Asim";
        //public static int pAge = 25;

        //public Student() 
        //{
        //    Console.WriteLine("Default constructor Invoked!");
        //}
        //static Student()
        //{
        //    pName = "ali";
        //    pAge = 22;
        //    Console.WriteLine("Static constructor Invoked!! ");

        //}
        //public void getDetials()
        //{
        //    Console.WriteLine("person name is {0}", pName);
        //    Console.WriteLine("perons age is {0}", pAge);
        //}
        //string name;
        //int age;
        //public Student(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}

        //public Student(Student student)  //copy constructor
        //{ 
        //    this.name=student.name;
        //    this.age = student.age;
        //}
        //public void getData()
        //{
        //    Console.WriteLine("Name is {0}", name);
        //    Console.WriteLine("Age is {0}", age);
        //}

        //private constructor

        //string name;
        //public Student(string name)
        //{
        //    this.name=name;
        //}
        //private Student() { }

        //public static void getTime()
        //{
        //    Console.WriteLine(DateTime.Now.ToString());
        //}

        //END....

    }

    //static class Example{
    //    public static int prodId;
    //    public static string prodName;
    //    public static int prodPrice;

    //    static Example()
    //    {
    //        prodId = 1;
    //        prodName = "Asim";
    //        prodPrice = 100;
    //    }
    //    public static void getDetails()
    //    {
    //        Console.WriteLine("Product id: {0}", prodId);
    //        Console.WriteLine("Product Name: {0}", prodName);
    //        Console.WriteLine("Product price: {0}", prodPrice);
    //    }
    //}
    class Program
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

            //Student student = new Student();
            //student.rollno = 1;
            //student.fname = "Asim";
            //student.lname = "Hameed";
            //student.standard = 16;
            //Student student2 = new Student();
            //student2.rollno = 2;
            //student2.fname = "Ali";
            //student2.lname = "Hassan";
            //student2.standard = 15;
            //Console.WriteLine( student.rollno+"  "+student2.rollno);
            //Console.WriteLine(student.fname + "  " + student2.fname);
            //Console.WriteLine(student.lname + "  " + student2.lname);
            //Console.WriteLine(student.standard + "  " + student2.standard);
            //Console.WriteLine(Student.getFees() + "  " + Student.getFees());
            //Console.WriteLine(Student.getannualinc(4000) + "  " + Student.getannualinc(4000));

            //Console.WriteLine(Student.schoolName + "  " + Student.schoolName);
            //static constructor
            //Student student = new Student();
            //student.getDetials();
            //Student student1 = new Student();
            // END

            //Student student = new Student("Asim",25);
            //student.getData();

            ////copy contructor

            //Student copy = new Student(student);
            //copy.getData();

            //private constructor called only for static members
            // they don't have any object,only called by class name 
            // if there is parameterized constructor then object can be made
            //Student.getTime();

            //Student student = new Student("Asim");

            // END........

            //Static Class

            //Example.getDetails();

            //END.........

            //Destructor

            Console.ReadLine();
        }
    }


}