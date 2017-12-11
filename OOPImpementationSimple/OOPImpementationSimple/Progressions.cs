using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPImpementationSimple
{
   abstract class Progressions
    {
        public virtual double arithmeticProgression(double first_term, double last_term, int count)
        {
            return (first_term + last_term) * count / 2;
        }

       public abstract double GeometricProgressions(double first_term, double common_ratio,int count);

        public virtual bool IsaArithmeticProgression(double[] arr, ref double div)
        {
            double k = arr[1] - arr[0];
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i + 1] - arr[i] != k)
                    return false;
            }
            div = k;
            return true;
        }
        public virtual bool IsGeometricProgression(double[] arr,ref double div)
        {
            double k = arr[1] /arr[0];
            if (k == 1) return false;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                    return false;
                if (arr[i + 1] / arr[i] != k)
                    return false;
            }
            div = k;
            return true;
        }
    }
}
