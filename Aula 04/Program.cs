using System.Collections;

ArrayList sistemaSolar = new ArrayList() {"Mercúrio", "Marte"};
sistemaSolar.Add("Júpiter");
sistemaSolar.Add("Saturno");

List<string> solarSistem = new List<string>() {"Mercúrio", "Marte"};
solarSistem.Add("Júpiter");
solarSistem.Add("Saturno");

foreach (string p in sistemaSolar)
{
    Console.WriteLine(p);
}

ArrayList ultimosPlanetasSS = new ArrayList() {"Urano", "Netuno"};
List<string> lastPlanetSS = new List<string>() {"Urano", "Netuno"};

sistemaSolar.AddRange(ultimosPlanetasSS);
solarSistem.AddRange(lastPlanetSS);

Console.WriteLine("");
foreach (string p in sistemaSolar)
{
    Console.WriteLine(p);
}

//Cuidado, se for inserir terra antes de vênus, vai bagunçar o indice
sistemaSolar.Insert(1, "Venus");
sistemaSolar.Insert(2, "Terra");
solarSistem.Insert(1, "Venus");
solarSistem.Insert(2, "Terra");

sistemaSolar.Add("Plutão");
solarSistem.Add("Plutão");

Console.WriteLine("");
foreach (string p in sistemaSolar)
{
    Console.WriteLine(p);
}

ArrayList planetasRochosos = new ArrayList();
List<string> rockyPlanets = new List<string>();

//Mercúrio, Vênus, Terra, Marte
//adicionando os 4 primeiro planetas, que coincidentemente são os rochosos
//vai do indice 0 (indice que começa) e pega os 4 (planetas seguidos)
planetasRochosos = sistemaSolar.GetRange(0, 4);
rockyPlanets = solarSistem.GetRange(0, 4);

//Dois tipos de remover, por nome ou numero
sistemaSolar.RemoveAt(sistemaSolar.Count - 1);
solarSistem.Remove("Plutão");

Console.WriteLine("");
foreach (string p in sistemaSolar)
{
    Console.WriteLine(p);
}

Console.WriteLine("");
foreach (string pr in planetasRochosos)
{
    Console.WriteLine(pr);
}

/*
 * Forma de conseguir ver o planetasRochosos pois o foreach estoura um erro
 * ArrayList planetasRochosos = new ArrayList(planetas.GetRange(0, 4));
 */


/*
 * Nota: quando vc coloca tudo dentro do arraylist, o programa
 * pega o que vc deu Add, converte para um tipo "object" e guarda.
 * Quando vc precisa recuperar a informação, o programa precisa
 * pegar o 'object' e reconverter para o tipo dele normal
 * 
 * por isso usar lista fortemente tipada pe vantajoso pois hpa ganho de performance
 * 
 * obs: os nomes para o que o arraylist faz é boxing (int>object)
 * e unboxing (object >int)
 * 
 * 
 */
