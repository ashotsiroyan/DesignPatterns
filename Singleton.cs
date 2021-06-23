using System;

namespace DesignPatterns
{
    class Singleton
    {
        private static Singleton instance;
        private static object threadObj = new object();

        private Singleton()
        {

        }

        public void Print(string text = "")
        {
            Console.WriteLine(text);
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock (threadObj)
                {
                    if(instance == null)
                        instance = new Singleton();
                }
            }

            return instance;
        }
    }
}
