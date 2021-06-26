using System;

namespace DesignPatterns
{
    public interface IAdapter
    {
        void Write(string text);
    }

    public class Console2: IAdapter
    {
        public void Write(string text = "")
        {
            Console.Write("\n" + text + "\n");
        }
    }
}
