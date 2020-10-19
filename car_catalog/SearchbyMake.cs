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
    class SearchbyMake : ISearch
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public void Search_by_car_details()
        {
            Console.Write("Please write car Make then press enter to start search: ");
            string searchMake = Console.ReadLine();


            adapter = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isactive = '1' and Make = '" + searchMake + "'", sqlConnection);
            adapter.Fill(dt);

            foreach (DataRow Make in dt.Rows)
            {
                int index = dt.Rows.IndexOf(Make);
                index += 1;
                Console.WriteLine("Car Search No   : " + index);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Car Make : " + Make.Field<string>("Make"));
                Console.WriteLine("Car Model: " + Make.Field<string>("Model"));
                Console.WriteLine("Car Color: " + Make.Field<string>("Color"));
                Console.WriteLine("Car Year : " + Make.Field<string>("Year"));
                Console.WriteLine("Car Price: " + Make.Field<string>("Price"));
               
                Console.WriteLine("---------------------------------");
            }
            //    foreach (var make_row in Make.ItemArray)
            //    {
            //        Console.WriteLine(make_row);

            //    }
            //    Console.WriteLine("---------------------------------");
            //}



            //var filtermake = carlist.Where(m => m.Make.Contains(searchMake));

            //foreach (var make in filtermake)
            //{
            //    Console.WriteLine("Car Model is : " + make.Model +
            //                    "\nCar Make is : " + make.Make +
            //                    "\nCar Color is : " + make.Color +
            //                    "\nCar Year is : " + make.Year +
            //                    "\nCar Price is : " + make.Price);
            //    Console.WriteLine("\n--------------------------------\n");
            //}
        }
    }
}
