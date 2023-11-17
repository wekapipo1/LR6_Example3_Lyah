using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ClassCounter
{    
    public delegate void MyDel();
    public event MyDel onCount;
    public void Count()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("i = {0}", i);
            if ((i == 7) && (onCount != null)) onCount();           
        }
    }
    public void Message()
    {
        Console.WriteLine("У себе 7!!!");
    }
}
class ClassHandler1
{
    public void Message()
    {
        Console.WriteLine("Час дiяти, адже вже 7!");
    }
}
class ClassHandler2
{
    public void Message()
    {
        Console.WriteLine("Точно, вже 7!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ClassCounter Counter = new ClassCounter();
        ClassHandler1 Handler1 = new ClassHandler1();
        ClassHandler2 Handler2 = new ClassHandler2();
        Counter.Count();
        Counter.onCount += Handler1.Message;
        Counter.onCount += Handler2.Message;
        Counter.onCount += Counter.Message;
        Counter.Count();
        Console.ReadKey();
    }
}
