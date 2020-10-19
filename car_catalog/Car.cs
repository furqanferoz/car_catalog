using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_catalog
{ 
    public class Car
    {
        string make, model, color;
        int year, price;

        public string Make { get;  set; }

        public string Model { get;  set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public Car(string make, string model, string color, int year, int price)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
        }

        public Car()
        {
            make = "undefine";
            model = "undefine";
            color = "undefine";
            year = 0;
            price = 0;
        }

    }
}
