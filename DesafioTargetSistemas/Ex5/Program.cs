string str, strInvertida = "";
Console.WriteLine("Digite uma palavra:");
str = Console.ReadLine();

for (int i = str.Length - 1; i >= 0; i--)
{
    strInvertida += str[i];
}

Console.WriteLine("Palavra Invertida:");
Console.WriteLine(strInvertida);
