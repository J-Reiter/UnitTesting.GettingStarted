//  --------------------------------------------------------------------------------------
// UnitTesting.GettingStarted.Calculator.cs
// 2017/01/12
//  --------------------------------------------------------------------------------------

namespace UnitTesting.GettingStarted
{
    public class Calculator
    {
        public int Add(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public int SubtractLargeFromSmall(int num1, int num2)
        {
            if (num1 > num2)
                return num1 - num2;
            else
                return num2 - num1;
        }
    }
}