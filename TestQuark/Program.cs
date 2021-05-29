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

            Console.WriteLine("Hola " + shop.name);

            Seller seller1 = new Seller();
            seller1.SetSeller();
            Console.WriteLine("Su codigo de vendedor es: {0}", seller1.sellerCode);

            Console.WriteLine("Presione entre para comenzar un presupuesto");
            Console.ReadKey();
            
            Quote quote1 = new Quote();
            quote1.SetDate();
            Console.WriteLine(quote1.GetSellerCode(seller1.sellerCode));
            
            Wear wear = new Wear();
            wear.Price();

            Console.WriteLine("Gracias por probar esta demo!");
            Console.ReadKey();
        }
    }
}
