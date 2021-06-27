using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------------  Factory Method  --------------------------------*/
            Shipping airShipping = new Shipping();

            airShipping.OrderAirShipping("America", 15);

            airShipping.Ship();

            Shipping landShipping = new Shipping();

            landShipping.OrderLandShipping("France", 10);

            landShipping.Ship();



            /*--------------------------------  Singleton  --------------------------------*/
            Singleton singleton = Singleton.getInstance();

            singleton.Print("\nHi.\n");



            /*--------------------------------  Abstract Factory  --------------------------------*/
            Apple apple = new Apple();
            Shop shop1 = new Shop(apple);

            shop1.PrintLaptopDetails();
            shop1.PrintPhoneDetails();

            Samsung samsung = new Samsung();
            Shop shop2 = new Shop(samsung);

            shop2.PrintLaptopDetails();
            shop2.PrintPhoneDetails();



            /*--------------------------------  Builder  --------------------------------*/
            MacbookBuilder builder = new MacbookBuilder();
            Director director = new Director();
            director.MakeMacbookAir(builder);

            Macbook macbookAir = builder.getResult();
            Console.WriteLine("\n" + macbookAir);



            /*--------------------------------  Prototype  --------------------------------*/
            Rectangle rectangle = new Rectangle(10, 20, 500, 800);
            Rectangle rectangle1 = rectangle.Clone() as Rectangle;
            Console.WriteLine("\nx: " + rectangle1.X + ", y: " + rectangle1.Y + ", width: " + rectangle1.Width + ", height: " + rectangle1.Height);



            /*--------------------------------  Adapter  --------------------------------*/
            Console2 con = new Console2();
            con.Write("WTF!");



            /*--------------------------------  Bridge  --------------------------------*/
            Tv tv = new Tv();
            RemoteControl control = new RemoteControl(tv);
            control.TogglePower().ChannelUp().VolumeUp();



            /*--------------------------------  Composite  --------------------------------*/
            Dot d1 = new Dot(5, 15);
            Dot d2 = new Dot(10, 11);
            Dot d3 = new Dot(2, 5);
            Dot d4 = new Dot(17, 81);
            Dot d5 = new Dot(78, 23);
            Dot d6 = new Dot(5, 85);
            Dot d7 = new Dot(-5, -45);
            Dot d8 = new Dot(45, -89);
            Dot d9 = new Dot(7, 15);

            ComponentGraphic c1 = new ComponentGraphic();
            ComponentGraphic c2 = new ComponentGraphic();
            ComponentGraphic c3 = new ComponentGraphic();

            c3.Add(d9);
            c3.Add(d8);
            c3.Add(d7);
            c3.Add(d6);

            c2.Add(d5);
            c2.Add(d4);
            c2.Add(c3);

            c1.Add(d3);
            c1.Add(d2);
            c1.Add(d1);
            c1.Add(c2);

            c1.Draw();

            c2.Move(4, 56);

            c1.Draw();



            /*--------------------------------  Decorator  --------------------------------*/
            INotifier notifier = new SMSNotifier();
            notifier = new WarningDecorator(notifier);
            notifier = new ErrorDecorator(notifier);
            Console.WriteLine();
            notifier.Send("Something went wrong!");


            Console.ReadKey();
        }
    }
}
