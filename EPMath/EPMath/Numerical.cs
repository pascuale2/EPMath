namespace EPMath
{
    public static class Numeric
    {
        /// <summary>
        /// Uses Wilson's Theorem to compute if the number is prime
        /// </summary>
        public static bool IsPrime(int n)
        {
            if (n == 2 || n == 3) { return true; }
            if (n <= 1 || n % 2 == 0 || n % 3 == 0) { return false; }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Divides number by repeatedly subtracting number by denominator 
        /// </summary>
        public static (int quotient, int remainder) RepeatedSubtractionDivide(int n, int d)
        {
            if (d == 0) { throw new DivideByZeroException(); }

            int r = n;
            int q = 0;

            while (r >= d)
            {
                r = r - d;
                q += 1;
            }

            return (q, r);
        }
    }
}