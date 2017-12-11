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
            MakeMathAction mathAction =new MakeMathAction(@"E:\c#\progression.txt");
            if (mathAction.IsGeometricProgression(mathAction.itemList.ToArray(),ref coommon))
            {
              double sumGP=  mathAction.GeometricProgressions(mathAction.itemList.First(), coommon, mathAction.itemList.Count);
                Console.WriteLine(sumGP);
            }
            if (mathAction.IsaArithmeticProgression(mathAction.itemList.ToArray(),ref coommon))
            {
                double sumAP = mathAction.arithmeticProgression(mathAction.itemList.First(), mathAction.itemList.Last(),
                    mathAction.itemList.Count);
                Console.WriteLine(sumAP);
            }
        }
    }
}
