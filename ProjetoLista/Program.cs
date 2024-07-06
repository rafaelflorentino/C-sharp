using System;
using System.Collections.Generic;

namespace ProjetoLista;
class Program
{
    static void Main(string[] args)
    {       
        ClientePF cl1 = new ClientePF();
        cl1.id=1;
        cl1.nome="Ana";

        // Criar Lista de cliente e povoar

        List<ClientePF> lista = new List<ClientePF>();
        lista.Add(new ClientePF()); // Adicionado elemento vázio
        lista.Add(cl1); 
        lista.Add(new ClientePF() {id=3, nome="Carlos"});

        foreach (ClientePF aux in lista)
        {
            System.Console.WriteLine("Cliente: {0}", aux.nome);
        }
    }
}
