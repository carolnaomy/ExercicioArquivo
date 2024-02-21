using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo
{
    public class Exercicio3
    {
        public static void Executar()
        {
            string caminhoArquivo = "numeros.txt";

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Não existe o arquivo");
                return;
            }

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                float maiorValor = float.MinValue;
                int linhaMaiorValor = -1;

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (float.TryParse(linhas[i], out float valor))
                    {
                    if (valor > maiorValor)
                      {
                            maiorValor = valor;
                            linhaMaiorValor = i + 1;

                      }
                    }
                    else
                    {
                        Console.WriteLine($"Erro ao converter o valor na linha {i + 1}. A linha será ignorada.");

                    }
                }
                if (linhaMaiorValor != -1)
                {
                    Console.WriteLine($"O maior valor ({maiorValor}) foi encontrado na linha {linhaMaiorValor}.");

                }
                else
                {
                    Console.WriteLine("Nenhum valor numérico foi encontrado no arquivo.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }
        }
    }
}
