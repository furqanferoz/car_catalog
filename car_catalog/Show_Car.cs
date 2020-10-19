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
    
    class Show_Car
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();
        public void Search_by_car_details()
        {
            Console.WriteLine("The saved cars as following:" + "\n");
            adapt = new SqlDataAdapter("Select Make, Model, Color, Year, Price from addcar where isActive = '1'", sqlConnection);
            adapt.Fill(dt);
            foreach (DataRow car_detail in dt.Rows)
            {
                Console.WriteLine("Car No   : " + dt.Rows.IndexOf(car_detail));
                Console.WriteLine("----------------------------");
                Console.WriteLine("Car Make : " + car_detail.Field<string>("Make"));
                Console.WriteLine("Car Model: " + car_detail.Field<string>("Model"));
                Console.WriteLine("Car Color: " + car_detail.Field<string>("Color"));
                Console.WriteLine("Car Year : " + car_detail.Field<string>("Year"));
                Console.WriteLine("Car Price: " + car_detail.Field<string>("Price"));

                
                
                //foreach (var item in car_detail.ItemArray)
                //{
                    
                       
                //    Console.WriteLine(item);
                //}
                //i++;
                Console.WriteLine("----------------------------");
            }



        }

    }
}
