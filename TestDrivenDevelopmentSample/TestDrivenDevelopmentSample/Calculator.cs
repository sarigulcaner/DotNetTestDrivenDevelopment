using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDrivenDevelopmentSample
{

    public interface ICalculator
    {
         int AddNumbers(int x, int y);
         int MinusNumbers(int p1, int p2);
         int DivideNumbers(int p1, int p2);
         int MultiplyNumbers(int p1, int p2);
         int DecideAndDoOperation(int p1, string p2, int p3);
    }

    public class Calculator 
    {

        public int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public int MinusNumbers(int p1, int p2)
        {
            return p1 - p2;
        }

        public int DivideNumbers(int p1, int p2)
        {
            if (p2 == 0)
                return 0;
            return p1 / p2;
        }

        public int MultiplyNumbers(int p1, int p2)
        {
            return p1 * p2;
        }

        public int DecideAndDoOperation(int p1, string p2, int p3)
        {
            switch (p2)
            {
                case "*":
                    return MultiplyNumbers(p1, p3);
                case "/":
                    return DivideNumbers(p1, p3);
                case "+":
                    return AddNumbers(p1, p3);
                case "-":
                    return MinusNumbers(p1, p3);
                default:
                    return 0;
            }
        }
    }
}
