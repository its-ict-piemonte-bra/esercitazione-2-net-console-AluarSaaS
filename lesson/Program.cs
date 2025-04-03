using System.Runtime.CompilerServices;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            // Write some code here...
            //  int n

            // n= Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Inserisci un numero naturale");
            //   int n = Convert.ToInt32(Console.ReadLine());

            //    if (n < 0)
            //     {
            //       Console.WriteLine($"{n} non è un numero naturale.");
            Esercizio1();
            Console.WriteLine("\nEsercizio 2:");
            Esercizio2();
            Console.WriteLine("\nEsercizio 3:");
            Esercizio3();
            Console.WriteLine("\nEsercizio 4:");
            Esercizio4();
        }

//            else
  //          {
    //            Console.WriteLine($"{n} è un numero naturale");
      //      }
 
        //}
        /// <summary>
        /// visualizza 100 numeri pari, partendo dal numero 2
        /// </summary>

        private static void Esercizio1()
        {
            Console.WriteLine("Ciaone Mondo");
            Console.WriteLine();
            Console.WriteLine("\n"); //stessa roba

            for (int i = 1; i <= 100; i++)
            {
               int n = 2 * i;
                Console.Write($"{n} ");
            }
        }

        /// <summary>
        /// esercizio 2: calcola il fattoriale di un numero n in ingresso.
        /// Il fattoriale di un n si indica con n!
        /// </summary>

        private static void Esercizio2()
        {
            
            int n;
            do
            {
                Console.WriteLine("Inserisci un numero positivo da input");
                n = Convert.ToInt32(Console.ReadLine());

            }
            while (n < 0);

            int factorial = 1;

            for(int i = 2; i <=n ; i++)
            {
               factorial *= i;
            }
            Console.WriteLine($"Il fattoriale di {n} è:  {factorial}");
        }

        private static void Esercizio3()
        {
            Console.WriteLine("Inserisci un numero in bianrio...");
            string line = Console.ReadLine()??"";

            //Convert.ToInt32(line, 2)
            double result = 0;
            
            for (int i = 0; i <line.Length; i++)
            {
                int currentExpValue= Convert.ToInt32(line[i] - '0');
                result += currentExpValue * Math.Pow(2, line.Length - i-1);
            }

            Console.WriteLine($"{line} -> {result}");    
        }
        /// <summary>
        /// Fibonacci, con un numero intero positivo
        /// </summary>
        private static void Esercizio4()
        {
            Console.WriteLine("Inserisci un numero ...");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine($"{input} non è un numero positivo.");
            }

            else if (input < 2)
            {
                Console.WriteLine($"fibonacci ({n}) -> {n}");
            }
            else
            {
                int first = 0;
                int second = 1;

                for (int i = 2; i <= input; i++)
                {
                    int third = first + second;
                    second = third;
                    first = second;
                }       

          Console.WriteLine($"fibonacci({input}) -> {second}");
            }
        }

    }
}
