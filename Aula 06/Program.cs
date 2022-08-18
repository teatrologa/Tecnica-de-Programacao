//Aula 06 de Técnicas de Porgramação

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Aula_06
{
    class Program
    {
        private static List<Produto> listaProdutos = new()
        {
            new Produto { Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
            new Produto { Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
            new Produto { Id = 4, Nome = "Celular", Valor = 8500, Ativo = true },
            new Produto { Id = 3, Nome = "Arroz", Valor = 21, Ativo = true },
            new Produto { Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true },
            new Produto { Id = 9, Nome = "Panela", Valor = 41, Ativo = true },
            new Produto { Id = 5, Nome = "Chinelo", Valor = 11, Ativo = true },
            new Produto { Id = 7, Nome = "TV", Valor = 2350, Ativo = true },
            new Produto { Id = 6, Nome = "Patins", Valor = 66, Ativo = true },
            new Produto { Id = 10, Nome = "Espelho", Valor = 115, Ativo = true },
        };

        static void Main(string[] args)
        {
            var retorno = RetornaPrimeiroProduto();
            if (retorno != null)
            {
                WriteLine(retorno.ToString());
            }
            else { WriteLine(retorno); }

            
            WriteLine("");


            var ret = RetornoListaOrdenadaTop3();
            foreach(Produto prod in ret)
            {
                WriteLine(prod.ToString());
            }


            WriteLine("");


            var rtn = RetornaProdutoDto();
            foreach (ProdutoDto prodDto in rtn)
            {
                WriteLine(prodDto.ToString());
            }


            static Produto RetornaPrimeiroProduto()
            {
                return listaProdutos.FirstOrDefault();
            }

            static Produto RetornarUltimoProduto()
            {
                return listaProdutos.LastOrDefault();
            }

            static Produto RetornarUnicoProduto()
            {
                return listaProdutos.SingleOrDefault(prod => prod.Id == 2);
            }

            static List<Produto> RetornaProdutoInicioLetra()
            {
                return listaProdutos.Where(prod => prod.Nome.Substring(0, 1).ToLower() == "a".ToLower()).ToList();
                    //Dentro do substring o 0 é  indicice primeiro e o 1 é a quantidade de 
                    // caractere que vou comparar, no caso só a primeira letra.
            }

            static List<Produto> RetornarProdutoUltimaLetra()
            {
                return listaProdutos.Where(prod => prod.Nome.EndsWith('o')).ToList();
                //o VS sugere que após o EndsWith tenha o .Equals(true)
                // porém não tenho certeza do que ele faz
            }

            static List<Produto> RetornoListaOrdenada()
            {
                return listaProdutos.OrderBy(prod => prod.Id).ToList(); //Ordenação simples com 1 coluna a ser ordenada
            }

            static List<Produto> RetornoListaSuperOrdenada()
            {
                return listaProdutos.OrderBy(prod => prod.Nome).ThenBy(prod => prod.Valor).ThenBy(prod => prod.Id).ToList();
                //agora sim podemos ordenar por mais de 1 coluna
                //como ordenar pelo titulo de filme de acordo com seu ano de lançamento (ano + titulo)
                //Pode ser colocado varios ThenBy contanto que tenha um OrderBy antes
            }

            static List<ProdutoDto> RetornaProdutoDto()
            {
                //O select serve para filtrar entre os campos de uma classe "mãe"
                // ai se vc quiser pegar mais de uma coluna, vc faz uma classe DTO
                // filtrando as colunas que vc quer pegar da mãe.Imagine isso no SQN (os selects)
                return listaProdutos.Select(prod => new ProdutoDto()
                {
                    NomeProduto = prod.Nome,
                    ValorProduto = prod.Valor

                }).ToList();
            }

            static string RetornaPrimeiroNome()
            {
                return listaProdutos.Select(p => p.Nome).FirstOrDefault();
                //O retorno já é uma string, logo, lá em cima no writeLine não preciso colocar o ToString().
                //O Select nesse caso seleciona apenas as info de 1 coluna, não precisando da classe DTO do produto
                // e se vc quiser a lista disso é só criar o método lista dele.
            }

            static List<Produto> RetornaProdutoInicioLetraListaOrdenada()
            {
                return listaProdutos
                    .Where(prod => prod.Nome.Substring(0, 1).ToLower() == "c".ToLower())
                    .OrderBy(prod => prod.Id)
                    .ToList();
                //Aqui só estou mostrando que posso escrever/identar dessa maneira quando as coisas ficam
                // grandes demais para colocar em 1 linha apenas
                // dessa forma também fica bastante visível o que está acontecendo.
            }

            var val = listaProdutos.Min(prod => prod.Valor); // pega o menor valor
            var vId = listaProdutos.Max(prod => prod.Id); //pega o maior ID
            var vNome = listaProdutos.Min(n => n.Nome); //vai seguir a ordem alfabetica

            Write("\nMin valor: ");
            WriteLine(val);
            Write("Min nome: ");
            WriteLine(vNome);
            Write("Max ID: ");
            WriteLine(vId);

            //O Average calcula a média do que quer que você coloque ali (numerico)
            var media = listaProdutos.Average(prod => prod.Valor);
            Write("Media de valores de todos os produtos da lista: ");
            WriteLine(media);

            static List<Produto> RetornoListaOrdenadaTop3()
            {
                return listaProdutos.OrderBy(prod => prod.Id).Take(3).ToList();
                //O ".Take(3)" ou qualquer número, dá pra usar aninhado, e é interessante
                //pq ele traz os topN itens que vc deseja.
            }

            //O Any() traz um booleano que diz se o que está dentro do lambda é verdadeiro.
            var tst = listaProdutos.Any(prod => prod.Ativo == false);
            WriteLine("");
            WriteLine(tst);
            //Se usar o Any() vazio, ele retorna, por ex se existe algum elemento dentro da lista ou não etc 


            

        }


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

        public class ProdutoDto
        {
            public string NomeProduto { get; set; }

            public decimal ValorProduto { get; set; }

            public override string ToString()
            {
                return $"Nome: {NomeProduto} | Valor: {ValorProduto}";
            }
        }
    }
}