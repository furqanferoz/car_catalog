using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_catalog
{
    class SearchbyYear : ISearch
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();


        public void Search_by_car_details()
        {
            Console.WriteLine("Please write car Year then press enter to start search: ");
            int searchyear = int.Parse(Console.ReadLine());

            adapter = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isactive = '1' and Year = '" + searchyear + "'", sqlConnection);
            adapter.Fill(dt);

            foreach (DataRow Year in dt.Rows)
            {
                int index = dt.Rows.IndexOf(Year);
                index += 1;
                Console.WriteLine("Car Search No   : " + index);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Car Make : " + Year.Field<string>("Make"));
                Console.WriteLine("Car Model: " + Year.Field<string>("Model"));
                Console.WriteLine("Car Color: " + Year.Field<string>("Color"));
                Console.WriteLine("Car Year : " + Year.Field<string>("Year"));
                Console.WriteLine("Car Price: " + Year.Field<string>("Price"));

                //foreach (var price_row in Price.ItemArray)
                //{
                //    Console.WriteLine(price_row);

                //}
                Console.WriteLine("---------------------------------");
            }
        }

        //public void SearchCarsyear(List<Car> carlist)
        //{


        //    //var filteryear = carlist.Where(y => y.Year.Equals(searchyear));
        //    //foreach (var make in filteryear)
        //    //{
        //    //    Console.WriteLine("Car Model is : " + make.Model +
        //    //                    "\nCar Make is : " + make.Make +
        //    //                    "\nCar Color is : " + make.Color +
        //    //                    "\nCar Year is : " + make.Year +
        //    //                    "\nCar Price is : " + make.Price);
        //    //    Console.WriteLine("\n--------------------------------\n");
        //    //}
        //}
    }
}
