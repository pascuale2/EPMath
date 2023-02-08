namespace EPMath
{
    public static class Numerical
    {
        /// <summary>
        /// Uses Wilson's Theorem to compute if the number is prime
        /// </summary>
        /// <param name="n">number to check if is prime</param>
        /// <returns>true if the number is prime, otherwise false</returns>
        public static bool IsPrime(this int n)
        {
            if (n == 2 || n == 3) { return true; }
            if (n <= 1 || n % 2 == 0 || n % 3 == 0) { return false; }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) { return false; }
            }
            return true;
        }
    }
}