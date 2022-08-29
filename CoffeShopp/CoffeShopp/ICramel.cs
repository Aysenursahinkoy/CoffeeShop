using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeatures
{
    public interface ICaramel
    {
        bool IsCaramel { get; set; }
        string CaramelText();
        void IsCarammel(bool IsCaramel);
    }
}
