using System;

namespace Ex2A_Vector_Calc
{
    class Program
    {
        //
        //  Kurt Woodward
        //  ISTA 421 EX 2A
        //  Vector Distance Calculation
        //
        static void Main(string[] args)
        {
            Console.WriteLine("A: Two-Dimensional Coordinate Vector Calculator\nB: Three-Dimensional Coordinate Vector Calculator");
            selectProgram();
        }

        static void selectProgram()
        {
            string entry = Console.ReadLine();
            string message = "Please select either A or B";

            if (entry.ToLower() == "a")
            {
                TwoDimVectors.getCoords2();
                Functions.eucDistCalc2();
            }
            else if (entry.ToLower() == "b")
            {
                ThreeDimVectors.getCoords3();
                Functions.eucDistCalc3();
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
