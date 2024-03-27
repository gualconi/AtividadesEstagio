using System;

namespace AtividadesEstagio.Atividades
{
    public class Atividade5
    {
        public static void Executar()
        {

            Console.WriteLine("Digite uma string para inverter:");
            string input = Console.ReadLine();

            string reversedString = InverterString(input);

            Console.WriteLine("String invertida: " + reversedString);
            Console.WriteLine();

            static string InverterString(string input)
            {
                char[] caracteres = input.ToCharArray();
                int inicio = 0;
                int fim = input.Length - 1;

                while (inicio < fim)
                {
                    char temp = caracteres[inicio];
                    caracteres[inicio] = caracteres[fim];
                    caracteres[fim] = temp;
                    inicio++;
                    fim--;
                }

                return new string(caracteres);
            }
        }
    }
}
