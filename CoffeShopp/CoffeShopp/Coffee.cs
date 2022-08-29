using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeTypes
{
    public abstract class Coffee
    {

        public Coffee()
        {

        }

        public Coffee(int Id, string Name, decimal Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

       

    }

}