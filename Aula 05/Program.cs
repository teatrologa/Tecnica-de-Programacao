


using System.Text.RegularExpressions;

List<char> vogais = new List<char>()
{ 'A', 'a', 'E', 'e', 'i', 'I', 'o', 'U', 'u', 'á', 'Á', 'à',
    'À', 'ã', 'Ã', 'é', 'É', 'È', 'í', 'Í', 'õ', 'Õ',
    'ó', 'Ó', 'ú', 'Ú', 'ü', 'Ü', 'â', 'Â', 'ê', 'Ê', 'ô', 'Ô' };


Dictionary<char, int> firstDicionario= new Dictionary<char, int>();

int valor=1;
var teste = Console.ReadLine();

foreach (var i in teste)
{
    int aux;
    if (vogais.Contains(i))
    {
        if (firstDicionario.ContainsKey(i))
        {
            aux = firstDicionario[i] + 1;
            firstDicionario.Remove(i);
            firstDicionario.Add(i, aux);
        }
        else
        {
            firstDicionario.Add(i, valor);
        }
        
    }
}


foreach (KeyValuePair<char, int> item in firstDicionario)
{
    if (item.Value == 1)
    {
        Console.WriteLine($"A letra {item.Key} aparece {item.Value} vez na frase!");
    }
    else
    {
        Console.WriteLine($"A letra {item.Key} aparece {item.Value} vezes na frase!");
    }
        

}


