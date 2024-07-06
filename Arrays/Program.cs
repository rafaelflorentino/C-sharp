
// Vetor = Array Unidimencional

int[] arrayInteiros = new int[4];
arrayInteiros[0] = 1;

Console.WriteLine(arrayInteiros[0]);

int[] arrayComValores = new int[4] { 0, 1, 2, 3 };
Console.WriteLine(arrayComValores[3]);

// Outra maneira

int[] numeros = { 10, 20, 30 };
Console.WriteLine(numeros[2]); // 30

string[] nomes = { "Claudia", "Cris" };
Console.WriteLine(nomes[1]); // Cris


// Percorrer array
string[] alunos = new string[]{
    "Claudia",
    "Cris",
    "Arthur"
};

for (var itemDoArray = 0; itemDoArray < alunos.Length; itemDoArray++)
{
    Console.WriteLine(alunos[itemDoArray]);
}

