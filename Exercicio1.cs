using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo
{
    public class Exercicio1
    {
        public static void Executar()
        {
            string arquivo = "ola.txt";

            try
            {
               if (File.Exists(arquivo))
               {
                    string[] linhas = File.ReadAllLines(arquivo);
                    
                    foreach (string linha in linhas)
                    {
                        foreach (char c in linha)
                        {
                            if (char.IsLetter(c))
                            {
                                Console.Write(c);
                            }
                        }

                    }
               }
               else
               {
                    Console.WriteLine("O arquivo não foi encontrado");
               }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }

    }
}
