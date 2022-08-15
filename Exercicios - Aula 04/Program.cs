using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;


//Exercicio de ArrayList

ArrayList numerosInt = new ArrayList();
ArrayList numerosString = new ArrayList();
int numero;
string numeros;
int roll = 0;

Console.WriteLine("Crie uma lista de números inteiros. Siga o formato:\n    1, 2, 3, 4 ...\nDê 'Enter' quando ela estiver acabada.");
numeros = Console.ReadLine();
numerosString.AddRange(numeros.Split(","));
foreach (string str in numerosString)
{
    numero = Convert.ToInt32(str);
    numerosInt.Add(numero);
}

Console.WriteLine("Agora, vamos buscar por um numero dentro desta lista. Digite-o abaixo: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
foreach (int i in numerosInt)
{

    if (i == numero)
    {
        Console.WriteLine($"O numero {numero} aparece no indice: {roll}");
    };
    roll++;
}




//Exercicios de List
//Ex1
List<int> listInt = new List<int>();
string nums;
int soma = 0, contador = 0, num;
bool val = false;
do
{

    Console.WriteLine("Crie uma lista de números inteiros. Siga o formato:\n    1, 2, 3, 4 ...\nDê 'Enter' quando ela estiver acabada.");
    nums = Console.ReadLine();

    if (String.IsNullOrEmpty(nums))
    {
        Console.WriteLine("Entrada inválida, digite 1 ou mais numeros inteiros [ex: 1, 2, 3...]\nDê enter e tente novamente.");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        val = true;
    }


} while (val == false);


foreach (var v in nums.Split(","))
{
    listInt.Add(int.Parse(v));
};


foreach (int i in listInt)
{

    if (i > 0)
    {
        contador++;
    }
    else
    {
        soma += i;
    }

}
Console.WriteLine("");
Console.WriteLine($"Existem {contador} valores positivos.");
Console.WriteLine($"A soma de todos os valores negativos é de: {soma}.");




//Ex2
List<int> valores = new List<int>();
string valString;
int maiorValor, menorValor, resultado;
bool validacaoInput = false;

do
{
    Console.WriteLine("Crie uma lista de números inteiros. Siga o formato:\n    1, 2, 3, 4 ...\nDê 'Enter' quando ela estiver acabada.");
    valString = Console.ReadLine();

    if (String.IsNullOrEmpty(valString))
    {
        Console.WriteLine("Entrada inválida, digite 1 ou mais numeros inteiros [ex: -5, 1, 2, 3...]\nDê enter e tente novamente.");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        validacaoInput = true;
    }

} while (validacaoInput == false);


foreach (var v in valString.Split(","))
{
    valores.Add(int.Parse(v));
    valores.Add(Convert.ToInt32(v));
};

maiorValor = valores.Max();
menorValor = valores.Min();
resultado = (maiorValor) - (menorValor);

Console.WriteLine($"A diferença entre o maior valor ({maiorValor}) e o menor valor ({menorValor}) da sua lista é: {resultado}.");




//Ex3
List<int> numList = new List<int>();
string numString;
bool valInput = false;
int zero = 0, indice = 0, resultBool;

do
{
    Console.WriteLine("Crie uma lista de números inteiros. Siga o formato:\n    1, 2, 3, 4 ...\nDê 'Enter' quando ela estiver acabada.");
    numString = Console.ReadLine();


    if (String.IsNullOrEmpty(numString))
    {
        Console.WriteLine("Entrada inválida, digite 1 ou mais numeros inteiros [ex: -5, 1, 2, 3...]\nDê enter e tente novamente.");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        valInput = true;
    }


} while (valInput == false);

foreach (var v in numString.Split(","))
{
    numList.Add(Convert.ToInt32(v));
};

int numeroProxZero = numList.Aggregate((x, y) => Math.Abs(x - zero) < Math.Abs(y - zero) ? x : y);
Console.WriteLine(numeroProxZero);




if (numList.Count(x => x == numeroProxZero) > 1)
{
    Console.WriteLine("Há 2 ou mais valores equidistrantes de zero (0), logo não há nenhum resultado.");
}
else
{

    Console.WriteLine($"Dentre os numeros da lista, o que mais se aproxima de zero (0) é: {numeroProxZero}");
}
