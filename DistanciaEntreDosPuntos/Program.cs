internal class Program
{
    private static double Distancia(double x1, double y1, double x2, double y2) 
    {
        return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }
    private static void Main(string[] args)
    {
        //Call the function Distancia to get the distance between the two points
        string msg = "felicidades!";
        Console.Write("Escriba la x de la cordenada del primer punto: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escriba la y de la cordenada del primer punto: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escriba la x de la cordenada del segundo punto: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escriba la y de la cordenada del segundo punto: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("La distancia entre los dos puntos es {0}", Distancia(x1, y1, x2, y2));
        Console.WriteLine(msg.ToUpper());

    }

}