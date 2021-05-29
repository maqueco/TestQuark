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
            Console.WriteLine("Bienvenido");
            Console.Write("Presione enter para continuar");
            Console.ReadKey();
            Shop shop = new Shop();
            shop.SetShopInfo();

            Console.ReadKey();

            Seller seller1 = new Seller();
            seller1.SetSeller();
            seller1.sellerCode = 02;
            Console.WriteLine("Seller Code: {0}", seller1.sellerCode);
            Quote quote1 = new Quote();
            quote1.SetDate();
            Console.WriteLine(quote1.GetSellerCode(seller1.sellerCode));
            Console.ReadKey();
        }
    }
}
