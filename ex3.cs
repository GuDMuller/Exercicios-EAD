Console.WriteLine("Informe a estimativa otimista, pessimista e provável:   ");
string estimativa = Console.ReadLine();

string[] valores = estimativa.Split(" ");

string primeiroValor = valores[0];
string segundoValor = valores[1];
string terceiroValor = valores[2];

float otimista = float.Parse(primeiroValor);
float pessimista = float.Parse(segundoValor);
float provavel = float.Parse(terceiroValor);

float tempoEsperado =  (otimista + pessimista +  4 * provavel) / 6;

Console.WriteLine("Otimista: "+ otimista + "\nPessimista: "+ pessimista+ " \nProvável: " + provavel + " \nPERT: " + tempoEsperado);