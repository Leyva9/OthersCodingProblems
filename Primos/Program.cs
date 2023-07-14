internal class Program
{
    private static string PrimosReales(int n) {
        int CuentaDivisores = 0;
        for (int i = 1; i <= n; i++) {
            if (n%i == 0) {
                CuentaDivisores++;
            }
        } if (CuentaDivisores == 2) {
            return "Es un número primo";
        } else {
            return "No es un número primo";
        }
    }
    private static void Main(string[] args)
    {
        Console.Write("Escribe un número para determinar si es primo o no: ");
        Console.ReadLine();
        Console.WriteLine(PrimosReales(4));
    }
}