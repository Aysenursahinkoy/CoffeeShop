using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeatures;


    namespace CoffeeShop.CoffeTypes
    {
        public class FiltreCoffee : Coffee, IHot, IsMilked
        {
            public FiltreCoffee(int id, string Name, int Price, bool IsHot, bool IsMilked)
            {
                this.Id = id;
                this.Name = Name;
                this.Price = Price;
                this.IsHot = IsHot;
                this.IsMilked = IsMilked;

            }

            public bool IsHot { get; set; }
            public bool Milked { get; set; }
            public bool IsMilked { get; set; }

            public string CoffeeHotText() => this.IsHot ? "Sıcak" : "Soğuk";

            public void CoffeMakeHot(bool IsHot)
            {
                this.IsHot = IsHot;
                Price = IsHot ? Price + 2 : Price;
            }

            public void IssMilked(bool IsMilked)
            {
                this.IsMilked = IsMilked;
            }

            public string MilkedText() => this.IsMilked ? "Sutlu" : "Sutsuz";
        }
    }