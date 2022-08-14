
using System;

Console.WriteLine("Digite um valor: ");
string valor = Console.ReadLine();
int numero = int.Parse(valor);

if(numero == 0)
{
    Console.WriteLine("O fatorial de 0 é 1 ");
}
else
{
    while (numero > 0)
    {
        int n = numero;
        for (int i = n - 1; i > 0; i--)
        {
            n *= i;
        }
        Console.WriteLine("O fatorial de {0}! é = {1}\n", numero, n);
        break;
    }
}
