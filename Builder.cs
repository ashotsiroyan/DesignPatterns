using System;

namespace DesignPatterns
{
    public interface IBuilder
    {
        void Reset();
        void SetName(string name);
        void SetProcessor(string processor);
        void SetHardDrive(int gb);
        void SetSystemMemory(int gb);
        void SetScreen(string screen);
        void SetVideoCard(string videoCard);
    }

    class MacbookBuilder: IBuilder
    {
        private Macbook macbook;

        public void Reset()
        {
            macbook = new Macbook();
        }
        public void SetName(string name)
        {
            macbook.name = name;
        }

        public void SetProcessor(string processor)
        {
            macbook.processor = processor;
        }
        
        public void SetHardDrive(int gb)
        {
            macbook.hardDrive = gb;
        }
        
        public void SetSystemMemory(int gb)
        {
            macbook.systemMemory = gb;
        }
        
        public void SetScreen(string screen)
        {
            macbook.screen = screen;
        }

        public void SetVideoCard(string videoCard)
        {
            macbook.videoCard = videoCard;
        }

        public Macbook getResult()
        {
            return macbook;
        }
    }

    public class Macbook
    {
        public string name;
        public string processor;
        public int hardDrive;
        public int systemMemory;
        public string screen;
        public string videoCard;

        public override string ToString()
        {
            return name + ": " + processor + ", " + hardDrive + "GB, " + systemMemory + "GB, " + screen + ", " + videoCard;
        }
    }

    public class Director
    {
        public void MakeMacbookPro(IBuilder builder)
        {
            builder.Reset();

            builder.SetName("MacBook Pro");
            builder.SetProcessor("Intel Core i9");
            builder.SetHardDrive(1024);
            builder.SetScreen("Super Retina");
            builder.SetVideoCard("Nvidea");
            builder.SetSystemMemory(16);
        }

        public void MakeMacbookAir(IBuilder builder)
        {
            builder.Reset();

            builder.SetName("MacBook Air");
            builder.SetProcessor("Intel Core i5");
            builder.SetHardDrive(500);
            builder.SetScreen("Super Retina");
            builder.SetVideoCard("Intel HD Graphics");
            builder.SetSystemMemory(8);
        }
    }
}
