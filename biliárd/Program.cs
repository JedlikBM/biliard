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
            int leeső = Leesősorsoló(golyók);
            Kiíró(golyók);
            
            Console.ReadKey();
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int elem in golyók) Console.Write($"{elem} ");
        }

        static int Leesősorsoló(List<int> golyók)
        {
            Random gép = new Random();
            int leesett = gép.Next(golyók.Count);
            golyók.Remove(leesett);
            return golyók[leesett];
        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
