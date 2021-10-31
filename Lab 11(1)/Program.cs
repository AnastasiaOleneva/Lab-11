using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            lin_equation lin_Equation = new lin_equation { B = -6, K = 2 };
            lin_Equation.Root();
            Console.ReadKey();
        }




        struct lin_equation
        {

            public double B { get; set; }

            public double K { get; set; }

            public lin_equation(double b, double k)
            {
                B = b;
                K = k;

            }


            public void Root()
            {


                if (K> 0 && B > 0)
                {
                    double x1 = -Math.Abs(B/ K);
                    Console.WriteLine("X= {0:F2}", x1);
                   
                    
                }
                if (K < 0 && B <0)
                {
                    double x2 = -(Math.Abs(B / K));
                    Console.WriteLine("X= {0:F2}", x2);
                }


                if (K > 0 && B < 0)
                {
                    double x3 = Math.Abs(B / K);
                    Console.WriteLine("X= {0:F2}", x3);

                }
                if (K < 0 && B > 0)
                {

                    double x4 = Math.Abs(B/K);
                    Console.WriteLine("X= {0:F2}", x4);
                    


                }

                if (K == 0 || B == 0)
                {
                    Console.WriteLine("Ошибка, решений нет!");

                }


            }

        }
    }
}  

