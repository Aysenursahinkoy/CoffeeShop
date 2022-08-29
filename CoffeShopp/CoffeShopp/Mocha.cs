using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeatures;



namespace CoffeeShop.CoffeTypes
{
	public class Mocha : Coffee, ICreamed, IHot, IsMilked
	{
        private int v1;
        private int v2;
        private bool v3;
        private bool v4;
        private bool v5;

        public Mocha(int v1, int v2, bool v3, bool v4, bool v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public Mocha(int Id, string Name, int Price, bool IsCreamed, bool IsHot, bool IsMilked)
		{
			this.Id = Id;
			this.Name = Name;
            this.Price = Price;
            this.IsCreamed = IsCreamed;
            this.IsHot = IsHot;
			this.IsMilked = IsMilked;
		}

		public bool IsCreamed { get; set; }
		public bool IsHot { get; set; }
		public bool IsMilked { get; set; }

		
		public void CoffeMakeHot(bool isHot) => this.IsHot = isHot;

        public void IsCream(bool IsCream)
        {
            this.IsCreamed = IsCreamed;
        }

        public void IsCreammm(bool IsCream) => this.IsCreamed = IsCream;

		public void IssMilked(bool IsMilked)
		{
			this.IsMilked = IsMilked;
		}

		public string MilkedText() => this.IsMilked ? "Sutlu" : "Sutsuz";
        public string CreameText() => this.IsCreamed ? "Kremalı " : "Kremasız";
        public string CoffeeHotText() => this.IsHot ? "Sıcak" : "Soğuk";


    }
}