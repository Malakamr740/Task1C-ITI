

namespace TaskDay4CSharp.Shapes
{

    internal class Circle : Shape, IDrawable
    {
        public Circle()
        {
            Name = "Circle";
        }
        const double pi = 3.14;
        public int Radius { get; set; }

        public override double Area()
        {
            return 2*pi*Radius;
        }

     
        public override void Draw()
        {
            Console.WriteLine("O");
        }
    }

      
}
