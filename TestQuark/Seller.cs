using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    class Seller
    {
        public string name;
        public string username;
        public int sellerCode;
        public int[] sellerStory;

        public void SetSeller()
        {
            Console.Write("Ingrese su nombre: ");
            name = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            username = Console.ReadLine();
            Console.WriteLine("Is a Seller: " + name + " " + username);
        }
    }
}
