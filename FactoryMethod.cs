using System;

namespace DesignPatterns
{
    public interface IShipping
    {
        int Price { get; }
        string Destination { get; }
        int Length { get; }
        void Ship();
    }

    public class AirShipping : IShipping
    {
        private int price = 15;
        private int length;
        private string destination;

        public AirShipping(string destination, int length)
        {
            this.destination = destination;
            this.length = length;
        }

        public void Ship()
        {
            Console.WriteLine("Air shipping to " + destination + ". Price: " + Price);
        }

        public string Destination { get { return destination; } }
        public int Price { get { return price * length; } }
        public int Length { get { return length; } }
    }

    public class LandShipping : IShipping
    {
        private int price = 5;
        private int length;
        private string destination;

        public LandShipping(string destination, int length)
        {
            this.destination = destination;
            this.length = length;
        }

        public void Ship()
        {
            Console.WriteLine("Land shipping to " + destination + ". Price: " + Price);
        }

        public string Destination { get { return destination; } }
        public int Price { get { return price * length; } }
        public int Length { get { return length; } }
    }

    public class Shipping{
        private IShipping shippingType;

        public void OrderAirShipping(string destination, int length)
        {
            shippingType = new AirShipping(destination, length);
        }
        public void OrderLandShipping(string destination, int length)
        {
            shippingType = new LandShipping(destination, length);
        }

        public void Ship()
        {
            shippingType.Ship();
        }
    }
}
