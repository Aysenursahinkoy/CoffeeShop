using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeatures
{
	public interface IsMilked
	{
		public bool IsMilked { get; set; }
		string MilkedText();
		void IssMilked(bool IsMilked);
	}
}

