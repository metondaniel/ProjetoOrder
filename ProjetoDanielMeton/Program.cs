using ProjetoDanielMeton.Domain;
using System;

namespace ProjetoDanielMeton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Order order = new Order();

                Console.WriteLine("Ola! Bem vindo");
                Console.WriteLine("Digite o periodo da pedido: Manha/ Noite");
                string periodString = Console.ReadLine().ToLowerInvariant().Trim();
                int period = 0;
                if (periodString == "manha")
                {
                    period = 1;
                }
                else if (periodString == "noite")
                    period = 2;
                else
                {
                    throw new InvalidOperationException("Periodo invalido");
                }
                Console.WriteLine("Digite pedido separado por virgula");
                string itens = Console.ReadLine();

                Console.WriteLine(order.Orders(period, itens));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
