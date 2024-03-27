using System;

namespace AtividadesEstagio.Atividades
{
    public class Atividade4
    {
        public static void Executar()
        {
            Console.WriteLine();
            Console.WriteLine("Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente.");
            Console.WriteLine("Primeira visita:");
            Console.WriteLine("1. Ligue o interruptor 1 por alguns minutos e depois desligue-o.");
            Console.WriteLine("2. Ligue o interruptor 2.");
            Console.WriteLine();
            Console.WriteLine("Entre na sala das lâmpadas. O que você observa na lâmpada?");
            Console.WriteLine("1. Está acesa.");
            Console.WriteLine("2. Está apagada, mas morna ao toque.");
            Console.WriteLine("3. Está apagada e fria ao toque.");

            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("O interruptor 2 controla a lâmpada.");
                Console.WriteLine();
            }
            else if (resposta == 2)
            {
                Console.WriteLine("O interruptor 1 controla a lâmpada.");
                Console.WriteLine();
            }
            else if (resposta == 3)
            {
                Console.WriteLine("O interruptor 3 controla a lâmpada.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                Console.WriteLine();
            }

        }
    }
}
