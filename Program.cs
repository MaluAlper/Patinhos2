using System;

namespace patinhos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite quantos patinhos foram passear? (>=2) ");
            int patinho = Convert.ToInt32(Console.ReadLine());

            if (patinho < 2)
            {
                Console.WriteLine("Número de patinhos deve ser maior que 1");
                Environment.Exit(-1);
            }

            for (int i = patinho; i > 0; i = i - 1)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i} patinho foi passear");
                }
                else 
                {                    
                    Console.WriteLine($"{i} patinhos foram passear");
                }

                Console.WriteLine("além das montanhas");
                Console.WriteLine("para brincar");
                Console.WriteLine("a mamãe gritou: Quá, quá, quá, quá");

                if (i == 2)
                {
                    Console.WriteLine($"mas só {i - 1} patinho voltou de lá.\n");
                }
                else if (i == 1)
                {
                    Console.WriteLine("mas nenhum patinho voltou de lá\n");
                }
                else
                {
                    Console.WriteLine($"mas só {i - 1} patinhos voltaram de lá.\n");
                }
            }

            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine($"E os {patinho} patinhos voltaram de lá.");
        }
    }
}
