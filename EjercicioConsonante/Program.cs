internal class Program
{
        static char[] letras = { 'a', 'e', 'r', 's' };
        static char[] consonantes = { 'm', 'p', 't' };
        static char[] vocales = { 'a', 'e', 'o' };    
        static void ConsonantesVocales(string s, int n)
        {
            if (n <= 2 * consonantes.Length)
            {
                Console.WriteLine(s);
                if (n < 2 * consonantes.Length)
                {
                    for (int i = 0; i < consonantes.Length; i++)
                    {
                        s = s.Insert(n, consonantes[i].ToString());
                        ConsonantesVocales(s, n + 1);
                        s = s.Insert(n, vocales[i].ToString());
                        ConsonantesVocales(s, n + 1);
                    }
                }
            }
        }
    private static void Main(string[] args)
    {
        ConsonantesVocales("radiador", 5);
    }
}