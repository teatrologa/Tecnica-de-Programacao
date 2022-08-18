using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Aula_06_Exercicios
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Valor: R$ {Valor}";
        }
    }
}
