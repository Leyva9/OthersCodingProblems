internal class Program
{
    private static int SumaNumeros() {
        do {
            Console.Write("x = ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("y = ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal sum = a + b;
            Console.WriteLine("El resultado de la suma es: {0}", sum);

        } while (true);
    }
    private static void Main(string[] args)
    {
        SumaNumeros();
    }
}