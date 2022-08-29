using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeatures;


namespace CoffeeShop.CoffeTypes
{
    public class Latte : Coffee, IHot, ICaramel, IsMilked
    {
        private bool v1;
        private bool v2;
        private bool v3;

        public Latte(int Id, string Name, decimal Price, bool v1, bool v2, bool v3) : base(Id, Name, Price)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Latte(int Id, string Name, int Price, bool IsHot, bool IsCaramel, bool IsMilked)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.IsHot = IsHot;
            this.IsCaramel = IsCaramel;
            this.IsMilked = IsMilked;

        }

        public bool IsHot { get; set; }
        public bool IsCaramel { get; set; }
        public bool IsMilked { get; set; }

        public void CoffeMakeHot(bool isHot)
        {
            this.IsHot = isHot;
        }

        public void IsCarammel(bool IsCaramel)
        {
            this.IsCaramel = IsCaramel;
        }

        public void IssMilked(bool IsMilked)
        {
            this.IsMilked = IsMilked;
        }
        public string CaramelText() => this.IsCaramel ? "Karamelli" : "Karamelsiz";

        public string MilkedText() => this.IsMilked ? "Sutlu" : "Sutsuz";

        public string CoffeeHotText() => this.IsHot ? "Sıcak" : "Soğuk";

    }

}
