using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        // Default constructor
        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0m;
        }

        // Constructor with Id only
        public Car(int id) : this()
        {
            Id = id;
        }

        // Constructor with Id and Brand
        public Car(int id, string brand) : this(id)
        {
            Brand = brand;
        }

        // Constructor with all parameters
        public Car(int id, string brand, decimal price) : this(id, brand)
        {
            Price = price;
        }

        public override string ToString()
        {
            return $"Car(Id={Id}, Brand={Brand}, Price={Price:C})";
        }
    }
}
