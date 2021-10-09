using System;
using System.Diagnostics;

namespace Lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X("1", "2", "3");
            Y y = new Y("2", "3", "4");
            Z z = new Z("5", "6", "7");

            x.Print();
            y.Print();
            z.Print();

            Console.ReadKey();
        }
    }

    class Letter
    {
        string x, y, z;

        public virtual void Print()
        {
            Console.WriteLine($"Class Letter: {x}, {y}, {z}");
        }
    }
    class X : Letter
    {
        string x, y, z;
        public X(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class X: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} X.X: {x}");
            Debug.WriteLine($"{y.GetType()} X.Y: {y}");
            Debug.WriteLine($"{z.GetType()} X.Z: {z}");
        }
    }

    class Y : Letter
    {
        string x, y, z;
        public Y(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class Y: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} Y.X: {x}");
            Debug.WriteLine($"{y.GetType()} Y.Y: {y}");
            Debug.WriteLine($"{z.GetType()} Y.Z: {z}");
        }
    }

    class Z : Letter
    {
        string x, y, z;
        public Z(string X, string Y, string Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override void Print()
        {
            Console.WriteLine($"Class Z: {x}, {y}, {z}");
            Debug.WriteLine($"{x.GetType()} Z.X: {x}");
            Debug.WriteLine($"{y.GetType()} Z.Y: {y}");
            Debug.WriteLine($"{z.GetType()} Z.Z: {z}");
        }
    }
}
