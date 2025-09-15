
namespace TaskDay4CSharp
{
    public static class IdGenerator
    {
        static int id = 0;
        public static int GenerateId()
        {
            id++;
            return id;
        }
    }
}