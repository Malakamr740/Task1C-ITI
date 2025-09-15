
namespace TaskDay4CSharp.Shapes
{
    public abstract class Shape : IDrawable
    {
      
        public string Name { get; set; }
        public abstract double Area();

        public abstract void Draw();
        
    }
}
