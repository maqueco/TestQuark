using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    public class Seller
    {
        public string name;
        public string username;
        public int sellerCode;
        public int[] sellerStory;
        
        public void SetSeller()
        {
            Console.WriteLine("Ingrese su nombre");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            username = Console.ReadLine();
        }

        public int GenCode()
        {
            sellerCode = 02;
            return sellerCode;
        }
    }
}
