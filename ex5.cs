Console.WriteLine("Informe um input de 1 a 3: ");
string valor = Console.ReadLine();

int input = int.Parse(valor);

switch(input){
    case 1:
        Console.WriteLine("Bom dia!");
        break;
    case 2:
        Console.WriteLine("Boa tarde!");
        break ;
    case 3:
        Console.WriteLine("Boa noite!");
        break;
}   

