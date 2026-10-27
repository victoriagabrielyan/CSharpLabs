namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 26;
            Methods.A(in a);

            int b;
            Methods.B(out b);
            Console.WriteLine($"Main: b = {b}");

            int c = 18;
            Methods.C(ref c);
            Console.WriteLine($"Main: c = {c}");

            Console.WriteLine($"SumValues(5, 12, 44) = {Methods.SumValues(5, 12, 44)}");
        }
    }
}
