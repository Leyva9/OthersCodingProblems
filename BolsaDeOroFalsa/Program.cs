internal class Program
{
    private static int BuscaElBarrilFalso(int[] a)
    {
        int posicion = 0;
        int aux = 0;
        int sumaMonedas = (a.Length) * (a.Length + 1) / 2;
        int sumaMonedasEsc = sumaMonedas * 10;
        for (int i = 0; i < a.Length; i++)
        {
            aux = aux + a[i] + (a[i] * i);
        }
        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine("Verifico si {0} - {1}, es igual a {2} + i", sumaMonedasEsc, aux, i);
            if((sumaMonedasEsc - aux) == i)
            {
                posicion = i;
                return i;
            }
        }
        return posicion;
    }
    private static void Main(string[] args)
    {
        int[] barriles = {10, 10, 10, 10, 10, 10, 10, 9, 10, 10};
        System.Console.WriteLine(BuscaElBarrilFalso(barriles));
    }
}