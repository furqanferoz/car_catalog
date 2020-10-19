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
    class SearchbyModel : ISearch
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public void Search_by_car_details()
        {
            Console.WriteLine("Please write car Model then press enter to start search: ");
            string searchModel = Console.ReadLine();


            adapter = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isactive = '1' and Model = '" + searchModel + "'", sqlConnection);
            adapter.Fill(dt);

            foreach (DataRow Model in dt.Rows)
            {
                int index = dt.Rows.IndexOf(Model);
                index += 1;
                Console.WriteLine("Car Search No   : " + index);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Car Make : " + Model.Field<string>("Make"));
                Console.WriteLine("Car Model: " + Model.Field<string>("Model"));
                Console.WriteLine("Car Color: " + Model.Field<string>("Color"));
                Console.WriteLine("Car Year : " + Model.Field<string>("Year"));
                Console.WriteLine("Car Price: " + Model.Field<string>("Price"));
                //foreach (var model_row in Model.ItemArray)
                //{
                //    Console.WriteLine(model_row);

                //}
                Console.WriteLine("---------------------------------");
            }







            //var filterCollection = carlist.Where(x => x.Model.Contains(searchModel));

            //foreach (var make in filterCollection)
            //{
            //        Console.WriteLine("Car Model is : " + make.Model + "\n" +
            //                          "Car Make is : " + make.Make + "\n" +
            //                          "Car Color is : " + make.Color + "\n" +
            //                          "Car Year is : " + make.Year + "\n" +
            //                          "Car Price is : " + make.Price);
            //        Console.WriteLine("----------------------------------");

            //}
        }
    }
}
