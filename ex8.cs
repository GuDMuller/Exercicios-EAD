//Exercicio 08

int opcao = 0;
int votosChaves = 0;
int votosChiquinha = 0;
int votosQuico = 0;
int votosNulo = 0;

do
{
    Console.WriteLine("As opções são: ");
    Console.WriteLine("1. Candidato Chaves");
    Console.WriteLine("2. Candidata Chiquinha");
    Console.WriteLine("3. Candidato Quico");
    Console.WriteLine("4. Nulo/Branco");
    Console.WriteLine("5. Encerrar a Votação");
    Console.Write("Entre com o seu voto: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            votosChaves++;
            break;
        case 2:
            votosChiquinha++;
            break;
        case 3:
            votosQuico++;
            break;
        case 4:
            votosNulo++;
            break;
        case 5:
            Console.WriteLine();
            Console.WriteLine("Número de votos de cada candidato: ");
            Console.WriteLine("Candidato Chaves: " + votosChaves);
            Console.WriteLine("Candidata Chiquinha: " + votosChiquinha);
            Console.WriteLine("Candidato Quico: " + votosQuico);
            Console.WriteLine("Candidato Nulo: " + votosNulo);
            Console.WriteLine("Candidato Branco: " + votosNulo);

            int votosTotal = votosChaves + votosChiquinha + votosQuico + votosNulo;
            double percentNulo = (votosNulo * 100) / votosTotal;

            Console.WriteLine("Porcentagem de votos Nulo/Branco: " + percentNulo + "%");
            Console.WriteLine("----------------");
            Console.WriteLine();

            string vencedor(int chaves, int quico, int chiquinha) => chaves > chiquinha && chaves > quico ? "Chaves" : chiquinha > chaves && chiquinha > quico ? "Chiquinha" : "Quico!";
            Console.WriteLine($"O candidato vencedor é: {vencedor(votosChaves, votosQuico, votosChiquinha)}");

            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 5);

