using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPImpementationSimple
{
    class MakeMathAction:Progressions,IDisposable
    {
        public  string filePath { get; set; }
        public List<double> itemList=new List<double>();

        public MakeMathAction(string path)
        {
            filePath = path;
            itemList.ReadFormFile(filePath);
        }
        
      
        
        public override double GeometricProgressions(double first_term, double common_ratio,int count)
        {
            return first_term * (Math.Pow(common_ratio, count) - 1) / (common_ratio - 1);
        }

        public void Dispose()
        {
            
        }
    }
}
