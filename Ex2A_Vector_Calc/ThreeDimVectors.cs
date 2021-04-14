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
    class ThreeDimVectors
    {
        //public static int[,,] coordArray3 = new int[1000, 1000, 1000];
        public static int[] xArray = new int[1000];
        public static int[] yArray = new int[1000];
        public static int[] zArray = new int[1000];

        public static void getCoords3()
        {
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                xArray[i] = rand.Next(1,1001);
                yArray[i] = rand.Next(1, 1001);
                zArray[i] = rand.Next(1, 1001);
            }
        }
    }
}
