using System;


namespace Ex2A_Vector_Calc
{
    class Functions
    {
        //
        //  Kurt Woodward
        //  ISTA 421 EX 2A
        //  Vector Distance Calculation
        //
        public static void eucDistCalc2()
        {
            double minDistance = Math.Sqrt(200);
            int x1 = 0, y1 = 0;
            int x2 = 0, y2 = 0;

            for (int i = 0; i < 99; i++)
            {
                int xCoord_1 = TwoDimVectors.coordArray2[i, i];
                int xCoord_2 = TwoDimVectors.coordArray2[i + 1, i + 1];

                for (int j = 1; j < 99; j++)
                {
                    int yCoord_1 = TwoDimVectors.coordArray2[j, j];
                    int yCoord_2 = TwoDimVectors.coordArray2[j + 1, j + 1];
                    double eucDistance;

                    if (i == j)
                    {
                        // Console.WriteLine("Coordinates are the same; not checked.");
                        break;
                    }
                    else
                    {
                        eucDistance = Math.Sqrt(Math.Pow((xCoord_1 - xCoord_2), 2) + Math.Pow((yCoord_1 - yCoord_2), 2));

                        if (minDistance > eucDistance)
                        {
                            minDistance = eucDistance;
                            x1 = xCoord_1;
                            y1 = yCoord_1;
                            x2 = xCoord_2;
                            y2 = yCoord_2;

                            Console.WriteLine($"The points with the minimum distance between them are element {i}-{j} and {i+1}-{j+1}: Coord ({x1}, {y1}) & Coord ({x2}, {y2}) with distance: {minDistance}");
                        }
                    }

                }
            }
            Console.WriteLine($"The points with the minimum distance between them are: ({x1}, {y1}) & ({x2}, {y2}) with distance: {minDistance}");
        }

        public static void eucDistCalc3()
        {
            double minDistance = 30000; // Math.Sqrt(3000);
            int x1 = 0, y1 = 0, z1 = 0;
            int x2 = 0, y2 = 0, z2 = 0;

            for (int i = 0; i < 999; i++)
            {
                int xCoord_1 = ThreeDimVectors.xArray[i];
                int xCoord_2 = ThreeDimVectors.xArray[i + 1];
                
                for (int j = 0; j < 999; j++)
                {
                    int yCoord_1 = ThreeDimVectors.yArray[j];
                    int yCoord_2 = ThreeDimVectors.yArray[j + 1];

                    for (int k = 0; k < 999; k++)
                    {
                        int zCoord_1 = ThreeDimVectors.zArray[k];
                        int zCoord_2 = ThreeDimVectors.zArray[k + 1];
                        

                        double eucDistance;
                        eucDistance = Math.Sqrt(Math.Pow((xCoord_1 - xCoord_2), 2) + Math.Pow((yCoord_1 - yCoord_2), 2) + Math.Pow((zCoord_1 - zCoord_2), 2));

                        if (i != 0 && i == j && i == k)
                        {
                            //Console.WriteLine("Coordinates are the same; not checked.");
                            break;
                        }
                        else if ((i == 0 && j == 0 && k == 0) || (eucDistance < minDistance))
                        {
                            minDistance = eucDistance;
                            x1 = xCoord_1;
                            y1 = yCoord_1;
                            x2 = xCoord_2;
                            y2 = yCoord_2;
                            z1 = zCoord_1;
                            z2 = zCoord_2;

                            Console.WriteLine($"The points with the minimum distance between them are element {i}-{j}-{k} and element {i+1}-{j+1}-{k+1} \nCoord({x1} {y1} {z1}) & Coord ({x2}, {y2}, {z2}) with distance: {minDistance}");
                        }
                    }

                }
            }
            Console.WriteLine($"The points with the minimum distance between them are: ({x1}, {y1}, {z1}) & ({x2}, {y2}, {z2}) with distance: {minDistance}");
        }
    }
}

