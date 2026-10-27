namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[count];

            for (int i = 0; i < count; i++)
            {
                string[] parts = Console.ReadLine().Split(',');

                Movie m = new Movie();
                m.Id = int.Parse(parts[0]);
                m.Name = parts[1];
                m.Year = int.Parse(parts[2]);
                m.Genre = (Genre)int.Parse(parts[3]);
                m.Views = int.Parse(parts[4]);
                m.Likes = int.Parse(parts[5]);

                movies[i] = m;
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
