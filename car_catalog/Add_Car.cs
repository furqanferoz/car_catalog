using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace car_catalog
{
    public class Add_Car
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        public Add_Car()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoMobile"].ConnectionString);
        }  
        
        public void AddCar(Car car)
        {
            
            Console.Write("Enter Car Make: ");
            car.Make = Console.ReadLine();

            Console.Write("Enter Car Model: ");
            car.Model = Console.ReadLine();

            Console.Write("Enter Car Color: ");
            car.Color = Console.ReadLine();

            Console.Write("Enter Car Year: ");
            car.Year = int.Parse(Console.ReadLine());

            Console.Write("Enter Car Price: ");
            car.Price = int.Parse(Console.ReadLine());


            command = new SqlCommand("Insert into addcar(Make,Model,Color,Year,Price,isActive) Values (@make,@model,@color,@Year,@price,@isactive) ", sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@make", car.Make);
            command.Parameters.AddWithValue("@model", car.Model);
            command.Parameters.AddWithValue("@color", car.Color);
            command.Parameters.AddWithValue("@Year", car.Year);
            command.Parameters.AddWithValue("@price", car.Price);
            command.Parameters.AddWithValue("@isactive", "1");
            command.ExecuteNonQuery();
            sqlConnection.Close();

            

            Console.WriteLine("Car Make is {0}. Model is {1}. Year is {2}. Color is {3}. Price is {4}"
                , car.Make, car.Model, car.Year, car.Color, car.Price);
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n");

            
        }
    }
}
