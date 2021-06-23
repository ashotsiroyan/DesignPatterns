using System;

namespace DesignPatterns
{
    interface ICompany
    {
        IPhone Phone { get; }
        ILaptop Laptop { get; }
    }

    interface IPhone
    {
        string getDetails();
    }

    interface ILaptop
    {
        string getDetails();
    }

    class Apple : ICompany
    {
        private IPhone phone;
        private ILaptop laptop;

        public Apple()
        {
            phone = new ApplePhone();
            laptop = new AppleLaptop();
        }

        public IPhone Phone
        {
            get { return phone; }
        }

        public ILaptop Laptop
        {
            get { return laptop; }
        }
    }

    class Samsung : ICompany
    {
        private IPhone phone;
        private ILaptop laptop;

        public Samsung()
        {
            phone = new SamsungPhone();
            laptop = new SamsungLaptop();
        }

        public IPhone Phone
        {
            get { return phone; }
        }

        public ILaptop Laptop
        {
            get { return laptop; }
        }
    }

    class ApplePhone: IPhone
    {
        public string getDetails()
        {
            return "IPhone 12 PRO, 128GB";
        }
    }

    class SamsungPhone : IPhone
    {
        public string getDetails()
        {
            return "Galaxy S20, 128GB";
        }
    }

    class AppleLaptop : ILaptop
    {
        public string getDetails()
        {
            return "MacBook PRO, 1TB";
        }
    }

    class SamsungLaptop : ILaptop
    {
        public string getDetails()
        {
            return "Samsung laptop, 500GB";
        }
    }

    class Shop
    {
        ICompany company;

        public Shop(ICompany company)
        {
            this.company = company;
        }

        public void PrintPhoneDetails()
        {
            Console.WriteLine(company.Phone.getDetails());
        }

        public void PrintLaptopDetails()
        {
            Console.WriteLine(company.Laptop.getDetails());
        }
    }
}