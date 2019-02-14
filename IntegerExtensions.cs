using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 && b == 0)
                throw new ArgumentException();
            if (a > int.MaxValue || b > int.MaxValue)
                throw new ArgumentException();
            if (a < int.MinValue || b < int.MinValue)
                throw new ArgumentException();

            int m = Math.Abs(a);
            int n = Math.Abs(b);
           
            // put your code here
            // throw new NotImplementedException();
            //на нули добавить всякую чухню

            int d = 0;
            int i = 0;
            int j = 0;


            if (n != m)
            {
                if ((n != 0) && (m != 0))
                {
                    if (m > n)
                    {
                        i = m;
                    }
                    else if (n > m)
                    {
                        i = n;
                    }
                        for (j = 1; j <= i / 2; j++)
                        {
                            if ((n % j == 0) && (m % j == 0))
                                d = j;
                        }
                }
                else
                {
                    if (n != 0)
                        d = n;
                    else d = m;                   
                }
            }
            else
            {
                d = n;
            }

            return d;
        }
    }
}
