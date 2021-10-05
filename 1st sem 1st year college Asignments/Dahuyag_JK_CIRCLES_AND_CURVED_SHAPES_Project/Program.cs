using System;
using System.Threading;

namespace Dahuyag_JK_CIRCLES_AND_CURVED_SHAPES_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string[] overallHistory = new string[100];
            string history = "";
            Welcome();
        Selection:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please select your choice: (1:COMPUTATION) (2:SUMMARY) (3:EXIT)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************\n");
            Console.ResetColor();
            Console.Write("Input your choice here: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Computation(out history);
                    break;
                case "2":
                    Console.Clear();
                    Summary();
                    break;
                case "3":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.WriteLine("You've entered an invalid input. Press enter to try again");
                    Console.ReadLine();
                    goto Selection;
            }
            overallHistory[0] = history;
            switch (choice)
            {
                case "1":
                    goto Selection;
                case "2":
                    goto Selection;
            }
            
        }
        static void Title()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I N P U T  O F  V A L U E S");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************\n");
            Console.ResetColor();
        }
        static void Welcome()
        {
            string[] programDescription = { "This is a program that computes for different variables concerning circles and curved shapes", "This program contains various formulas to compute for the radius, diameter, area, perimeter, etc. of circles and curved shapes", "Press Enter to proceed" };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tH E L L O  A N D  W E L C O M E  T O  M Y  P R O G R A M!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************************************************");
            Console.ResetColor();
            Reader(programDescription);
            Console.ReadLine();
            Console.Clear();
        }
        static void Reader(Array text)
        {
            foreach (string x in text)
            {
                foreach (char i in x)
                {
                    Console.Write(i);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Thread.Sleep(500);
            }
        }
        static void Computation(out string history)
        {
            double finalAnswer = 0;
            int shapeChoice;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose a shape to work on: (1:Circle) (2:Semi-Circle) (3:Ring) (4:Ellipse)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************\n");
            Console.ResetColor();

            shapeChoice = Convert.ToInt32(Console.ReadLine());
            switch (shapeChoice)
            {
                case 1:
                    finalAnswer = Circle();
                    break;
                case 2:
                    finalAnswer = SemiCircle();
                    break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("R E S U L T  S C R E E N");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************************************************\n");
            Console.ResetColor();
            Console.WriteLine("The computed value is: {0}", finalAnswer);
            history = Convert.ToString(finalAnswer);
            Console.ReadLine();
        }
        static void Summary()
        {

        }
        static void Exit()
        {

        }
        static double Circle()
        {
            int given2 = 0;
            int value2 = 0;
        CircleSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Chord)\n(6:Arc Length)\n(7:Area of Sector)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            Title();
            Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: Some values might now work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Title();
            Console.WriteLine("Input the value of the given: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (asked >= 5 && asked <= 7)
            {
                Title();
                Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Chord)\n(6:Arc Length)\n(7:Area of Sector)\n(8:Central Angle)\nNote: Some values might now work for certain formulas\nInput the number of your choice:");
                given2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the value of the given: ");
                value2 = Convert.ToInt32(Console.ReadLine());
            }
            double askedValue = 0;
            switch (asked)
            {
                case 1:
                    CircleRadius(given, value, out askedValue);
                    break;
                case 2:
                    CircleDiameter(given, value, out askedValue);
                    break;
                case 3:
                    CircleArea(given, value, out askedValue);
                    break;
                case 4:
                    CirclePerimeter(given, value, out askedValue);
                    break;
                case 5:
                    CircleChord(given, value, given2, value2, out askedValue);
                    break;
                case 6:
                    CircleArcLength(given, value, given2, value2, out askedValue);
                    break;
                case 7:
                    CircleSector(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto CircleSelection;
            }
            return askedValue;
        }
        static double SemiCircle()
        {
            double askedValue = 0;
            int given2 = 0;
            int value2 = 0;
        SemiCircleSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Arc Length)\n(6:Area of Sector)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            Title();
            Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: Some values might now work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Title();
            Console.WriteLine("Input the value of the given: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (asked >= 5 && asked <= 7)
            {
                Title();
                Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Chord)\n(6:Arc Length)\n(7:Area of Sector)\n(8:Central Angle)\nNote: Some values might now work for certain formulas\nInput the number of your choice:");
                given2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the value of the given: ");
                value2 = Convert.ToInt32(Console.ReadLine());
            }
            switch (asked)
            {
                case 1:
                    CircleRadius(given, value, out askedValue);
                    break;
                case 2:
                    CircleDiameter(given, value, out askedValue);
                    break;
                case 3:
                    CircleArea(given, value, out askedValue);
                    break;
                case 4:
                    CirclePerimeter(given, value, out askedValue);
                    break;
                case 5:
                    CircleChord(given, value, given2, value2, out askedValue);
                    break;
                case 6:
                    CircleArcLength(given, value, given2, value2, out askedValue);
                    break;
                case 7:
                    CircleSector(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto SemiCircleSelection;
            }
            return askedValue;
        }
        //All Circle formulas
        static double CircleArea(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = Math.PI * value * value;
                    break;
                case 2:
                    askedValue = Math.PI * value/2 * value/2;
                    break;
                case 4:
                    askedValue = Math.Pow((value / (2 * Math.PI)), 2) * Math.PI;
                    break;
            }
            return askedValue;
        }
        static double CirclePerimeter(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = 2 * Math.PI * value;
                    break;
                case 2:
                    askedValue = Math.PI * value;
                    break;
                case 3:
                    askedValue = Math.Sqrt(value / Math.PI) * 2 * Math.PI;
                    break;
            }
            return askedValue;
        }
        static double CircleRadius(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 2:
                    askedValue = value/2;
                    break;
                case 3:
                    askedValue = Math.Sqrt(value / Math.PI);
                    break;
                case 4:
                    askedValue = value / (2 * Math.PI);
                    break;
            }
            return askedValue;
        }
        static double CircleDiameter(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = value / Math.PI;
                    break;
                case 3:
                    askedValue = Math.Sqrt(value / Math.PI) * 2;
                    break;
                case 4:
                    askedValue = Math.PI * value;
                    break;
            }
            return askedValue;
        }
        static double CircleChord(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = 2 * value * Math.Sin(value2 / 2);
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = 2 * value2 * Math.Sin(value / 2);
            }
            return askedValue;
        }
        static double CircleSector(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = 2 * value * value * Math.PI * value2/360;
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = 2 * value2 * value2 * Math.PI * value / 360;
            }
            return askedValue;
        }
        static double CircleArcLength(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = (value2 / 180) * Math.PI * value;
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = (value / 180) * Math.PI * value2;
            }
            return askedValue;
        }
        //all Ellipse Formulas
        static double EllipseArea(int given, double value, int given2, double value2)
        {
            double askedValue = 0;
            if((given == 1 && given2 == 2)||(given == 2 && given2== 1))
            {
                askedValue = Math.PI * value * value2;
            }
            else if((given == 1 || given == 2) && given2 == 3)
            {
                askedValue = Math.PI * value * Math.Sqrt(((Math.Pow((value2/(2 * Math.PI)),2) * 2) - Math.Pow(value,2)));
            }
            else if ((given2 == 1 || given2 == 2) && given == 3)
            {
                askedValue = Math.PI * value2 * Math.Sqrt(((Math.Pow((value / (2 * Math.PI)), 2) * 2) - Math.Pow(value2, 2)));
            }
            return askedValue;
        }
        static double EllipseCircumference(int given, double value, int given2, double value2)
        {
            double askedValue = 0;
            if ((given == 1 && given2 == 2) || (given == 2 && given2 == 1))
            {
                askedValue = 2 * Math.PI * Math.Sqrt((Math.Pow(value,2) + Math.Pow(value2, 2))/2);
            }
            else if ((given == 1 || given == 2) && given2 == 4)
            {
                askedValue = 2 * Math.PI * Math.Sqrt((Math.Pow(value, 2) + Math.Pow((value2/(Math.PI * value)), 2)) / 2);
            }
            else if ((given2 == 1 || given2 == 2) && given == 4)
            {
                askedValue = 2 * Math.PI * Math.Sqrt((Math.Pow(value2, 2) + Math.Pow((value / (Math.PI * value)), 2)) / 2);
            }
            return askedValue;
        }
        //All Semi Circle Formulas
        static double SemiCircleArea(int given, double value)
        {
            double askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = (Math.PI * value * value)/2;
                    break;
                case 2:
                    askedValue = (Math.PI * value / 2 * value / 2)/2;
                    break;
                case 4:
                    askedValue = (Math.Pow((value / (2 * Math.PI)), 2) * Math.PI)/2;
                    break;
            }
            return askedValue;
        }
        static double SemiCirclePerimeter(int given, double value)
        {
            double askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = (2 * Math.PI * value)/2;
                    break;
                case 2:
                    askedValue = (Math.PI * value)/2;
                    break;
                case 3:
                    askedValue = (Math.Sqrt(value / Math.PI) * 2 * Math.PI)/2;
                    break;
            }
            return askedValue;
        }
        static double SemiCircleRadius(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 2:
                    askedValue = value / 2;
                    break;
                case 3:
                    askedValue = Math.Sqrt((value*2) / Math.PI);
                    break;
                case 4:
                    askedValue = value / (Math.PI);
                    break;
            }
            return askedValue;
        }
        static double SemiCircleDiameter(int given, double value, out double askedValue)
        {
            askedValue = 0;
            switch (given)
            {
                case 1:
                    askedValue = value / Math.PI;
                    break;
                case 3:
                    askedValue = Math.Sqrt(value / Math.PI) * 2;
                    break;
                case 4:
                    askedValue = Math.PI * value;
                    break;
            }
            return askedValue;
        }
        static double SemiCircleChord(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = 2 * value * Math.Sin(value2 / 2);
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = 2 * value2 * Math.Sin(value / 2);
            }
            return askedValue;
        }
        static double SemiCircleSector(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = 2 * value * value * Math.PI * value2 / 360;
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = 2 * value2 * value2 * Math.PI * value / 360;
            }
            return askedValue;
        }
        static double SemiCircleArcLength(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if (given == 2)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 2)
            {
                value2 /= 2;
                given2 = 1;
            }
            if (given == 1 && given2 == 5)
            {
                askedValue = (value2 / 180) * Math.PI * value;
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = (value / 180) * Math.PI * value2;
            }
            return askedValue;
        }
        //All Ring Formulas
        static double RingArea(int given, double value, int given2, double value2)
        {
            double askedValue = 0;
            if (given == 4)
            {
                value /= 2;
                given = 2;
            }
            if (given == 3)
            {
                value /= 2;
                given = 1;
            }
            if (given2 == 4)
            {
                value2 /= 2;
                given2 = 2;
            }
            if (given2 == 3)
            {
                value2 /= 2;
                given2 = 1;
            }

            if (given == 1 && given2 == 2)
            {
                askedValue = Math.PI * Math.Pow((value2 - value),2);
            }
            else if (given == 1 && given2 == 2)
            {
                askedValue = Math.PI * Math.Pow((value - value2), 2);
            }
            return askedValue;
        }
        static double RingCircumference(int given, double value, int given2, double value2)
        {
            double askedValue;
            
            askedValue = 2 * Math.PI * (value2 + value);

            return askedValue;
        }
    }
}
