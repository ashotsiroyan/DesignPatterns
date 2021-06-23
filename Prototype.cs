using System;

namespace DesignPatterns
{
    public abstract class Shape
    {
        private int x;
        private int y;

        public Shape()
        {

        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected Shape(Shape source)
        {
            x = source.x;
            y = source.y;
        }

        public abstract Shape Clone();

        public int X { get { return x; } }
        public int Y { get { return y; } }
    }

    public class Rectangle: Shape{
        private int width;
        private int height;

        public Rectangle()
        {

        }

        public Rectangle(int x, int y, int width, int height): base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        private Rectangle(Rectangle source): base(source)
        {
            width = source.width;
            height = source.height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public int Width { get { return width; } }
        public int Height { get { return height; } }
    }
}