namespace lab8
{
    public static class PrimeNumberExtension
    {
        public static bool IsPrime(this int number)
        {
            int result = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    result++;
                }
            }

            if (result == 1)
            {
                return true;
            }

            return false;
        }
    }
}
