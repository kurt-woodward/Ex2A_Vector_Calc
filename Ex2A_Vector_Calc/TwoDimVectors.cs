using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2A_Vector_Calc
{
    //
    //  Kurt Woodward
    //  ISTA 421 EX 2A
    //  Vector Distance Calculation
    //
    public class TwoDimVectors
    {
        public static int[,] coordArray2 = new int[100, 100];
        public static void getCoords2()
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    coordArray2[i, j] = rand.Next(1, 101);
                }
            }
        }
    }
}
