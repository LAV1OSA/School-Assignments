using System;
using System.Threading;
using System.Collections.Generic;

namespace Dahuyag_JK_CIRCLES_AND_CURVED_SHAPES_Project
{
    class Program
    {
        public static List<SummaryList> history = new List<SummaryList>(); // declared a global list for me to use in computation and summary functions
        public static int counter = 0; //declared a global counter so it wont resent every time I call the computation function
        static void Main(string[] args)
        {
            string choice;
            Welcome();
        Selection:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please select your choice: (1:COMPUTATION) (2:SUMMARY) (3:EXIT)\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
            Console.Write("Input your choice here: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Computation();
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
            if (choice == "1" || choice == "2")
                goto Selection;
            
        }  
        static void Title()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\tI N P U T  O F  V A L U E S\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
        }
        static void Welcome()
        {
            string[] programDescription = { "This is a program that computes for different variables concerning circles and curved shapes", "This program contains various formulas to compute for the radius, diameter, area, perimeter, etc. of circles and curved shapes", "Press Enter to proceed" };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\tH E L L O  A N D  W E L C O M E  T O  M Y  P R O G R A M!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************************************************************************************************");
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
        }//responsible for the typing-like of the texts in the welcome and exit screens
        static void Computation()
        {
            string givenValue = "";
            string givenValue2 = "";
            string given = "";
            string given2 = "";
            string unitOfGiven = "";
            string unitOfGiven2 = "";
            string unit;
            string requiredValue = "";
            bool squared = false;
            double finalAnswer = 0;
            string shapeChoice = "";
            int shapeChoiceNumber;
            int innercounter = 0;
            Console.WriteLine("You chose option 1!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose a shape to work on: (1:Circle) (2:Semi-Circle) (3:Ring) (4:Ellipse)\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
            
            shapeChoiceNumber = Convert.ToInt32(Console.ReadLine());
            
            switch (shapeChoiceNumber)
            {
                case 1:
                    shapeChoice = "Circle";
                    finalAnswer = Circle(out squared, out requiredValue, out given, out givenValue, out unitOfGiven, out given2, out givenValue2, out unitOfGiven2);
                    break;
                case 2:
                    shapeChoice = "Semi-Circle";
                    finalAnswer = SemiCircle(out squared, out requiredValue, out given, out givenValue, out unitOfGiven, out given2, out givenValue2, out unitOfGiven2);
                    break;
                case 3:
                    shapeChoice = "Ring";
                    finalAnswer = Ring(out squared, out requiredValue, out given, out givenValue, out unitOfGiven, out given2, out givenValue2, out unitOfGiven2);
                    break;
                case 4:
                    shapeChoice = "Ellipse";
                    finalAnswer = Ellipse(out squared, out requiredValue, out given, out givenValue, out unitOfGiven, out given2, out givenValue2, out unitOfGiven2);
                    break;
            }
            switch (squared)
            {
                case true:
                    unit = "sq.";
                    break;
                case false:
                    unit = "";
                    break;
            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\tR E S U L T  S C R E E N\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
            counter++;
            history.Add(new SummaryList() { iteration = counter, shapeChoice = shapeChoice, nameOfGiven = given, valueOfGiven = givenValue, unitOfGiven = unitOfGiven, nameOfGiven2 = given2, valueOfGiven2 = givenValue2, unitOfGiven2 = unitOfGiven2, required = requiredValue, requiredvalue = finalAnswer, requiredunit = unit });
            foreach (SummaryList iteration in history)//basically prints the outcome after every computation
            {
                innercounter += 1;
                if (innercounter == counter)
                    Console.WriteLine(iteration);
            }
            innercounter = 0;//resets inner counter
            /*if(givenValue2 == "null")
                Console.WriteLine("{3} = {4} {5}units\n\nThe {2} is: {0} {1} units\n\nPress Enter to go back to the seletion screen", finalAnswer, unit, requiredValue, given, givenValue, unitOfGiven);
            else
                Console.WriteLine("{3} = {4} {5}units \n{6} = {7} {8} units \n\nThe {2} is: {0} {1} units\n\nPress Enter to go back to the seletion screen", finalAnswer, unit, requiredValue, given, givenValue, unitOfGiven, given2, givenValue2, unitOfGiven2);
            */
            Console.WriteLine("Press Enter to go back to the seletion screen");
            Console.ReadLine();
        }
        static void Summary()
        {
            Console.WriteLine("You chose option 2!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\tS U M M A R Y  S C R E E N\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
            foreach (SummaryList iteration in history)//basically prints all iterations of the computation
            {
                Console.WriteLine(iteration);
            }
            Console.WriteLine("End of List. Press Enter to go back to the selection screen");
            Console.ReadLine();
        }
        static void Exit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t\tE X I T  S C R E E N\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("************************************************************************************************************************\n");
            Console.ResetColor();
            string[] exitMessage = { "Thank you for using my program to compute different variables concerning circles and curved shapes", "In the future, I plan to include more shapes and formulas to my program", "I also plan on improving the user friendliness of the program", "Again, thank you and I hope you use my program again!" };
            Reader(exitMessage);
            Console.ReadLine();
        }
        static bool CheckComputability(int given)
        {
            bool canCompute = true;
            if (given == 5)
            {
                canCompute = false;
                Console.WriteLine("Cannot compute the required value using the given value(s). Press enter to retry.");
                Console.ReadLine();
            }
            return canCompute;
        }
        static bool CheckComputability(int given, int given2)
        {
            bool canCompute = true;
            if (!(((given == 5) && (given2 == 1 || given2 == 2)) || ((given == 1 || given == 2) && (given2 == 5))))
            {
                canCompute = false;
                Console.WriteLine("Cannot compute the required value using the given value(s). Press enter to retry.");
                Console.ReadLine();
            }
            return canCompute;
        }
        //General Circle Method
        static double Circle(out bool squaredFinalUnit, out string toBeComputed, out string nameOfGiven, out string valueOfGiven, out string unitOfGiven, out string nameOfGiven2, out string valueOfGiven2, out string unitOfGiven2)
        {
            nameOfGiven = "";
            nameOfGiven2 = "Given 2";
            valueOfGiven = "";
            valueOfGiven2 = "null";
            unitOfGiven = "";
            unitOfGiven2 = "";
            int given2 = 0;
            double value2 = 0;
            toBeComputed = "";
        CircleSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Chord)\n(6:Arc Length)\n(7:Area of Sector)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            switch (asked)
            {
                case 1:
                    toBeComputed = "radius";
                    break;
                case 2:
                    toBeComputed = "diameter";
                    break;
                case 3:
                    toBeComputed = "area";
                    break;
                case 4:
                    toBeComputed = "circumference";
                    break;
                case 5:
                    toBeComputed = "chord";
                    break;
                case 6:
                    toBeComputed = "arc length";
                    break;
                case 7:
                    toBeComputed = "sector area";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto CircleSelection;
            }
            Title();
            Console.WriteLine("You chose to compute for the {0}\n", toBeComputed);
            Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value = Convert.ToDouble(Console.ReadLine());
            valueOfGiven = Convert.ToString(value);
            switch (given)
            {
                case 1:
                    nameOfGiven = "radius";
                    break;
                case 2:
                    nameOfGiven = "diameter";
                    break;
                case 3:
                    nameOfGiven = "area";
                    unitOfGiven = "sq.";
                    break;
                case 4:
                    nameOfGiven = "circumference";
                    break;
                case 5:
                    nameOfGiven = "central angle";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto CircleSelection;
            }
            if (asked >= 5 && asked <= 7)
            {
                Title();
                Console.WriteLine("You chose to compute for the {0}\n", toBeComputed);
                Console.WriteLine("Your choice needs two given values\nPick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: One of the given values must be a central angle\nInput your choice here:");
                given2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the value of the given: ");
                value2 = Convert.ToDouble(Console.ReadLine());
                valueOfGiven2 = Convert.ToString(value2);
                switch (given2)
                {
                    case 1:
                        nameOfGiven2 = "radius";
                        break;
                    case 2:
                        nameOfGiven2 = "diameter";
                        break;
                    case 3:
                        nameOfGiven2 = "area";
                        unitOfGiven2 = "sq.";
                        break;
                    case 4:
                        nameOfGiven2 = "circumference";
                        break;
                    case 5:
                        nameOfGiven2 = "central angle";
                        break;
                    default:
                        Console.WriteLine("Choice does not exist. Press Enter to try again");
                        Console.ReadLine();
                        goto CircleSelection;
                }
            }
            double askedValue = 0;
            if ((given <= 4 && given > 0)&&(given == asked))
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto CircleSelection;
            }
            if (given == given2)
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto CircleSelection;
            }
            squaredFinalUnit = false;
            switch (asked)
            {
                case 1:
                    if (!(CheckComputability(given)))
                        goto CircleSelection;
                    CircleRadius(given, value, out askedValue);
                    break;
                case 2:
                    if (!(CheckComputability(given)))
                        goto CircleSelection;
                    CircleDiameter(given, value, out askedValue);
                    break;
                case 3:
                    if (!(CheckComputability(given)))
                        goto CircleSelection;
                    squaredFinalUnit = true;
                    CircleArea(given, value, out askedValue);
                    break;
                case 4:
                    if (!(CheckComputability(given)))
                        goto CircleSelection;
                    CirclePerimeter(given, value, out askedValue);
                    break;
                case 5:
                    if (!(CheckComputability(given, given2)))
                        goto CircleSelection;
                    CircleChord(given, value, given2, value2, out askedValue);
                    break;
                case 6:
                    if (!(CheckComputability(given, given2)))
                        goto CircleSelection;
                    CircleArcLength(given, value, given2, value2, out askedValue);
                    break;
                case 7:
                    if (!(CheckComputability(given, given2)))
                        goto CircleSelection;
                    squaredFinalUnit = true;
                    CircleSector(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto CircleSelection;
            }
            
            return askedValue;
        }
        //General Semi Circle Method
        static double SemiCircle(out bool squaredFinalUnit, out string toBeComputed, out string nameOfGiven, out string valueOfGiven, out string unitOfGiven, out string nameOfGiven2, out string valueOfGiven2, out string unitOfGiven2)
        {
            nameOfGiven = "";
            nameOfGiven2 = "Given 2";
            valueOfGiven = "";
            valueOfGiven2 = "null";
            unitOfGiven = "";
            unitOfGiven2 = "";
            toBeComputed = "";
            double askedValue = 0;
            int given2 = 0;
            double value2 = 0;
        SemiCircleSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Arc Length)\n(6:Area of Sector)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            switch (asked)
            {
                case 1:
                    toBeComputed = "radius";
                    break;
                case 2:
                    toBeComputed = "diameter";
                    break;
                case 3:
                    toBeComputed = "area";
                    break;
                case 4:
                    toBeComputed = "circumference";
                    break;
                case 5:
                    toBeComputed = "arc length";
                    break;
                case 6:
                    toBeComputed = "sector area";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto SemiCircleSelection;
            }
            Title();
            Console.WriteLine("You chose to compute for the {0}\n", toBeComputed);
            Console.WriteLine("Pick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value = Convert.ToDouble(Console.ReadLine());
            valueOfGiven = Convert.ToString(value);
            switch (given)
            {
                case 1:
                    nameOfGiven = "radius";
                    break;
                case 2:
                    nameOfGiven = "diameter";
                    break;
                case 3:
                    nameOfGiven = "area";
                    unitOfGiven = "sq.";
                    break;
                case 4:
                    nameOfGiven = "circumference";
                    break;
                case 5:
                    nameOfGiven = "central angle";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto SemiCircleSelection;
            }
            if (asked >= 5 && asked <= 7)
            {
                Title();
                Console.WriteLine("Your choice needs two given values\nPick the number of the value that is given:\n(1:Radius)\n(2:Diameter)\n(3:Area)\n(4:Circumference)\n(5:Central Angle)\nNote: One of the given values must be a central angle\n");
                given2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the value of the given: ");
                value2 = Convert.ToDouble(Console.ReadLine());
                valueOfGiven2 = Convert.ToString(value2);
                switch (given2)
                {
                    case 1:
                        nameOfGiven2 = "radius";
                        break;
                    case 2:
                        nameOfGiven2 = "diameter";
                        break;
                    case 3:
                        nameOfGiven2 = "area";
                        unitOfGiven2 = "sq.";
                        break;
                    case 4:
                        nameOfGiven2 = "circumference";
                        break;
                    case 5:
                        nameOfGiven2 = "central angle";
                        break;
                    default:
                        Console.WriteLine("Choice does not exist. Press Enter to try again");
                        Console.ReadLine();
                        goto SemiCircleSelection;
                }
            }
            if ((given <= 4 && given > 0) && (given == asked))
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto SemiCircleSelection;
            }
            if (given == given2)
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto SemiCircleSelection;
            }
            squaredFinalUnit = false;
            switch (asked)
            {
                case 1:
                    if (!(CheckComputability(given)))
                        goto SemiCircleSelection;
                    SemiCircleRadius(given, value, out askedValue);
                    break;
                case 2:
                    if (!(CheckComputability(given)))
                        goto SemiCircleSelection;
                    SemiCircleDiameter(given, value, out askedValue);
                    break;
                case 3:
                    if (!(CheckComputability(given)))
                        goto SemiCircleSelection;
                    squaredFinalUnit = true;
                    SemiCircleArea(given, value, out askedValue);
                    break;
                case 4:
                    if (!(CheckComputability(given)))
                        goto SemiCircleSelection;
                    SemiCirclePerimeter(given, value, out askedValue);
                    break;
                case 5:
                    if (!(CheckComputability(given, given2)))
                        goto SemiCircleSelection;
                    SemiCircleArcLength(given, value, given2, value2, out askedValue);
                    break;
                case 6:
                    if (!(CheckComputability(given, given2)))
                        goto SemiCircleSelection;
                    squaredFinalUnit = true;
                    SemiCircleSector(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto SemiCircleSelection;
            }
            
            return askedValue;
        }
        static double Ring(out bool squaredFinalUnit, out string toBeComputed, out string nameOfGiven, out string valueOfGiven, out string unitOfGiven, out string nameOfGiven2, out string valueOfGiven2, out string unitOfGiven2)
        {
            nameOfGiven = "";
            nameOfGiven2 = "Given 2";
            valueOfGiven = "";
            valueOfGiven2 = "null";
            unitOfGiven = "";
            unitOfGiven2 = "";
            toBeComputed = "";
            double askedValue = 0;
        RingSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Area)\n(2:Circumference)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            switch (asked)
            {
                case 1:
                    toBeComputed = "area";
                    break;
                case 2:
                    toBeComputed = "circumference";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto RingSelection;
            }
            Title();
            Console.WriteLine("You chose to compute for the {0}\n", toBeComputed);
            Console.WriteLine("Pick the number of the value that is given:\n(1:Smaller Radius)\n(2:Bigger Radius)\n(3:Smaller Diameter)\n(4:Bigger Diameter)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value = Convert.ToDouble(Console.ReadLine());
            valueOfGiven = Convert.ToString(value);
            switch (given)
            {
                case 1:
                    nameOfGiven = "smaller radius";
                    break;
                case 2:
                    nameOfGiven = "bigger radius";
                    break;
                case 3:
                    nameOfGiven = "smaller diameter";
                    break;
                case 4:
                    nameOfGiven = "bigger diameter";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto RingSelection;
            }
            Title();
            Console.WriteLine("To compute the value, you need two given values\nPick the number of the value that is given:\n(1:Smaller Radius)\n(2:Bigger Radius)\n(3:Smaller Diameter)\n(4:Bigger Diameter)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            valueOfGiven2 = Convert.ToString(value2);
            switch (given2)
            {
                case 1:
                    nameOfGiven2 = "smaller radius";
                    break;
                case 2:
                    nameOfGiven2 = "bigger radius";
                    break;
                case 3:
                    nameOfGiven2 = "smaller diameter";
                    break;
                case 4:
                    nameOfGiven2 = "bigger diameter";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto RingSelection;
            }
            if (given == given2)
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto RingSelection;
            }
            squaredFinalUnit = false;
            switch (asked)
            {
                case 1:
                    squaredFinalUnit = true;
                    RingArea(given, value, given2, value2, out askedValue);
                    break;
                case 2:
                    RingCircumference(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto RingSelection;
            }
            
            return askedValue;
        }
        static double Ellipse(out bool squaredFinalUnit, out string toBeComputed, out string nameOfGiven, out string valueOfGiven, out string unitOfGiven, out string nameOfGiven2, out string valueOfGiven2, out string unitOfGiven2)
        {
            nameOfGiven = "";
            nameOfGiven2 = "Given 2";
            valueOfGiven = "";
            valueOfGiven2 = "null";
            unitOfGiven = "";
            unitOfGiven2 = "";
            toBeComputed = "";
            double askedValue;
        EllipseSelection:
            Title();
            Console.WriteLine("Pick the number of the value to compute:\n(1:Area)\n(2:Circumference)\nInput the number of your choice:");
            int asked = Convert.ToInt32(Console.ReadLine());
            switch (asked)
            {
                case 1:
                    toBeComputed = "area";
                    break;
                case 2:
                    toBeComputed = "circumference";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto EllipseSelection;
            }
            Title();
            Console.WriteLine("You chose to compute for the {0}\n", toBeComputed);
            Console.WriteLine("Pick the number of the value that is given:\n(1:Radius 1)\n(2:Radius 2)\n(3:Circumference)\n(4:Area)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value = Convert.ToDouble(Console.ReadLine());
            valueOfGiven = Convert.ToString(value);
            switch (given)
            {
                case 1:
                    nameOfGiven = "radius 1";
                    break;
                case 2:
                    nameOfGiven = "radius 2";
                    break;
                case 3:
                    nameOfGiven = "circumference";
                    break;
                case 4:
                    nameOfGiven = "area";
                    unitOfGiven = "sq.";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto EllipseSelection;
            }
            Title();
            Console.WriteLine("To compute the value, you need two given values\nPick the number of the value that is given:\n(1:Radius 1)\n(2:Radius 2)\n(3:Circumference)\n(4:Area)\nNote: Some values might not work for certain formulas\nInput the number of your choice:");
            int given2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the given: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            valueOfGiven2 = Convert.ToString(value2);
            switch (given2)
            {
                case 1:
                    nameOfGiven2 = "radius 1";
                    break;
                case 2:
                    nameOfGiven2 = "radius 2";
                    break;
                case 3:
                    nameOfGiven2 = "circumference";
                    break;
                case 4:
                    nameOfGiven2 = "area";
                    unitOfGiven2 = "sq.";
                    break;
                default:
                    Console.WriteLine("Choice does not exist. Press Enter to try again");
                    Console.ReadLine();
                    goto EllipseSelection;
            }
            squaredFinalUnit = false;
            if (given == given2)
            {
                Console.WriteLine("Invalid input. Cannot solve required value with the given values. Press enter to try again");
                Console.ReadLine();
                goto EllipseSelection;
            }
            switch (asked)
            {
                case 1:
                    squaredFinalUnit = true;
                    EllipseArea(given, value, given2, value2, out askedValue);
                    break;
                case 2:
                    EllipseCircumference(given, value, given2, value2, out askedValue);
                    break;
                default:
                    Console.WriteLine("Error. Choice does not exist. Try again.");
                    goto EllipseSelection;
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
                    askedValue = value * 2;
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
                askedValue = 2 * value * (Math.Sin(((value2 * Math.PI) / 360)));
            }
            else if (given == 5 && given2 == 1)
            {
                askedValue = 2 * value2 * (Math.Sin(((value2 * Math.PI) / 360)));
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
        static double EllipseArea(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            if((given == 1 && given2 == 2)||(given == 2 && given2== 1))
            {
                askedValue = Math.PI * value * value2;
            }
            else if((given == 1 || given == 2) && given2 == 3)
            {
                askedValue = Math.PI * value * Math.Sqrt((Math.Pow((value2/(2 * Math.PI)),2) * 2) - Math.Pow(value,2));
            }
            else if ((given2 == 1 || given2 == 2) && given == 3)
            {
                askedValue = Math.PI * value2 * Math.Sqrt((Math.Pow((value / (2 * Math.PI)), 2) * 2) - Math.Pow(value2, 2));
            }
            return askedValue;
        }
        static double EllipseCircumference(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
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
        static double SemiCircleArea(int given, double value, out double askedValue)
        {
            askedValue = 0;
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
        static double SemiCirclePerimeter(int given, double value, out double askedValue)
        {
            askedValue = 0;
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
                    askedValue = value * 2;
                    break;
                case 3:
                    askedValue = Math.Sqrt((value*2) / Math.PI) * 2;
                    break;
                case 4:
                    askedValue = (value / (Math.PI))*2;
                    break;
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
        static double RingArea(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
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
        static double RingCircumference(int given, double value, int given2, double value2, out double askedValue)
        {
            askedValue = 0;
            
            askedValue = 2 * Math.PI * (value2 + value);

            return askedValue;
        }
    }
}