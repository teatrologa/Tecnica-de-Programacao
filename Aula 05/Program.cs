using System.Text.RegularExpressions;



//Exercício 01

//List<char> vogais = new List<char>()
//{ 'A', 'a', 'E', 'e', 'i', 'I', 'o', 'U', 'u', 'á', 'Á', 'à',
//    'À', 'ã', 'Ã', 'é', 'É', 'È', 'í', 'Í', 'õ', 'Õ',
//    'ó', 'Ó', 'ú', 'Ú', 'ü', 'Ü', 'â', 'Â', 'ê', 'Ê', 'ô', 'Ô' };


//Dictionary<char, int> firstDicionario= new Dictionary<char, int>();

//int valor=1;
//var teste = Console.ReadLine();

//foreach (var i in teste)
//{
//    int aux;
//    if (vogais.Contains(i))
//    {
//        if (firstDicionario.ContainsKey(i))
//        {
//            aux = firstDicionario[i] + 1;
//            firstDicionario.Remove(i);
//            firstDicionario.Add(i, aux);
//        }
//        else
//        {
//            firstDicionario.Add(i, valor);
//        }
        
//    }
//}


//foreach (KeyValuePair<char, int> item in firstDicionario)
//{
//    if (item.Value == 1)
//    {
//        Console.WriteLine($"A letra {item.Key} aparece {item.Value} vez na frase!");
//    }
//    else
//    {
//        Console.WriteLine($"A letra {item.Key} aparece {item.Value} vezes na frase!");
//    }
//}









//Exercício 02


Dictionary<string, string> secondDici = new Dictionary<string, string>();
List<string> frase = new List<string>();
secondDici.Add("if", "se");
secondDici.Add("while", "enquanto");
secondDici.Add(">", "maior que");
secondDici.Add("<", "menor que");
secondDici.Add("<=", "menor igual que");
secondDici.Add(">=", "maior que");
secondDici.Add("==", "igual a");
secondDici.Add("!=", "diferente de");

Console.WriteLine("Insira um comando matemático basico abaixo:\n" +
    "Lembre-se de dar todos os espaços, incluindo quando for necessário\n" +
    "o uso de parênteses. Exemplo: if ( 4 <= 3 ) faça carinho no gato ");
string input = Console.ReadLine();

foreach (var i in input.Split(" "))
{
    string aux;
    if (secondDici.ContainsKey(i))
    {
        aux = i.Replace(i, secondDici[i]);
        frase.Add(aux);
    } else
    {
        frase.Add(i);
    }

}

//Verificação do que foi adicionado na lista.
//foreach (var i in frase)
//{
//    Console.WriteLine(i);
    
//}

Console.WriteLine(String.Join(" ", frase));



