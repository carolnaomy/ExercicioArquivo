using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo
{
    public class Exercicio5
    {
        public static void Executar()
        {
            
            string caminhoArquivo = "dados.txt";

            try
            {
                
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("O arquivo não existe.");
                    return;
                }

                
                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    
                    if (!int.TryParse(reader.ReadLine(), out int totalRegistros))
                    {
                        Console.WriteLine("O primeiro valor do arquivo não é um número inteiro válido.");
                        return;
                    }

                    int somaSegundoCampo = 0;

                    
                    for (int i = 0; i < totalRegistros; i++)
                    {
                        
                        string linha = reader.ReadLine();

                      
                        string[] campos = linha.Split(',');

                        
                        if (campos.Length == 3 && char.TryParse(campos[0], out char primeiroCampo) && int.TryParse(campos[1], out int segundoCampo))
                        {
                            
                            somaSegundoCampo += segundoCampo;
                        }
                        else
                        {
                            Console.WriteLine($"Registro inválido na linha {i + 2}. Será ignorado.");
                        }
                    }

                   
                    Console.WriteLine($"A soma do segundo campo dos registros é: {somaSegundoCampo}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }

        }
    }
}
