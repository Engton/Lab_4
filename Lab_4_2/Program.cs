using System;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB classB = new ClassB();

            classB.A = 10;
            classB.B = 20;
            classB.C = 30;

            ClassC classC = new ClassC();

            classC.A = 5;
            classC.B = 10;
            classC.C = 15;

            ClassD classD = new ClassD();

            classD.A = 10;
            classD.B = 5;
            classD.C = 25;


            ClassE classE = new ClassE();

            classE.A = 5;
            classE.B = 55;
            classE.C = 35;

            ClassA classA = new ClassA(classC, classE);
            classA.actionA();
        }
    }


    class ClassA
    {

        public ClassB A { get; set; }
        public ClassB B { get; set; }

        public ClassB C { get; set; }

        public ClassA(ClassB a, ClassB b)
        {
            A = a;
            B = b;
        }

        public ClassA(ClassB a, ClassB b, ClassB c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void actionA()
        {
            A.Calculation();
            A.Print();
            B.Calculation();
            B.Print();
            if (C != null)
            {
                C.Calculation();
                C.Print();
            }
        }
    }

    class ClassB
    {
        protected int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        protected int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        protected int c;

        public int C
        {
            get { return c; }
            set { c = value; }
        }


        public virtual int Calculation()
        {

            c = (a * 10 + 20) - b;
            return c;
        }
        public virtual void Print()
        {
            Console.WriteLine($"a = {a};");
            Console.WriteLine($"b = {b};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }

    }

    class ClassC : ClassB
    {
        public override int Calculation()
        {

            c = a * 10;
            return c;
        }

        public override void Print()
        {
            Console.WriteLine($"a = {a};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }
    }

    class ClassD : ClassB
    {
        public override int Calculation()
        {
            a = (a * 15 + 15) - b * c;
            return a;
        }

        public override void Print()
        {
            Console.WriteLine($"a = {a};");
            Console.WriteLine();
        }
    }

    class ClassE : ClassB
    {
        public override int Calculation()
        {
            b = c + 20;
            return b;
        }

        public override void Print()
        {
            Console.WriteLine($"b = {b};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }
    }
}