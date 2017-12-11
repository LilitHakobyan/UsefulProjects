using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPImpementationSimple
{
   public static class FileExtensions
    {
        public static void ReadFormFile(this List<double> arr, string path)
        {
            try
            {
                
                using (StreamReader sr=File.OpenText(path))
                {
                    string text = sr.ReadToEnd();
                    string[] arrTextSplit = text.Split();
                    for (int i = 0; i < arrTextSplit.Length; i++)
                    {
                        arr.Add(Double.Parse(arrTextSplit[i]));
                    }
                    
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }

        public static void WriteInFile(this List<double> arrList, string path)
        {
            try
            {
                using (StreamWriter sw=File.AppendText(path))
                {
                    foreach (double item in arrList)
                    {
                        sw.Write(item);
                        sw.Write(" ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
            
    }
}
