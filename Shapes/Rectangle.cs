
namespace TaskDay4CSharp.Shapes
{
    internal class Rectangle : Shape , IDrawable
    {
        public Rectangle()
        {
            Name = "Rectangle";
        }
        public int Length { get; set; }
        public int Width { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("*************");
            Console.WriteLine("*************");
            Console.WriteLine("*************");
            
        }
    }
}

