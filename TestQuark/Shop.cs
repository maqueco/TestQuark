using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    public class Shop
    {
        public string name;
        public string adress;
        public Wear wear;

        public void SetShopInfo()
        {
            Console.WriteLine("Introdusca el nombre de su negocio: ");
            name = Console.ReadLine();
            Console.WriteLine("Introdusca la direccion de su negocio: ");
            adress = Console.ReadLine();
        }
        /*public Wear[] WearList()
        {
            Console.WriteLine("Lista de distintas prendas: ");
            
            return ;
        }*/
    }
}
