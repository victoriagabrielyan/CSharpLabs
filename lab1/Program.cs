namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixClass m = new MatrixClass(5, -30, 30);

            m.ShowMatrix();

            Console.WriteLine($"\n{m.CountOdd()}");
        }
    }
}
