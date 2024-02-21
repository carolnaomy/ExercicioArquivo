using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo
{
    public class Exercicio4
    {
        public static void Executar()
        {
            string arquivoEntrada = "numeros1.txt";
            string arquivoSaida = "numero_soma.txt";


            try
            {
            if (!File.Exists(arquivoEntrada))
                {
                    Console.WriteLine("O arquivo de entrada não existe.");
                    return;
                }
                using (StreamReader reader = new StreamReader(arquivoEntrada))
                {
                    using (StreamWriter writer = new StreamWriter(arquivoSaida))
                    {
                        string linha;
                        while ((linha = reader.ReadLine()) != null)
                        {
                            string[] numeros = linha.Split(',');

                            if (numeros.Length == 2 && int.TryParse(numeros[0], out int num1) && int.TryParse(numeros[1], out int num2))
                            {
                                int soma = num1 + num2;

                                writer.WriteLine($"{num1},{num2},{soma}");

                            }
                            else
                            {
                                Console.WriteLine($"A linha '{linha}' não contém dois números inteiros separados por vírgula. Será ignorada.");

                            }
                        }
                    }
                
                }

                Console.WriteLine($"Arquivo gerado com sucesso: {arquivoSaida}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao processar o arquivo: {ex.Message}");
            }
        }
    }
}
