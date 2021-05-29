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
        public Quote[] sellerStory;

        public void SetSeller()
        {
            Console.Write("Ingrese su nombre: ");
            name = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            username = Console.ReadLine();
            Console.WriteLine("Is a Seller: " + name + " " + username);
        }

        public Quote[] quote()
        {
            Quote quote = new Quote();
            sellerStory = new Quote[20];
            for (int i = 0; i <  sellerStory.Length ; i++)
            {
                sellerStory[i] = quote;
            }            
            return sellerStory;
        }
    }
}
