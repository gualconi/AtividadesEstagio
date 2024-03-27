using System;

namespace AtividadesEstagio.Atividades
{
    public class Atividade2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            if (VerificarSePertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
                Console.WriteLine();
            }

        }

        static bool VerificarSePertenceFibonacci(int numero)
        {
            int primeiro = 0;
            int segundo = 1;

            if (numero == primeiro || numero == segundo)
            {
                return true;
            }

            int proximo = primeiro + segundo;

            while (proximo <= numero)
            {
                if (proximo == numero)
                {
                    return true;
                }

                primeiro = segundo;
                segundo = proximo;
                proximo = primeiro + segundo;
            }

            return false;
        }
    }
}
