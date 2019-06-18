

using System.Collections;
using System.Text;

namespace ConsoleApplication1
{
    public class _67AddBinary
    {
        public _67AddBinary()
        {
            string a = "11";
            string b = "1";

            string result = AddBinary(a, b);
        }

        public string AddBinary(string a, string b)
        {
            string result = "";
            int aLength = a.Length;
            int bLength = b.Length;
            char carry = '0';

            Stack stack = new Stack();

            while (0 < aLength || 0 < bLength)
            {
                int oneCount = 0;
                if (0 < aLength)
                {
                    if (a[aLength - 1] == '1')
                    {
                        oneCount++;
                    }
                    aLength--;
                }
                if (0 < bLength)
                {
                    if (b[bLength - 1] == '1')
                    {
                        oneCount++;
                    }
                    bLength--;
                }

                if (carry == '1')
                {
                    oneCount++;
                }

                carry = addBinary(stack, oneCount, carry);
            }

            if (carry == '1')
            {
                stack.Push("1");
            }

            StringBuilder stringBuilder = new StringBuilder();
            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }

            result = stringBuilder.ToString();

            return result;
        }

        private char addBinary(Stack stack, int oneCount, char carry)
        {
            if (oneCount == 3)
            {
                stack.Push('1');
                carry = '1';
            }
            else if (oneCount == 2)
            {
                stack.Push('0');
                carry = '1';
            }
            else if (oneCount == 1)
            {
                stack.Push('1');
                carry = '0';
            }
            else
            {
                stack.Push('0');
                carry = '0';
            }

            return carry;
        }


    }
}
