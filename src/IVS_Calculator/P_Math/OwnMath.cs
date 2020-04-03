using System;

namespace P_Math
{

    public class OwnMath
    {
        private static double mem = 0;
        
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static double add(double a, int b)
        {
            return a + b;
        }

        public static double mul(double a, double b)
        {
            return a * b;
        }
        
        public static double mul(double a, int b)
        {
            return a * b;
        }
        
        public static int mul(int a, int b)
        {
            return a * b;
        }

        public static double div(double a, double b)
        {
            return a / b;
        }
        
        public static double div(double a, int b)
        {
            return a / (double)b;
        }
        
        public static double div(int a, double b)
        {
            return a / b;
        }
        
        public static double div(int a, int b)
        {
            return (double)a / (double)b;
        }

        public static int divInt(int a, int b)
        {
            return a / b;
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static double Abs(double x)
        {
            return x > 0 ? x : -x;
        }
        
        public static int Abs(int x)
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

        public static void memAdd(int x)
        {
            mem += (double)x;
        }

        public static void memSub(double x)
        {
            mem -= x;
        }

        public static void memSub(int x)
        {
            mem -= (double)x;
        }

        public static void memDel()
        {
            mem = 0;
        }

        public static double memLoad()
        {
            return mem;
        }

        public static int memLoadInt()
        {
            return round(mem);
        }

        public static double floor(double x)
        {
            return Math.Floor(x);
        }
        
        public static int floorInt(double x)
        {
            return (int)Math.Floor(x);
        }

        public static int ceilInt(double x)
        {
            return (int)Math.Ceiling(x);
        }

        public static double ceil(double x)
        {
            return Math.Ceiling(x);
        }

        public static double round(double x, int decimalPlace=1)
        {
            return Math.Round(x);

        }

        public static int round(double x)
        {
            return (int)Math.Round(x);

        }

        public static int pow(int x, int power)
        {
            return (int)Math.Pow(x, power);
        }

        public static double pow(double x, double power)
        {
            return Math.Pow(x, power);
        }

        public static double root()
        {
            return 0;
        }

    }

}
