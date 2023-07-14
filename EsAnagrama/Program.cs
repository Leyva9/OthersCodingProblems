internal class Program
{
    public static bool IsAnagram(string a, string b)
    {
        a = a.ToLower();
        b = b.ToLower();
        bool[] valor = new bool[a.Length];
        bool anagram = false;
        if(a.Length != b.Length)
        {
            return false;
        }
        for(int i = 0; i < a.Length; i++)
        {
            anagram = false;
            for(int j = 0; j < a.Length; j++)
            {
                if(a[i] == b[j] && !valor[j])
                {
                    valor[j] = true;
                    anagram = true;
                    break;
                }
            }
            if(!anagram)
            {
                return false;
            }
        }
        return true;
    }
    private static void Main(string[] args)
    {
        System.Console.WriteLine(IsAnagram("caas", "Casa"));
    }
}