internal class Program
{
    //Función luis
    private static int Euclides(int a, int b) {
        int numero_max = 0;
        
        for (int i = 1; i <= a && i <= b; i++) {
            System.Console.WriteLine("Este es el resto: " + i);
            if(a%i == 0 && b%i == 0) {
                numero_max = i;
            }
        } return numero_max;
    }

    //Funcion profe
    private static int AlgorEuclid(int a, int b) {
        int aux = 0;
        while (b > 0) {
            System.Console.WriteLine("Este es el resto: " + aux);
            aux = a%b;
            a = b;
            b = aux;
        } return a;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribe dos números para saber su maximo divisor: ");
        int NumeroUno = Convert.ToInt32(Console.ReadLine());
        int NumeroDos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El divisor maximo es: "+ AlgorEuclid(NumeroUno, NumeroDos));
    }
}