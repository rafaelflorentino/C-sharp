using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codificacao.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ { get; set; }

        public void Inserir(PessoaJuridica pj)
        {
            using(StreamWriter sw = new StreamWriter(pj.Nome+"txt"))
            {
                sw.WriteLine($"{pj.Nome}; {pj.Rendimento}; {pj.CNPJ}");
            }
        }
    }
}