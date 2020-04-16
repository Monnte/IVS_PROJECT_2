/**
* @file OwnMath.cs
* @author Eduard Frlička
* @date 2020-04-04
* 
* @copyright Copyright (c) 2019
* 
*/
using System;

namespace P_Math
{

    public class OwnMath
    {
        private static double mem = 0; /*!< Variable where answers are saved to memory*/


        public static double percent(double x)
        {
            return x/100;
        }

        public static double reverse(double x)
        {
            return 1 / x;
        }

        public static double square(double x)
        {
            return pow(x, 2);
        }

        /**
        * @brief Add two numbers , double and double
        * 
        * @pre Parameters "a" and "b"
        * @post Sum of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Sum of "a" and "b" in double
        */
        public static double add(double a, double b)
        {
            return a + b;
        }

        /**
        * @brief Add two numbers , int and double
        * 
        * @pre Parameters "a" and "b"
        * @post Sum of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Sum of "a" and "b" in double
        */
        public static double add(double a, int b)
        {
            return a + b;
        }

        public static double sub(double a, double b)
        {
            return a - b;
        }

        /**
        * @brief Multiplicate two numbers , double and dobule
        * 
        * @pre Parameters "a" and "b"
        * @post Multiplication of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Multiplication of "a" and "b" in double
        */
        public static double mul(double a, double b)
        {
            return a * b;
        }

        /**
       * @brief Multiplicate two numbers , double and int
       * 
       * @pre Parameters "a" and "b"
       * @post Multiplication of two numbers
       * 
       * @param a First number
       * @param b Second number
       * @return Multiplication of "a" and "b" in double
       */
        public static double mul(double a, int b)
        {
            return a * b;
        }

        /**
       * @brief Multiplicate two numbers , int and int
       * 
       * @pre Parameters "a" and "b"
       * @post Multiplication of two numbers
       * 
       * @param a First number
       * @param b Second number
       * @return Multiplication of "a" and "b" in int
       */
        public static int mul(int a, int b)
        {
            return a * b;
        }

        /**
       * @brief Divide two numbers , double and dobule
       * 
       * @pre Parameters "a" and "b"
       * @post Division of two numbers
       * 
       * @param a First number
       * @param b Second number
       * @return Division of "a" and "b" in double
       */

        public static double div(double a, double b)
        {
            if (b == 0) throw new Exception("Delis nulou vole :/");

            return a / b;
        }

        /**
        * @brief Divide two numbers , double and int
        * 
        * @pre Parameters "a" and "b"
        * @post Division of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Division of "a" and "b" in double
        */

        public static double div(double a, int b)
        {
            if (b == 0) throw new Exception("Delis nulou vole :/");

            return a / (double)b;
        }

        /**
        * @brief Divide two numbers , int and double
        * 
        * @pre Parameters "a" and "b"
        * @post Division of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Division of "a" and "b" in double
        */

        public static double div(int a, double b)
        {
            if (b == 0) throw new Exception("Delis nulou vole :/");

            return a / b;
        }

        /**
        * @brief Divide two numbers , int and int
        * 
        * @pre Parameters "a" and "b"
        * @post Division of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Division of "a" and "b" in double
        */

        public static double div(int a, int b)
        {
            if (b == 0) throw new Exception("Delis nulou vole :/");

            return (double)a / (double)b;
        }

        /**
        * @brief Divide two Integer numbers
        * 
        * @pre Parameters "a" and "b"
        * @post Division of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Division of "a" and "b" in int
        */

        public static int divInt(int a, int b)
        {
            if (b == 0) throw new Exception("Delis nulou vole :/");
            return a / b;
        }

        /**
        * @brief Add two integers
        * 
        * @pre Parameters "a" and "b"
        * @post Sum of two numbers
        * 
        * @param a First number
        * @param b Second number
        * @return Sum of "a" and "b" in int
        */

        public static int add(int a, int b)
        {
            return a + b;
        }

        /**
        * @brief Aboslute value of double
        * 
        * @pre Parameters "x"
        * @post Absolute value of "x"
        * 
        * @param x Number
        * @return Absolute value of "x" 
        */

        public static double Abs(double x)
        {
            return x > 0 ? x : -x;
        }

        /**
        * @brief Aboslute value of int
        * 
        * @pre Parameters "x"
        * @post Absolute value of "x"
        * 
        * @param x Number
        * @return Absolute value of "x" 
        */

        public static int Abs(int x)
        {
            return x > 0 ? x : -x;
        }

        /**
        * @brief Factorial of number
        * 
        * @pre Parameters "n" >= 0
        * @post Factorial value of "n"
        * 
        * @param n Number  >= 0
        * @return Factorial of number "n" 
        */

        public static double Factorial(double n)
        {
            if (n >= 0)
            return Factorial((uint)n);
            return 0;
        }
        public static uint Factorial(uint n)
        {
            if (n == 0) return 1;
            uint result = n;
            while (--n > 0)
            {
                result *= n;
            }
            return result;
        }

        /**
        * @brief Add double to calculator memory
        * 
        * @pre Parameters "x"
        * @post Successfully added to memory
        * 
        * @param x Number
        */

        public static void memAdd(double x)
        {
            mem += x;
        }

        /**
        * @brief Add int to calculator memory
        * 
        * @pre Parameters "x"
        * @post Successfully added to memory
        * 
        * @param x Number
        */

        public static void memAdd(int x)
        {
            mem += (double)x;
        }

        /**
        * @brief Substract double from calculator memory
        * 
        * @pre Parameters "x"
        * @post Successfully added to memory
        * 
        * @param x Number
        */

        public static void memSub(double x)
        {
            mem -= x;
        }

        /**
        * @brief Substract int from calculator memory
        * 
        * @pre Parameters "x"
        * @post Successfully added to memory
        * 
        * @param x Number
        */

        public static void memSub(int x)
        {
            mem -= (double)x;
        }

        /**
       * @brief Set memory to zero value
       * 
       * @post Successfully delete memory
       */

        public static void memDel()
        {
            mem = 0;
        }

        /**
        * @brief Load number from memory
        * 
        * @post Successfully loaded number
        */
        public static double memLoad()
        {
            return mem;
        }

        /**
        * @brief Load int from memory
        * 
        * @post Successfully loaded int
        */
        public static int memLoadInt()
        {
            return round(mem);
        }

        /**
        * @brief Floor dobule
        * 
        * @pre Parameters "x"
        * @post Floored double
        * 
        * @param x Number 
        * @return Floored double
        */
        public static double floor(double x)
        {
            return Math.Floor(x);
        }

        /**
        * @brief Floor int
        * 
        * @pre Parameters "x"
        * @post Floored int
        * 
        * @param x Number 
        * @return Floored int
        */
        public static int floorInt(double x)
        {
            return (int)Math.Floor(x);
        }

        /**
        * @brief Ceil int
        * 
        * @pre Parameters "x"
        * @post Ceiled int
        * 
        * @param x Number 
        * @return Ceiled int
        */
        public static int ceilInt(double x)
        {
            return (int)Math.Ceiling(x);
        }

        /**
        * @brief Ceil double
        * 
        * @pre Parameters "x"
        * @post Ceiled double
        * 
        * @param x Number 
        * @return Ceiled double
        */
        public static double ceil(double x)
        {
            return Math.Ceiling(x);
        }

        /**
        * @brief Round double
        * 
        * @pre Parameters "x"
        * @post Rounded double
        * 
        * @param x Number
        * @param decimalPlace Which decimal place to round
        * 
        * @return Rounded double
        */
        public static double round(double x, int decimalPlace = 1)
        {
            return Math.Round(x, decimalPlace);

        }

        /**
        * @brief Round double to int
        * 
        * @pre Parameters "x"
        * @post Rounded double to int
        * 
        * @param x Number
        * 
        * @return Rounded double to integer
        */

        public static int round(double x)
        {
            return (int)Math.Round(x);

        }

        /**
        * @brief Power int to some exponent
        * 
        * @pre Parameters "x" and power number
        * @post Power of number
        * 
        * @param x Number
        * @param power Number
        * 
        * @return value of power in integer
        */
        public static int pow(int x, int power)
        {
            return (int)Math.Pow(x, power);
        }

        /**
        * @brief Power double to some exponent
        * 
        * @pre Parameters "x" and power number
        * @post Power of number
        * 
        * @param x Number
        * @param power Number
        * 
        * @return value of power in double
        */
        public static double pow(double x, double power)
        {
            return Math.Pow(x, power);
        }

        /**
        * @return zero
        */
        public static double sqrt(double x)
        {
            if (x < 0) throw new Exception("Ty pako, odmocnina zo zapornych cisel neje :D");
            return Math.Sqrt(x);
        }

        public static double root(double x, int power)
        {
            return pow(x, 1 / (double)power);
        }

        public static double root(double x, double power)
        {
            return pow(x, 1 / power);
        }
    }

}