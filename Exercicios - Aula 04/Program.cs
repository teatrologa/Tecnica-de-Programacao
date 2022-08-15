using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;


//Exercicio de ArrayList

ArrayList numerosInt = new ArrayList();
ArrayList numerosString = new ArrayList();
int numero;
string numeros;

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

int roll = 0;

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
