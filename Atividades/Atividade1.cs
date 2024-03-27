using System;

namespace AtividadesEstagio.Atividades
{
    public class Atividade1
    {
        public static void Executar()
        {
            Console.WriteLine("Atividade 1");
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine(soma);
            Console.WriteLine();

        }
    }
}
