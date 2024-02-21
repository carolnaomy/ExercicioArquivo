using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o número de linhas:");
            if (!int.TryParse(Console.ReadLine(), out int numLinhas) || numLinhas <= 0)
            {
                Console.WriteLine("Número inválido");
                return;
            }

            Console.WriteLine("Informe o número de colunas:");
            if (!int.TryParse(Console.ReadLine(), out int numColunas) || numColunas <= 0)
            {
                Console.WriteLine("Número Inválido.");
                return;
            }

            Random random = new Random();
            string caminhoArquivo = "arquivo.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    for (int i = 0; i < numLinhas; i++)
                    {
                        for (int j = 0; j < numColunas; j++)
                        {
                            int valor = random.Next(0, 1001);
                            writer.Write(valor);

                            if (j < numColunas - 1)
                            {
                                writer.Write("\t");

                            }

                        }
                        writer.WriteLine();
                    }
                }
                Console.WriteLine($"Arquivo gerado com sucesso: {caminhoArquivo}");
            }

            catch (Exception ex)

            {
                Console.WriteLine($"Ocorreu um erro ao gerar o arquivo: {ex.Message}");

            }


        }
    }
}

