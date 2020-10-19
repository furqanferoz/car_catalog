using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_catalog
{
    class Searchcar : Car_Menu
    {
        public void car_search()
        {
            string searchSelection;
            do
            {
                Console.WriteLine("################################");
                Console.WriteLine("      Search Car Menu!          ");
                Console.WriteLine("################################");
                Console.WriteLine("Select 1 to search by cars Make.   " + "\n" +
                                  "Select 2 to search by cars Model.  " + "\n" +
                                  "Select 3 to search by cars Color.  " + "\n" +
                                  "Select 4 to search by cars Year.   " + "\n" +
                                  "Select 5 to search by cars Price.  " + "\n" +
                                  "Press any key to back.");
                Console.WriteLine("################################");

                searchSelection = (Console.ReadLine());


                switch (searchSelection)
                {
                    case "1":
                        Console.Clear();
                        SearchbyMake searchbyMake = new SearchbyMake();
                        searchbyMake.Search_by_car_details();
                        break;
                    case "2":
                        Console.Clear();
                        SearchbyModel searchbyModel = new SearchbyModel();
                        searchbyModel.Search_by_car_details();
                        break;
                    case "3":
                        Console.Clear();
                        SearchbyColor searchbyColor = new SearchbyColor();
                        searchbyColor.Search_by_car_details();
                        break;
                    case "4":
                        Console.Clear();
                        SearchbyYear searchbyYear = new SearchbyYear();
                        searchbyYear.Search_by_car_details();
                        break;
                    case "5":
                        Console.Clear();
                        SearchbyPrice searchbyPrice = new SearchbyPrice();
                        searchbyPrice.Search_by_car_details();
                        break;
                    default:
                        Console.Clear();
                        Car_Menu car_Menu = new Car_Menu();
                        car_Menu.Car_menu_list();
                        break;
                }
            }
            while (searchSelection != "6");
        }
    }
}
