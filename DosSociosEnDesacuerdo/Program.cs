internal class Program
{
    private static bool ValidezAcuerdo(int a) {
        if(a%2==0) {
            return true;
        } else {
            return false;
        }
    }
    private static void Main(string[] args)
    {
        System.Console.Write("Introduce una cifra: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ValidezAcuerdo(a));
    }
}