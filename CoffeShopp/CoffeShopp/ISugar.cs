using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeatures
{
	public interface IsSugar
	{
		public bool IsSugar { get; set; }
		string IsSugarText();

		void IssSugar(bool IsSugar);
	}
}
