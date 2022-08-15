// EXERCÍCIO 2

Console.Write("Insira o valor de A:  ");
int A = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de B: ");
int B = int.Parse(Console.ReadLine());
string validaMultiplos(int A, int B) => A % B == 0 || B % A == 0 ? "São Múltiplos" : "Não são Múltiplos";
Console.WriteLine(validaMultiplos(A, B));
