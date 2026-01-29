using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==========constuctor overloading start here======
            a obj1 = new a();//it will call parameter less constructor(userdefined default consturctor)
            a obj2 = new a(10);//it will call the single parameter constuctor
            a obj3 = new a(10, 10);//it will call the Two parameter constuctor
            a obj4 = new a(10, 10, "av");//it will call the Three parameter constuctor((int a, int b,string c) this combination)
            a obj5 = new a(10, 10, "a");//it will call the Three parameter constuctor((int a, float b, string c) this combination)

            //==========constuctor overloading End here======


            //=============Method overloading start here============
            a obj = new a(10,10,"abc");
            obj.add("a", "b", 10);//here your c# compiler deciside which method need to call based ur on your parameter.
            obj.add();//it will call the without parameter method
            obj.add();//we can call same method multiple times also.it will not throw any error.
            obj.add(10);//it will call the single parameter method
            obj.add(10, 10);//it will call two paarmeter(int,int )combination method it willcall
            obj.add("a", "b");
            obj.add("a", "b", 10, 1);
            obj.add(10, 10, "a");
            obj.add("a1", "b1", 10);
            obj.add("c1", "c2", "c3");
            //=============Method overloading End here============
        }
    }
}
