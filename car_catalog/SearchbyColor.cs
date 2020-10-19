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
    class SearchbyColor : ISearch
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public void Search_by_car_details()
        {
            Console.WriteLine("Please write car Color then press enter to start search: ");
            string searchColor = Console.ReadLine();


            adapter = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isactive = '1' and Color = '" + searchColor + "'", sqlConnection);
            adapter.Fill(dt);

            foreach (DataRow color in dt.Rows)
            {
                int index = dt.Rows.IndexOf(color);
                index += 1;
                Console.WriteLine("Car Search No   : " + index);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Car Make : " + color.Field<string>("Make"));
                Console.WriteLine("Car Model: " + color.Field<string>("Model"));
                Console.WriteLine("Car Color: " + color.Field<string>("Color"));
                Console.WriteLine("Car Year : " + color.Field<string>("Year"));
                Console.WriteLine("Car Price: " + color.Field<string>("Price"));
                
                Console.WriteLine("---------------------------------");

                //foreach(var color_row in color.ItemArray)
                //{
                //    Console.WriteLine(color_row);

                //}
                Console.WriteLine("---------------------------------");
            }









            //var filtercolor = carlist.Where(c => c.Color.Contains(searchColor));

            //foreach (var color in filtercolor)
            //{
            //    Console.WriteLine("Car Model is : " + color.Model + "\n" +
            //                      "Car Make is : " + color.Make + "\n" +
            //                      "Car Color is : " + color.Color + "\n" +
            //                      "Car Year is : " + color.Year + "\n" +
            //                      "Car Price is : " + color.Price);
            //    Console.WriteLine("\n--------------------------------\n");
            //}
        }
    }
}
