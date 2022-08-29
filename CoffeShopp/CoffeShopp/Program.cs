using System;
using CoffeeShop;
using CoffeeShop.CoffeTypes;


public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Adınız : ");
        string? name = Console.ReadLine();
        string? crema;
        string? milk;
        string? caramel;
        string? hot;
        string? sugar;
        Console.WriteLine("***************************");
        Console.WriteLine(name.ToUpper()+" COFFEE SHOP'a Hosgeldiniz :)");
        Console.WriteLine("***************************");

        Console.WriteLine("Kahve Fiyat Listesi :\n" +
            "(1)Latte : 40\n(2)Mocha : 40\n(3)Filtre Kahve : 30 \n(4)Türk Kahvesi : 25\n");

        

        Console.WriteLine("Hangi kahveyi almak istersiniz(1,2,3,4) \n" );

        string? sec = Console.ReadLine(); 
        Console.WriteLine("****************************");
        Console.WriteLine("Ekstralar : \n\n" +
            "Ekstra Sıcak :2\nEkstra Seker : 2\nEkstra Karamel : 3\nEkstra Krema : 3\nEkstra Süt : 5\n");
        Latte latte = new(1, "Latte", 40, true, true, true);
        Mocha mocha = new(2, "Mocha", 40, false, false, false);
        TurkishCoffee turkishCoffee = new(4, "Turkish Coffee ", 25, false);
        FiltreCoffee filtreCoffee = new(3, "Filtred Coffee", 30, false, false);

        if (sec == "1")
        {
            extraLatte();

        }
        else if (sec == "2")
        {
            extraMocha();
        }
        else if (sec == "3")
        {
            extraFiltred();

        }
        else if (sec == "4")
        {
            extraTurkish();

        }
        else
        {
            Console.WriteLine("Hatali secim :)");
        }

        void extraLatte()
        {
            extraHot();
            extraMilk();
            extraCaramel();
            Console.WriteLine("***********************");
            Console.WriteLine(name + " Kahveniz hazır  :)");
            Console.WriteLine("kahveniz " + hot + " " + milk + " " + caramel + " \nOdenecek tutar=  : " + latte.Price);


        }
        void extraHot()
        {
            Console.WriteLine("Kahveniz sıcak mı olsun?");

            Console.WriteLine("(1)Yes \n(2)No");
            string? isHot = Console.ReadLine();

            latte.CoffeMakeHot(isHot == "1");
            mocha.CoffeMakeHot(isHot == "1");
            filtreCoffee.CoffeMakeHot(isHot == "1");

            if (isHot == "1")
            {
                latte.Price += 2;
                mocha.Price += 2;
                filtreCoffee.Price += 2;

                hot = "sıcak";
            }
            else
            {
                hot = "soguk";
            }
        }
        void extraMocha()
        {
            extraHot();
            extraMilk();
            extraCrema();
            
            Console.WriteLine("***********************");
            Console.WriteLine(name + " Kahveniz hazır   :)");
            Console.WriteLine("kahveniz "+hot+" "+milk+" "+crema+" \nOdenecek tutar=  : " + mocha.Price);
        }
        void extraTurkish()
        {
            extraSugar();
            Console.WriteLine("***********************");
            Console.WriteLine(name + " Kahveniz hazır   :)");
            Console.WriteLine("kahveniz " + sugar + " \nodenecek tutar : " + turkishCoffee.Price);

        }
        void extraFiltred()
        {
            extraHot();
            extraMilk();
           
            Console.WriteLine("***********************");
            Console.WriteLine(name + " Kahveniz hazır   :)");
            Console.WriteLine("kahveniz " + hot + " " + milk + " \nodenecek tutar= : " + filtreCoffee.Price);
        }
        void extraCaramel()
        {
            Console.WriteLine("Kahvenizde karamel aroması ister misiniz?");

            Console.WriteLine("(1)Yes\n(2)No  ");
            string? IsCaramel = Console.ReadLine();
            latte.IsCarammel(IsCaramel == "1");

            if (IsCaramel == "2")
            {
                latte.Price += 3;
                caramel = "karamelli";
            }
            else
            {
                caramel = "karamelsiz";
            }
            
        }
        void extraMilk()
        {
            Console.WriteLine("kahvenizde süt ister misiniz?");
            Console.WriteLine("(1)Yes \n(2)No");
            string? Milked = Console.ReadLine();
            latte.IssMilked(Milked == "1");
            mocha.IssMilked(Milked == "1");
            filtreCoffee.IssMilked(Milked == "1");


            if (Milked == "1")
            {
                latte.Price += 5;
                mocha.Price += 5;
                filtreCoffee.Price += 5;
                milk = "sütlü";
            }
            else
            {
                milk = "sütsüz";
            }
        }
        void extraSugar()
        {
            Console.WriteLine("Kahvenizde seker ister misiniz? ");
            Console.WriteLine("(1)Yes\n(2)No");
            string? Sugar = Console.ReadLine();
            turkishCoffee.IssSugar(Sugar == "1");
           
            if (Sugar == "1")
            {
                turkishCoffee.Price += 2;

                sugar = "sekerli";
            }
            
            else
            {
                sugar = "sekersiz";
            }
            
        }
        void extraCrema()
        {
           
            Console.WriteLine("kahvenizde krema ister misiniz?");
            Console.WriteLine("(1)Yes\n(2)No");
            string? MochaIsCreamed = Console.ReadLine();
            mocha.IsCreammm(MochaIsCreamed == "1");

            if (MochaIsCreamed == "1")
            {
                mocha.Price += 3;
                crema = "kremali";
            }
            else
            {
                crema = "kremasiz";
            }
           
        }
    }

       
    
}
