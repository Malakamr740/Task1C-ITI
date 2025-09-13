using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3CSharp
{
    internal class MCQ : Question
    {
        public string[]  choices { get; set; }
    
        public MCQ(ref string[] _choices , string header , string Body , double mark):base(header , Body) 
        {
            choices = _choices;

        }
        public override void show()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine(choices[i]);
            }
            Console.WriteLine(Mark);
        }
    }
}
