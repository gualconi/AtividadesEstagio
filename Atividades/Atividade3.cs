using System;

namespace AtividadesEstagio.Atividades
{
    public class Atividade3
    {
        public static void Executar()
        {
            Console.WriteLine("Escolha uma letra para a atividade:");
            Console.WriteLine("a) 1, 3, 5, 7, ?");
            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ?");
            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ?");
            Console.WriteLine("d) 4, 16, 36, 64, ?");
            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ?");
            Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ?");

            char escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                    Console.WriteLine("Resultado: " + SequenciaA(7));
                    Console.WriteLine();
                    break;
                case 'b':
                    Console.WriteLine("Resultado: " + SequenciaB(64));
                    Console.WriteLine();
                    break;
                case 'c':
                    Console.WriteLine("Resultado: " + SequenciaC(36));
                    Console.WriteLine();
                    break;
                case 'd':
                    Console.WriteLine("Resultado: " + SequenciaD(64));
                    Console.WriteLine();
                    break;
                case 'e':
                    Console.WriteLine("Resultado: " + SequenciaE(8));
                    Console.WriteLine();
                    break;
                case 'f':
                    Console.WriteLine("Resultado: " + SequenciaF(19));
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    Console.WriteLine();
                    break;
            }
        }

        static int SequenciaA(int ultimoElemento)
        {
            return ultimoElemento + 2;
        }

        static int SequenciaB(int ultimoElemento)
        {
            return ultimoElemento * 2;
        }

        static int SequenciaC(int ultimoElemento)
        {
            int raizQuadrada = (int)Math.Sqrt(ultimoElemento);
            return (raizQuadrada + 1) * (raizQuadrada + 1);
        }

        static int SequenciaD(int ultimoElemento)
        {
            int raizQuadrada = (int)Math.Sqrt(ultimoElemento);
            return (raizQuadrada + 2) * (raizQuadrada + 2);
        }

        static int SequenciaE(int ultimoElemento)
        {
            int penultimo = 1;
            int ultimo = 2;

            while (ultimo <= ultimoElemento)
            {
                int proximo = penultimo + ultimo;
                penultimo = ultimo;
                ultimo = proximo;
            }

            return ultimo;
        }

        static int SequenciaF(int ultimoElemento)
        {
            return ultimoElemento + 1;
        }
    }
}

