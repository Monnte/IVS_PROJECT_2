using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Math;

namespace Profiling
{
    class Program
    {
        private const char Separator = ' ';

        static void Main(string[] args)
        {

            double output;
            List<double> numbers = new List<double>();

            string[] inputs = Console.ReadLine().Replace('.', ',').Split(Separator);
            int strlen = inputs.Length;

            double tmp = 0;
            for (int i = 0; i < strlen; i++)
            {
                if (inputs[i] != string.Empty)
                {
                    if (!double.TryParse(inputs[i], out tmp))
                    {
                        Console.WriteLine("Wrong format of input.");
                        return;
                    }
                    numbers.Add(tmp);
                }
            }

            double N = numbers.Count;
            double x_carka;

            tmp = 0;
            for (int i = 0; i < N; i++)
            {
                tmp = OwnMath.add(tmp, numbers[i]);
            }

            x_carka = OwnMath.mul(OwnMath.div(1, N), tmp);

            tmp = 0;
            for (int i = 0; i < N; i++)
            {
                tmp = OwnMath.add(tmp, OwnMath.pow(numbers[i], 2));
            }

            output = OwnMath.sqrt(OwnMath.mul(OwnMath.div(1, OwnMath.sub(N, 1)), OwnMath.sub(tmp, OwnMath.mul(N, OwnMath.pow(x_carka, 2)))));

            Console.WriteLine(output);

        }
    }
}
