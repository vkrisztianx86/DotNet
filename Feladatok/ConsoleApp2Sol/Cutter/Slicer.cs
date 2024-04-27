using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutter
{
    public class Slicer
    {
        // field
        int size;
        string s;
        string[] parts;

        // property

        public bool Success { get; set; }
        public void outputter()
        {
            if (Success)
            {
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
            }
            
        }
        public bool datarequest()
        {
            inputter(out s, out size);
            parts = sizer(size, s);
            slicer(parts, size, s); 
            Success = true;
            return true;
        }
        
        private void inputter(out string sp, out int sizep)
        {
            Console.WriteLine("Kérem a szöveget!");
            sp = Console.ReadLine();
            Console.WriteLine("Kérem a darabolási méretet!");
            while (!int.TryParse(Console.ReadLine(), out sizep))
            {
                Console.WriteLine("Számot kell írni!");
            }
        }
        private string[] sizer(int sizeP, string sP)
        {
            string[] parts2;
            if (sP.Length % sizeP == 0)
            {
                parts2 = new string[sP.Length / sizeP];
            }
            else
            {
                parts2 = new string[sP.Length / sizeP + 1];
            }

            return parts2;
        }
        private void slicer(string[] partsp, int sizep, string sp)
        {
            int counter = 0;
            while (sp.Length > 0)
            {
                if (sp.Length <= sizep)
                {
                    partsp[counter] = sp;
                    sp = String.Empty;
                }
                else
                {
                    partsp[counter] = sp.Substring(0, sizep);
                    //Console.WriteLine(sp);
                    sp = sp.Substring(sizep);
                    //Console.WriteLine(sp);
                }
                counter++;
            }
        }
    }
}
