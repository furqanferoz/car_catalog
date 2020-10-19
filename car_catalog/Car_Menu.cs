using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace car_catalog
{
    public class Car_Menu
    {
        
        //Car car = new Car();

        //Searchcar searchcar = new Searchcar();
        //Show_Car Show_Car = new Show_Car();
        //public string input { get; set; }


        public void Car_menu_list()
        {
            string input;
            List<Car> carlist = new List<Car>();
            Show_Car Show_Car = new Show_Car();
            Searchcar searchcar = new Searchcar();
            //string connection = ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString;
            Add_Car add_Car = new Add_Car();
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Welcome to Car Main Menu!");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Select 1 to add new car." + "\n" + "Select 2 to show up all cars."
                                  + "\n" + "Select 3 to search." + "\n" + "Select 4 to close the program.");
                Console.WriteLine("---------------------------");
                Console.Write("Please select the Option!");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Car car = new Car();
                        //var addcar = 
                        add_Car.AddCar(car);
                        //carlist.Add(new Car(addcar.Color, addcar.Make, addcar.Model, addcar.Price, addcar.Year));
                        break;
                    case "2":
                        Console.Clear();
                        Show_Car.Search_by_car_details();
                        break;
                    case "3":
                        Console.Clear();
                        searchcar.car_search();
                        break;
                    case "4":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I'm sorry. We could not find.");
                        break;

                }

            } while (input != "4");

        }
    }
}
