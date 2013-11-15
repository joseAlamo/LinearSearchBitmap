using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchBitmap
{
    class Program
    {
        static void Main(string[] args)
        {
            byte input = 8;
            string look = Convert.ToString(input, 2).PadLeft(8, '0');
            byte[] Bytes = new byte[10]
                {
                    10,3,2,3,3,8,3,3,3,3
                };
            string[] bitmap = Bytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            bool equal = false;
            foreach (string element in bitmap)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (element.Substring(i, 1) == look.Substring(i, 1))
                        equal = true;
                    else
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                    Console.WriteLine("Match found");
            }
            Console.ReadKey();
        }
    }
}
