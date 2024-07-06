using System;
using System.IO;
class Program
    {
        static void Main(string[] args)
        {
            // Especificar o caminho do arquivo
            string caminhoDoArquivo = "arquivo.txt";

            // Instancia um objeto do tipo StreamWriter com o caminho do arquivo como argumento.
            var stream = new StreamWriter(caminhoDoArquivo);

            // Escreve linhas no arquivo
            stream.WriteLine("Linha 1..."); 
            stream.WriteLine("Linha 2..."); 
            stream.WriteLine("Linha 3...");
            stream.Write("Texto salvo com sucesso");

            // Fecha o objeto atual e o fluxo adjacente
            stream.Close();

            // using finaliza a instrução no final do bloco de execução
            // streamreader para ler um arquivo
            using(var reader = new StreamReader(caminhoDoArquivo))
            {
               // Lê linha por linha até o final do arquivo. 
               var linha = " "; 
               while ((linha = reader.ReadLine()) != null) 
               { 
                    Console.WriteLine(linha); 
               }
            }
        }
    }