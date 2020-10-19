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
    class SearchbyPrice : ISearch
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public void Search_by_car_details()
        {
            Console.WriteLine("Please write car Price then press enter to start search: ");
            int searchprice = int.Parse(Console.ReadLine());

            adapter = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isactive = '1' and Price = '" + searchprice + "'", sqlConnection);
            adapter.Fill(dt);

            foreach (DataRow Price in dt.Rows)
            {
                int index = dt.Rows.IndexOf(Price);
                index += 1;
                Console.WriteLine("Car Search No   : " + index);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Car Make : " + Price.Field<string>("Make"));
                Console.WriteLine("Car Model: " + Price.Field<string>("Model"));
                Console.WriteLine("Car Color: " + Price.Field<string>("Color"));
                Console.WriteLine("Car Year : " + Price.Field<string>("Year"));
                Console.WriteLine("Car Price: " + Price.Field<string>("Price"));

                //foreach (var price_row in Price.ItemArray)
                //{
                //    Console.WriteLine(price_row);

                //}
                Console.WriteLine("---------------------------------");
                
            }



            //var filterprice = carlist.Where(p => p.Price.Equals(searchprice));
            //foreach (var make in filterprice)
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
