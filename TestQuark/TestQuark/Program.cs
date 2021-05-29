using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller seller1 = new Seller();
            seller1.SetSeller();

            Console.ReadKey();
        }
    }
}
