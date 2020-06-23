using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            product[] vs = new product[10];

            Console.Write("Quantos quartos serão necessarios: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();
                        
            for(int i = 1; i <= quarto; i ++)
            {
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int vago = int.Parse(Console.ReadLine());
                vs[vago] = new product(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quantos quartos: ");
            for(int i = 1; i < 10; i++)
            {
                if (vs[i] != null)
                {
                    Console.WriteLine(i + ": " + vs[i]);
                }
            }

        }
    }
}
