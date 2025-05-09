int num1 = 0, numAntFibonacci = 0, numFibonacci = 1;

Console.WriteLine("Digite um numero:");
num1 = int.Parse(Console.ReadLine());

while (num1 > numFibonacci)
{
    int temp = numFibonacci;
    numFibonacci += numAntFibonacci;
    numAntFibonacci = temp;

}
if (num1 == 0 || num1 == numFibonacci)
{
    Console.WriteLine("Faz parte da sequência");
}
else
{
    Console.WriteLine("Não Faz parte da sequência");
}
