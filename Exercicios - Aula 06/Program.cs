using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Aula_06_Exercicios
{
    class Program
    {
        private static List<Produto> listaProdutos = new()
        {
            new Produto { Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
            new Produto { Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
            new Produto { Id = 4, Nome = "Celular", Valor = 8500, Ativo = true },
            new Produto { Id = 3, Nome = "Arroz", Valor = 21, Ativo = false },
            new Produto { Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true },
            new Produto { Id = 9, Nome = "Panela", Valor = 41, Ativo = true },
            new Produto { Id = 5, Nome = "Chinelo", Valor = 11, Ativo = false },
            new Produto { Id = 7, Nome = "TV", Valor = 2350, Ativo = true },
            new Produto { Id = 6, Nome = "Patins", Valor = 66, Ativo = true },
            new Produto { Id = 10, Nome = "Espelho", Valor = 115, Ativo = true },
        };
        

        static void Main(string[] args)
        {
            //Visualizações do método 1:
            //WriteLine("Busque produtos de acordo com a ultima letra do seu nome\nPor exemplo, digite: o");
            //char input = Convert.ToChar(ReadLine());
            char input = 'o';
            var ret = RetornarProdutoUltimaLetra(input);
            if (ret.Count() > 1)
            {
                WriteLine("Os produtos cuja ultima letra é 'o' são:");
                foreach (Produto prod in ret)
                {
                    WriteLine(prod.ToString());
                }
            } else if (ret.Count == 1)
            {
                WriteLine("O produto cuja ultima letra é 'o' é:");
                foreach (Produto prod in ret)
                {
                    WriteLine(prod.ToString());
                }
            }
            else { WriteLine("Não há nenhum produto cuja ultima letra é 'o'."); }
            
            WriteLine("");

            //Visualização do método 2:
            var valor = RetornarValorMenor50();
            WriteLine("Lista de produtos com valor abaixo de 50:"); //Preguiça de fazer os if como os de cima. Mas é possível.
            foreach(Produto v in valor)
            {
                WriteLine(v.ToString());
            }

            WriteLine("");

            //Visualização do método 3:
            var media = RetornarMediaProdInativos();
            Write("A média de valor dos produtos inativos é: ");
            WriteLine(media.ToString());

            WriteLine("");

            //Visualização do método 4:
            var retorno = PrimeiroProdutoMenor10();
            Write("O primeiro produto inserido no sistema cujo valor é inferior a 10 é: ");
            if (retorno != null)
            {
                WriteLine(retorno.ToString());
            }
            else { WriteLine($"{retorno} - Não existe"); }

            WriteLine("");

            //Visualização do método 5:
            var num = UltimoProdutoOrdemDecrescente();
            WriteLine("O último produto em ordem alfabética decrescente é: ");
            if (num != null)
            {
                WriteLine(num.ToString());
            }
            else { WriteLine(num); }

            WriteLine("");

            //Visualização do método 6:
            Write("Insira o indice do produto que você deseja alterar o valor: ");
            int id = Convert.ToInt32(ReadLine());
            Write("Insira o novo valor do produto: ");
            decimal newValor = Convert.ToDecimal(ReadLine());

            if (listaProdutos.Any(p => p.Id == id))
            {
                AtualizarValorProduto(id, newValor);
                var produtinho = RetornarProdutoIndice(id);
                WriteLine($"O produto {produtinho.Nome} foi atualizado com sucesso!");
                WriteLine(produtinho.ToString());
            }
            else
            {
                WriteLine($"Foi impossível encontrar o produto de id: {id}");
            }

        }



        //Exercício 1 - Método 1
        public static List<Produto> RetornarProdutoUltimaLetra(char input)
        {
            return listaProdutos.Where(prod => prod.Nome.EndsWith(input)).ToList();
            //o VS sugere que após o EndsWith tenha o .Equals(true)
            // porém não tenho certeza do que ele faz
        }

        //Exercício 2 - Método 2
        public static List<Produto> RetornarValorMenor50()
        {
            return listaProdutos.Where(prod => prod.Valor < 50).ToList();
        }

        //Exercício 3 - Método 3
        public static decimal RetornarMediaProdInativos()
        {
            return listaProdutos.Where(p => p.Ativo == false).Average(p => p.Valor);
        }

        //teste mal sucedido do exercício 3, caso não haja nenhum item inativo
        public static decimal RetornarMediaProdInativo()
        {
            var teste = listaProdutos.Where(p => p.Ativo == false);
            if (teste != null)
            {
                return listaProdutos.Where(p => p.Ativo == false).Average(p => p.Valor);
            }
            else { return 0; }
        }

        //Exercício 4 - Método 4
        public static Produto PrimeiroProdutoMenor10()
        {
            return listaProdutos.Where(p => p.Valor < 10).FirstOrDefault();
        }

        //Exercício 5 - Método 5
        public static Produto UltimoProdutoOrdemDecrescente()
        {
            return listaProdutos.OrderByDescending(p => p.Nome).LastOrDefault();
        }

        //Exercício 6.1 - Método 6.1
        public static void AtualizarValorProduto(int id, decimal valor)
        {
            //Seleciono o produto que quero aqui, de acordo com seu indice.
            Produto produto = listaProdutos.Where(p => p.Id == id).Select(p => p).FirstOrDefault();

            if (produto != null)
            {
                produto.Valor = valor;
                //return produto.ToString();
            }

            //return $"Não há nenhum produto com o indice {id}";
        }

        //Exercício 6.2 - Método 6.2
        public static Produto RetornarProdutoIndice(int id)
        {
            return listaProdutos.SingleOrDefault(p => p.Id == id);
        }

    }
}