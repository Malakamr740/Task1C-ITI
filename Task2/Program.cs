namespace Task2
{
    internal class Program
    {
        public struct Time
        {
            public int Hours;
            public int Minutes;
            public int Seconds;

            public void Print()
            {
                Console.WriteLine($"{Hours:D2}H:{Minutes:D2}M:{Seconds:D2}S");
            }
        }

        static void Main(string[] args)
        {
            #region Question01
            int num = Int32.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion


            #region Question02
            Console.Write("Enter number of tracks: ");
            int numTracks = int.Parse(Console.ReadLine());

            Console.Write("Enter number of students per track: ");
            int numStudents = int.Parse(Console.ReadLine());

            int[,] studentAges = new int[numTracks, numStudents];

            for (int i = 0; i < numTracks; i++)
            {
                Console.WriteLine($"\nEntering ages for Track {i + 1}");
                for (int j = 0; j < numStudents; j++)
                {
                    Console.Write($"Enter age for student {j + 1}: ");
                    studentAges[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nStudent Ages and Averages:");
            for (int i = 0; i < numTracks; i++)
            {
                Console.WriteLine($"\nTrack {i + 1}:");
                int sumAges = 0;
                Console.Write("Ages: ");
                for (int j = 0; j < numStudents; j++)
                {
                    Console.Write($"{studentAges[i, j]} ");
                    sumAges += studentAges[i, j];
                }
                double averageAge = (double)sumAges / numStudents;
                Console.WriteLine($"\nAverage Age: {averageAge:F2}");
            }
            #endregion

            #region Question 03 and 04
                Time time;
                time.Hours = 22;
                time.Minutes = 33;
                time.Seconds = 11;

                time.Print();
            #endregion
        }
    }
}
