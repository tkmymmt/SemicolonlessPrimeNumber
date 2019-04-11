namespace System.Linq
{
    static class SemicolonlessPrimeNumber
    {
        static void Main(string[] args)
        {
            if (Enumerable.Range(2, 1000000)
            .Where(n => n == 2 || n % 2 != 0)
            .Select(n => (int)Math.Sqrt(n) + 1 is var sqrt &&
                            Enumerable.Range(0, sqrt)
                            .Any(i => 2 < i && n % i == 0) ?
                             new { value = n.ToString() + Environment.NewLine, IsPrime = false }
                             : new { value = n.ToString() + Environment.NewLine, IsPrime = true })
            .Where(x => x.IsPrime == true)
            .Select(x => Text.Encoding.Default.GetBytes(x.value))
            .Select(x => Console.OpenStandardOutput().WriteAsync(x))
            .ToList() != null) { }
        }
    }
}