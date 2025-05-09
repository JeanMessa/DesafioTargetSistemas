using Ex3;
using System.Text.Json;

string jsonString = File.ReadAllText("../../../../Ex3/dados.json");
double media = 0;
int contDias = 0, contDiasMaiorMedia = 0;
Dados[] vetorDados = JsonSerializer.Deserialize<Dados[]>(jsonString)!;
double menorValor = vetorDados[0].valor, maiorValor = vetorDados[0].valor;
foreach (Dados d in vetorDados)
{
    if (d.valor < menorValor)
    {
        menorValor = d.valor;
    }
    if (d.valor > maiorValor)
    {
        maiorValor = d.valor;
    }
    if (d.valor != 0)
    {
        media += d.valor;
        contDias++;
    }
}

media /= contDias;
foreach (Dados d in vetorDados)
{
    if (d.valor > media)
    {
        contDiasMaiorMedia++;
    }
}

Console.WriteLine($"Maior Valor: {maiorValor}");
Console.WriteLine($"Menor Valor: {menorValor}");
Console.WriteLine($"Dias Acima da Média: {contDiasMaiorMedia}");