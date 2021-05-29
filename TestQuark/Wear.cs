using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    public class Wear
    {
        public string quality;
        public float price;
        public int stock;

        public string SetQuality()
        {
            Console.Write("Ingrese la calidad del producto (standar/premium)");
            string grade = Console.ReadLine();
            if (grade == "standar")
            {
                quality = grade;
            } else if (grade == "premium"){
                quality = grade;
            } else
            {
                Console.Write("Error");
            }
            return quality;
        }

        public void Price()
        {
            Console.WriteLine("Ingrese el costo de la prenda: ");
            price = float.Parse(Console.ReadLine());
        }
        public void Stock()
        {
            string wear;
            Console.WriteLine("Ingrese la prenda a consultar en stock");
            wear = Console.ReadLine();
            Console.WriteLine("La cantidad en stock es: ");
        }
    }
}
