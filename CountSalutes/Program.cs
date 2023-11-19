namespace CountSalutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSalutes(">>>>>>>>>>>>>>>>>>>>>----<->"));
            Console.ReadLine();
        }

        public static int CountSalutes(string hallway)
        {
            int leftArrowCount = 0;
            int salutes = 0;

            var arr = hallway.ToCharArray();

            foreach (var c in hallway)
            {
                if (c == '>')
                    leftArrowCount++;

                if (c == '<')
                    salutes += leftArrowCount * 2;
            }

            return salutes;
        }

        
    }
}
