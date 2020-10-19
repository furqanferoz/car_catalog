using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_catalog
{
    class Program//:Car_Menu
    {
       
        static void Main(string[] args)
        {
            Car_Menu car_Menu = new Car_Menu();

           
            car_Menu.Car_menu_list();
           

            Console.ReadKey();
        }
    }
}
