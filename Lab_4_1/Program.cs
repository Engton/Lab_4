using System;
using System.Diagnostics;

namespace Lab_4

{

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Action(15, 42, 13);
            b.Action("one", "two", "three");
            c.Action(4.32, 5.54, 2.15);

            Console.ReadKey();
        }
    }

    public class A
    {
        public virtual void Action(object x, object y, object z)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
            Console.BackgroundColor = ConsoleColor.Black;
            Debug.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
        }
    }

    public class B : A
    {
        public override void Action(object x, object y, object z)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
            Console.BackgroundColor = ConsoleColor.Black;
            Debug.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
        }
    }

    public class C : A
    {
        public override void Action(object x, object y, object z)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
            Console.BackgroundColor = ConsoleColor.Black;
            Debug.WriteLine($"{x.GetType()} x: {x}, {y.GetType()} y: {y}, {z.GetType()} z: {z}");
        }
    }
}