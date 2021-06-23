using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipping airShipping = new Shipping();

            airShipping.OrderAirShipping("America", 15);

            airShipping.Ship();

            Shipping landShipping = new Shipping();

            landShipping.OrderLandShipping("France", 10);

            landShipping.Ship();



            Singleton singleton = Singleton.getInstance();

            singleton.Print("\nHi.\n");


            Apple apple = new Apple();
            Shop shop1 = new Shop(apple);

            shop1.PrintLaptopDetails();
            shop1.PrintPhoneDetails();

            Samsung samsung = new Samsung();
            Shop shop2 = new Shop(samsung);

            shop2.PrintLaptopDetails();
            shop2.PrintPhoneDetails();



            MacbookBuilder builder = new MacbookBuilder();
            Director director = new Director();
            director.MakeMacbookAir(builder);

            Macbook macbookAir = builder.getResult();
            Console.WriteLine("\n" + macbookAir);



            Rectangle rectangle = new Rectangle(10, 20, 500, 800);
            Rectangle rectangle1 = rectangle.Clone() as Rectangle;
            Console.WriteLine("\nx: " + rectangle1.X + ", y: " + rectangle1.Y + ", width: " + rectangle1.Width + ", height: " + rectangle1.Height);

            Console.ReadKey();
        }
    }
}
