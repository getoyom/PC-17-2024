/*Gabriel Emilio Toyom Jimenez*/
/*1051524*/
/*PROYECTO FIBONACCI*/


namespace fibonacci
{
    class fibonacci
    {
        static void Main(String[] args)
        {
            int n = 0;
            int A = 0;
            int B = 1;
            int C = 0;
            int i = 2;
            string resultado = "";

            Console.WriteLine("Ingrese un valor");
            n = Int32.Parse(Console.ReadLine());

            if (n > 0)
            {
                resultado += A;
            }
            if (n > 1)
            {
                resultado += "," + B;

                while (i < n)
                {
                    C = A + B;
                    resultado += "," + C;
                    A = B;
                    B = C;
                    i = i + 1;
                    
                }

                Console.WriteLine($"{resultado}");
            }

            else
                {
                    Console.WriteLine($"El resultado es {resultado}");
                    return;
                }

            }

        }
    }