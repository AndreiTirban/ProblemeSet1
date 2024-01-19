using System;

namespace EcuatieGrad1
{
    class Ex1
    {
        static void Main()
        {
            // Citim coeficienții a și b de la utilizator
            Console.Write("Introduceți coeficientul a: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduceți coeficientul b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            // Verificăm dacă ecuația este de gradul 1 sau nu
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
            }
            else
            {
                // Calculăm soluția pentru x: x = -b/a
                float x = -b / a;

                // Afișăm rezultatul
                Console.WriteLine("Solutia ecuatiei {0}*x + {1} = 0 este x = {2}", a, b, x);
            }

            // Așteptăm ca utilizatorul să apese o tastă înainte de a închide consola
            Console.ReadLine();
        }
    }
}

