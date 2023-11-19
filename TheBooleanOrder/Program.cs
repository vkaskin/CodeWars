using System.Data;
using System.Numerics;

namespace TheBooleanOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BooleanOrder booleanOrder = new BooleanOrder("ttftff", "|&^&&");
            //BooleanOrder booleanOrder = new BooleanOrder("tft", "^&");
            BigInteger result = booleanOrder.Solve();

            Console.WriteLine("Number of arrangements that evaluate to True: " + result);
            Console.ReadKey();
        }


    }

    public class BooleanOrder
    {
        private string operands;
        private string operators;
        private int[,,] memo;

        public BooleanOrder(string operands, string operators)
        {
            this.operands = operands;
            this.operators = operators;
            memo = new int[operands.Length, operands.Length, 2];
            for (int i = 0; i < operands.Length; i++)
            {
                for (int j = 0; j < operands.Length; j++)
                {
                    memo[i, j, 0] = -1;
                    memo[i, j, 1] = -1;
                }
            }
        }

        public BigInteger Solve()
        {
            return CountTrueArrangements(0, operands.Length - 1, 1);
        }

        private int CountTrueArrangements(int start, int end, int isTrue)
        {
            if (start == end)
            {
                return operands[start] == 't' ? (isTrue == 1 ? 1 : 0) : (isTrue == 0 ? 1 : 0);
            }

            if (memo[start, end, isTrue] != -1)
            {
                return memo[start, end, isTrue];
            }

            int count = 0;

            for (int i = start + 1; i < end; i += 2)
            {
                char op = operators[i / 2];
                int leftTrue = CountTrueArrangements(start, i - 1, 1);
                int leftFalse = CountTrueArrangements(start, i - 1, 0);
                int rightTrue = CountTrueArrangements(i + 1, end, 1);
                int rightFalse = CountTrueArrangements(i + 1, end, 0);

                switch (op)
                {
                    case '&':
                        count += isTrue == 1 ? leftTrue * rightTrue : leftFalse * (rightTrue + rightFalse) + leftTrue * rightFalse;
                        break;
                    case '|':
                        count += isTrue == 1 ? (leftTrue * (rightTrue + rightFalse) + leftFalse * rightTrue + leftTrue * rightFalse) : leftFalse * rightFalse;
                        break;
                    case '^':
                        count += isTrue == 1 ? leftTrue * rightFalse + leftFalse * rightTrue : leftTrue * rightTrue + leftFalse * rightFalse;
                        break;
                }
            }

            memo[start, end, isTrue] = count;

            // Debug information
            Console.WriteLine($"CountTrueArrangements({start}, {end}, {isTrue}) = {count}");

            return count;
        }

    }
}



