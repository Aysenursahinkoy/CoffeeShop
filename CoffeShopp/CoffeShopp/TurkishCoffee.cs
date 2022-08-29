using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeatures;

namespace CoffeeShop.CoffeTypes
{
	public class TurkishCoffee : Coffee, IsSugar
	{

		public TurkishCoffee(int Id, string Name, int Price, bool IsSugar)
		{
			this.Id = Id;
			this.Name = Name;
            this.Price = Price;
			this.IsSugar = IsSugar;

		}


		public bool IsSugar { get; set; }
		public void IssSugar(bool IsSugar)
		{
			this.IsSugar = IsSugar;
		}

		public string IsSugarText() => this.IsSugar ? "Sekerli" : "Sekersiz";


		

	}
}
