namespace TwiceLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DblLinear(10000));
            Console.ReadKey();
        }

        public static int DblLinear(int n)
        {
            List<int> u = new List<int> { 1 };
            int pointerX = 0, pointerY = 0;

            while (u.Count <= n)
            {
                int nextX = 2 * u[pointerX] + 1;
                int nextY = 3 * u[pointerY] + 1;

                if (nextX < nextY)
                {
                    u.Add(nextX);
                    pointerX++;
                }
                else if (nextX > nextY)
                {
                    u.Add(nextY);
                    pointerY++;
                }
                else
                {
                    u.Add(nextX);
                    pointerX++;
                    pointerY++;
                }
            }

            return u[n];
        }


    }
}
