using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_MethodOverloading
{
    //Method overloading: Same method name but different parameters.
    //Same combination of method should not repeat in method overloading.if it's repeat it will compiletime error.
    //Same combination of constuctor should not repeat in constructor overloading.if it's repeat it will compiletime error.
    //if writing the code,if any error is showing we called that error is called "compiletime error";
    internal class a
    {
        /*
        Method Syntax: -
        ======================================
       accessmodifer Returntype methodname(parameters or argments)
        {

            return data;
        }
        */
        //Void does not return any data.
        //Except void remaing all return types return the data.

        //============constructor overloading start here=============================
        //user defined default consturor will be created by user .without parameter.
        //system defined default constuctor will be created by c#compiler at runtime (while running the program c# compiler will create system defined default constructor)
        public a()//user defined default constuctor.it does not conatin any parameters
        {
            Console.WriteLine("i am default constructor");
        }
        public a(int a)
        {
            Console.WriteLine("i am single paramaterised(int a) constructor");
        }
        public a(int a,int b)
        {
            Console.WriteLine("i am Two paramaterised(int a,int b) constructor");
            //constucor usage is assign the data to instance variables 
        }
        public a(int a, int b,string c)
        {
            Console.WriteLine("i am Three paramaterised(int a, int b,string c) constructor");
        }
        public a(int a, float b, string c)
        {
            Console.WriteLine("i am Three paramaterised(int a, float b, string c) constructor");
        }
        //============constructor overloading end here=============================
        //============method overloading start here=============================
        //method usage is perform some opertions on varaibles and return data and excuting logic inside method also
        public void add()
        {
            Console.WriteLine("i am without parameter method");
        }
        public void add(int x)
        {
            Console.WriteLine("i am single paramaterised(int x) method");
        }
        public void add(int x, int y)
        {
            Console.WriteLine("i am Two paramaterised(int x, int y) method");
            int t = x + y;
            Console.WriteLine(t);
        }
        public void add(int x,int y,string a)
        {
            Console.WriteLine("i am Three paramaterised(int x,int y,string a) method");
            int t = x + y;
            Console.WriteLine(a+t);
        }

        public void add(string a,string b)
        {
            Console.WriteLine("i am Two paramaterised(string a,string b) method");
            Console.WriteLine(a+b); 
        }
        public void add(string a, string b,string c)
        {
            Console.WriteLine("i am Three paramaterised(string a, string b,string c) method");
            Console.WriteLine(a + b);
        }
        public void add(string a, string b, float c)
        {
            Console.WriteLine("i am Three paramaterised(string a, string b, float c) method");
            Console.WriteLine(a + b);
        }
        public void add(string a, string b, float c,int d)
        {
            Console.WriteLine("i am Four paramaterised(string a, string b, float c,int d) method");
            Console.WriteLine(a + b);
        }
        public void add(float c, string a, string b)
        {
            Console.WriteLine("i am Three paramaterised(float c, string a, string b) method");
            Console.WriteLine(a + b);
        }
        //============method overloading end here=============================
    }
}
