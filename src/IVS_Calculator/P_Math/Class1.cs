using System;

namespace P_Math
{

    public class OwnMath
    {
        private static double mem = 0;
        
        public static decimal add(decimal a, decimal b)
        {
            return a + b;
        }

        public static int add(int a, int b)
        {
            return (int)(a + b);
        }

        public static double Abs(double x)
        {
            return x > 0 ? x : -x;
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            int result = n;
            while(--n > 0)
            {
                result *= n;
            }
            return result;
        }

        public static void memAdd(double x)
        {
            mem += x;
        }

        public static void memSub(double x)
        {
            mem -= x;
        }

        public static void memDel()
        {
            mem = 0;
        }

        public static double memLoad()
        {
            return mem;
        }

        public static double floor(double x)
        {
            return Math.Floor(x);
        }
        

        public static double ceil(double x)
        {
            return Math.Ceiling(x);
        }

        public static double round(double x, int decimalPlace=1)
        {
            return Math.Round(x);

        }

        public static double pow(double x, double power)
        {
            return Math.Pow(x, power);
        }


    }

}
