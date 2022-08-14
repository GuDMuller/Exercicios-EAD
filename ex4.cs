Console.WriteLine("Informe sua nota: ");
string valor = Console.ReadLine();

int nota = int.Parse(valor);

if(nota >= 7 ){
    Console.WriteLine("Aprovado!");

}else if(nota < 7 & nota >= 4){
    Console.WriteLine("Em recuperação! ");

}
else
{
    Console.WriteLine("Reprovado!");
}

