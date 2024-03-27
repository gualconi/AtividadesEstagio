using System;
using AtividadesEstagio.Atividades;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma atividade para executar:");
            Console.WriteLine("1. Atividade 1");
            Console.WriteLine("2. Atividade 2");
            Console.WriteLine("3. Atividade 3");
            Console.WriteLine("4. Atividade 4");
            Console.WriteLine("5. Atividade 5");
            Console.WriteLine("6. Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Atividade1.Executar();
                    break;
                case 2:
                    Atividade2.Executar();
                    break;
                case 3:
                    Atividade3.Executar();
                    break;
                case 4:
                    Atividade4.Executar();
                    break;
                case 5:
                    Atividade5.Executar();
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }
        }
    }
}
