using System;

namespace RoadGraph
{
    class Program
    {
        static bool newRoadSystem(bool[][] roadRegister)
        {
            int counti = 0, countj = 0;
            for (int i = 0; i < roadRegister.Length; i++)
            {
                for (int j = 0; j < roadRegister.Length; j++)
                {
                    if (roadRegister[i][j])
                    {
                        counti++;
                    }

                    if (roadRegister[j][i])
                    {
                        countj++;
                    }
                }
                if (counti != countj)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            bool[][] roadRegister =
            {
                new bool [] {false, true,  false, false},
                new bool [] {false, false, true,  false},
                new bool [] {true,  false, false, true},
                new bool [] { false, false, true, false }
            };

            bool result = newRoadSystem(roadRegister);
            Console.WriteLine(result);

        }
    }
}
