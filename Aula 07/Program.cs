using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listApi = new()
            {
                "api1.json",
                "api2.json",
                "api3.xml",
                "api4.json"
            };

            string fileApi = "apiI.json";

            Stopwatch stopwatch = new();
            stopwatch.Start();

            ParallelOptions parOpt = new();
            parOpt.MaxDegreeOfParallelism = 7; //Utilizado no exercício 01

            //Metodo 1.1
            Parallel.For(0, 100, parOpt, i =>
            {
                GetAPI(fileApi);
            });

            ////Metodo 1.2
            Parallel.For(0, 25, parOpt, i =>
            {
                foreach (var item in listApi)
                {
                    GetAPI(item);
                }
            });

            ////Metodo 1.3
            Parallel.For(0, 100, parOpt, i =>
            {
                GetAPI(listApi[1]);
            });


            //Testes e tempos:
            //1 - Tempo total: 16944 milissegundos(com paralel 100x1 = 100)
            //1 - Tempo total: 32184 milissegundos(com paralel 100x1 = 100 + 7 threads)
            //2 - Tempo total: 16217 milissegundos(com paralel + foreach +list 25x4 = 100)
            //2 - Tempo total: 48320 milissegundos(com paralel + foreach +list 25x4 = 100 + 7 threads)
            //3 - Tempo total: 20230 milissegundos(com paralel + list[1] 100x1 = 100)
            //3 - Tempo total: 32203 milissegundos(com paralel + list[1] 100x1 = 100 + 7 threads)


            stopwatch.Stop();


            Stopwatch stopwatchs = Stopwatch.StartNew();

            Console.WriteLine("Insira a quantidade de threads que você gostaria de empregar nesta execussão: [ex: 5]");
            int threads = Convert.ToInt32(Console.ReadLine());
            ExecutarMetodos(threads);

            stopwatchs.Stop();




            Console.WriteLine($"Tempo total: {stopwatchs.ElapsedMilliseconds} milissegundos");
        }

        public static void GetAPI(string api)
        {
            Thread.Sleep(2000); //Dado em 'milissegundos'
            Console.WriteLine($"Download concluido com sucesso: {api} já pode ser usado!");
        }

        public static void AcertarBaseDeDados()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Base de dados acertada.");
            ;
        }

        public static void EnviarEmail()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Email enviado!");
        }

        public static void LimparArquivosTemporarios()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Limpeza de cache concluida.");
        }

        public static void ExecutarMetodos(int qnt)
        {
            ParallelOptions opt = new ParallelOptions();
            opt.MaxDegreeOfParallelism = qnt;

            Parallel.Invoke(opt, 
                () => AcertarBaseDeDados(),
                () => EnviarEmail(),
                () => LimparArquivosTemporarios()
            );
        }
    }
}