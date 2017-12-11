using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPImpementationSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            double coommon=0;
            string pathReadG = @"E:\c#\progressionG.txt";
            string pathReadA = @"E:\c#\progressionA.txt";

            string pathWrite = @"E:\c#\newprogression.txt";

            MakeMathAction mathAction =new MakeMathAction(pathReadG);
            if (mathAction.IsGeometricProgression(mathAction.itemList.ToArray(),ref coommon))
            {
              double sumGP=  mathAction.GeometricProgressions(mathAction.itemList.First(), coommon, mathAction.itemList.Count);
                Console.WriteLine(sumGP);
                sumGP.WriteInFileOneItem(pathWrite);
            }
            MakeMathAction mathAction1 = new MakeMathAction(pathReadA);

            if (mathAction1.IsaArithmeticProgression(mathAction1.itemList.ToArray(),ref coommon))
            {
                double sumAP = mathAction1.arithmeticProgression(mathAction1.itemList.First(), mathAction1.itemList.Last(),
                    mathAction1.itemList.Count);
                Console.WriteLine(sumAP);
                sumAP.WriteInFileOneItem(pathWrite);
            }
        }
    }
}
