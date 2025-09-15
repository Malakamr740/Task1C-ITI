
namespace TaskDay4CSharp
{
    internal class Grade
    {
        public int Value { get; set; }

        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade { Value = g1.Value + g2.Value };
        } 
        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.Value == g2.Value;
        } 
        public static bool operator !=(Grade g1, Grade g2)
        {
            return g1.Value != g2.Value;
        } 

    }
}
