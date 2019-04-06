using System;
using System.Collections.Generic;
namespace Tarea_Unidad4
{
class A
    {
     public int a;
     public A()
     {
      a = 10;
     }
     //public _______ string Display()
     public virtual string Display()
      {
        return a.ToString();
      }
    }
class B:A
   {
     public int b;
     public B():base()
    {
      b = 15;
    }
  public override string Display()
    {
      return b.ToString();
    }
   }

 class Program
 {
     public static void Main()
    {
     A objA = new A();
     B objB = new B();
     Console.WriteLine(objA.Display()); ////  (1 )
     Console. WriteLine(objB.Display()); ////  ( 2)
    }

  }
}