using System;

namespace EPAUnibrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, res;
            int opcaoPagamento;

            Console.WriteLine("Digite o valor do pagamento.");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a opçao do pagamento de 1 a 5.");
            opcaoPagamento = int.Parse(Console.ReadLine());

            if (opcaoPagamento == 1)
            {
                Console.WriteLine("Valor total. \nR$: " + n1);
                res = (n1 * 10) / 100;
                Console.WriteLine("Valor total com desconto de 10%. \nR$: " + (n1 - res));
            }
            else if (opcaoPagamento == 2)
            {
                Console.WriteLine("Valor total. \nR$: " + n1);
                res = 4;
                Console.WriteLine("Valor total com desconto de R$ 4,00. \nR$: " + (n1 - res));
            }
            else if (opcaoPagamento == 3)
            {
                Console.WriteLine("Valor total. \nR$: " + n1);
                res = (n1 * 15) / 100;
                Console.WriteLine("Valor total com desconto de 15%. \nR$: " + (n1 - res));
            }
            else if (opcaoPagamento == 4)
            {              
                Console.WriteLine("Grátis");
            }
            else
            {
                Console.WriteLine("Valor total sem desconto. \nR$: " + n1);
                
            }
        }
    }
}
