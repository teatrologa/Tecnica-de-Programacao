using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;


//Exercicio de ArrayList

//ArrayList numerosInt = new ArrayList();
//ArrayList numerosString = new ArrayList();
//int numero;
//string numeros;
//int roll = 0;

//Console.WriteLine("Crie uma lista de números inteiros. Siga o formato:\n    1, 2, 3, 4 ...\nDê 'Enter' quando ela estiver acabada.");
//numeros = Console.ReadLine();
//numerosString.AddRange(numeros.Split(","));
//foreach (string str in numerosString)
//{
//    numero = Convert.ToInt32(str);
//    numerosInt.Add(numero);
//}

//Console.WriteLine("Agora, vamos buscar por um numero dentro desta lista. Digite-o abaixo: ");
//numero = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(" ");
//foreach (int i in numerosInt)
//{
    
//    if (i == numero)
//    {
//        Console.WriteLine($"O numero {numero} aparece no indice: {roll}");
//    };
//    roll++;
//}


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
    nums.Split(",");

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