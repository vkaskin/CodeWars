namespace ValidateCreditCardNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validate("477 073 360");
            Console.ReadKey();
        }

        public static bool Validate(string n)
        {
            const int doubleThreshold = 9;

            var stringWithoutSpaces = n.Replace(" ", "");

            int[] digits = new int[stringWithoutSpaces.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = (int)char.GetNumericValue(stringWithoutSpaces[i]);
            }

            for (int i = digits.Length - 2; i >= 0; i -= 2)
            {
                digits[i] *= 2;

                if (digits[i] > doubleThreshold)
                    digits[i] -= doubleThreshold;
            }

            int sum = digits.Sum();

            return sum % 10 == 0;
        }

        //public bool validate(string n)
        //{

        //    return n.Select(c => (int)char.GetNumericValue(c))
        //      .Where(x => x != -1)
        //      .Reverse()
        //      .Select((x, i) => (i % 2 == 1) ? 2 * x : x)
        //      .Select(x => (x > 9) ? x - 9 : x)
        //      .Sum() % 10 == 0;
        //}

        
    }
}