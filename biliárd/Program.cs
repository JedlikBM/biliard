using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biliárd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            foreach (int elem in golyók)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i < 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
