using System;
using System.Globalization;
using CSCLib;

namespace _4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils.PrintSeparator();

            // StartAll();
            ClassAndStruct();


            // -----------------------------------------------
            ConsoleUtils.EndOfProgram();
        }

        private static void StartAll()
        {
            CharacterRunner();
            ConsoleUtils.PrintSeparator();

            CalculatorRunner();
            ConsoleUtils.PrintSeparator();

            OutParameters();
            ConsoleUtils.PrintSeparator();

            StaticFields();
            ConsoleUtils.PrintSeparator();

            OptionalVariables();
            ConsoleUtils.PrintSeparator();

            ClassAndStruct();
        }

        private static void CharacterRunner()
        {
            var c = new Character();
            while (c.Health > 0)
            {
                Console.Write($"\b\rCurrent Health = {c.Health}        Damages: Spacebar = 1; Enter = 10; Delete = 50;    ");
                var keyPressed  = Console.ReadKey();

                switch (keyPressed.Key.ToString())
                {
                    case "Spacebar":
                        c.Hit(1);
                        break;
                    case "Enter":
                        c.Hit(10);
                        break;
                    case "Delete":
                        c.Hit(50);
                        break;
                }
            }
            Console.WriteLine();
        }

        private static void CalculatorRunner()
        {
            var c = new Calculator();
            Console.Write("Triangle 3-5-6:\t\t");
            Console.Write($"Heron's: {c.CalcTriangleSquare(3.0,4.0,5.0)}   ");
            Console.Write($"By Height: {c.CalcTriangleSquare(3.0,4.0)}   ");
            Console.WriteLine($"Trigonometric: {c.CalcTriangleSquare(3.0,4.0, 90)} ");

            Console.Write("Triangle 20-21-29:\t");
            Console.Write($"Heron's: {c.CalcTriangleSquare(20.0,21.0,29.0)} ");
            Console.Write($"By Height: {c.CalcTriangleSquare(20.0,21.0)} ");
            Console.WriteLine($"Trigonometric: {c.CalcTriangleSquare(20.0,21.0, 90)}");

            Console.WriteLine($"Triangle Base=6, Height=5: {c.CalcTriangleSquare(6.0,5.0)} ");
            Console.WriteLine($"Triangle Base=8, Height=9: {c.CalcTriangleSquare(8.0,9.0)} ");
            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30: {c.CalcTriangleSquare(7.0,9.0, 30)} ");

            Console.WriteLine();
            Console.WriteLine($"Average of 1,2,3,4: {c.Average(new []{1,2,3,4})}");
            Console.WriteLine($"Average of 1,2,3,4: {c.Average2(1, 2, 3, 4)}");

            // Named Arguments:
            c.CalcTriangleSquare(ab: 3.0,bc: 4.0,cd: 5.0);
            c.CalcTriangleSquare(@base: 3.0,height: 4.0);
            c.CalcTriangleSquare(ab: 3.0,ac: 4.0, angle: 90);
        }

        private static void OutParameters()
        {
            Console.Write("Enter integer: ");
            var integer = Console.ReadLine();
            // var parsed = int.Parse(integer);
            // int parsed = 0;
            int parsed = 0;
            var wasParsed = int.TryParse(integer, out parsed);
            Console.WriteLine($"Entered: {(!wasParsed ? "Error: Failed to parse..." : parsed.ToString())}");

            Console.WriteLine();

            Console.Write("Enter integer: ");
            var integer2 = Console.ReadLine();
            var wasParsed2 = int.TryParse(integer, out int parsed2);
            Console.WriteLine($"Entered: {(!wasParsed2 ? "Error: Failed to parse..." : parsed.ToString())}");

            Console.WriteLine();
            Console.WriteLine("Enter two doubles:");
            var d1 = double.Parse(Console.ReadLine() ?? "0,0");
            var d2 = double.Parse(Console.ReadLine() ?? "0,0");
            var c = new Calculator();
            bool wasDivided = c.TryDivide(d1, d2, out var result);
            Console.WriteLine($"{d1} / {d2}: {(!wasDivided ? "Error: Failed to divide..." : result.ToString(CultureInfo.CurrentCulture))}");

        }

        private static void StaticFields()
        {
            var c1 = new Character();
            var c2 = new Character();

            Console.Write("c1 speed: ");
            c1.PrintSpeed();
            Console.Write("c2 speed: ");
            c2.PrintSpeed();

            Console.WriteLine("c1 is increasing speed...");
            c1.IncreaseSpeed();

            Console.Write("c1 speed: ");
            c1.PrintSpeed();
            Console.Write("c2 speed: ");
            c2.PrintSpeed();

            Console.WriteLine("c2 is increasing speed...");
            c2.IncreaseSpeed();

            Console.Write("c1 speed: ");
            c1.PrintSpeed();
            Console.Write("c2 speed: ");
            c2.PrintSpeed();

        }

        private static void OptionalVariables()
        {
            var c = new Calculator();
            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(3.0,4.0, 90f)}");
            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(3.0,4.0, 1.57f, true)}");

            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(20.0,21.0, 90f)}");
            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(20.0,21.0, 1.57f, true)}");

            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(7.0,9.0, 30f)}");
            Console.WriteLine($"Triangle AB=7, AC=9, Angle=30 deg: {c.CalcTriangleSquare(7.0,9.0, 0.5235f, true)}");
        }

        private static void ClassAndStruct()
        {
            PointVal a; // PointVal a = new PointVal();
            a.X = 5;
            a.Y = 9;

            PointVal b = a;
            b.X = 4;
            b.Y = 8;

            a.LogValues();
            b.LogValues();

            PointRef c = new PointRef();
            c.X = 5;
            c.Y = 9;

            PointRef d = c;
            d.X = 4;
            d.Y = 8;

            c.LogValues();
            d.LogValues();

            Console.WriteLine("----------------");

            var es1 = new EvilStruct();
            es1.Name = "es1";
            es1.X = 1;
            es1.Y = 2;
            es1.PrRef = new PointRef() {X = 11, Y = 22};

            var es2 = es1;
            es2.Name = "es2";

            es1.LogValues();
            es2.LogValues();
            Console.WriteLine();

            es2.X = 3;
            es2.Y = 4;
            es2.PrRef.X = 33;
            es2.PrRef.Y = 44;

            es1.LogValues();
            es2.LogValues();
            Console.WriteLine();
        }
    }
}
