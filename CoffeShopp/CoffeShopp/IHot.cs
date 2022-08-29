using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeatures
{
	public interface IHot
	{
		bool IsHot { get; set; }

		void CoffeMakeHot(bool isHot);

		string CoffeeHotText();

	}
}

