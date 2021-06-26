using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }

    class Dot: IGraphic
    {
        protected int x;
        protected int y;

        public Dot()
        {
            x = 0;
            y = 0;
        }

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Console.WriteLine("x: " + x + ", y: " + y);
        }
    }

    public class ComponentGraphic: IGraphic
    {
        private List<IGraphic> children;

        public ComponentGraphic()
        {
            children = new List<IGraphic>();
        }

        public void Add(IGraphic child)
        {
            children.Add(child);
        }

        public void Remove(IGraphic child)
        {
            children.Remove(child);
        }

        public void Move(int x, int y)
        {
            foreach (IGraphic child in children)
            {
                child.Move(x, y);
            }
        }

        public void Draw()
        {
            foreach (IGraphic child in children)
            {
                child.Draw();
            }
        }
    }
}
