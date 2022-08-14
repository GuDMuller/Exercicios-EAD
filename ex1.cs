
//AVISO!!! TIRAR OS COMENTARIOS PARA CADA QUESTÃO !

using System.Buffers.Text;

Console.WriteLine("Digite três valores para A,B e C: ");
string valor = Console.ReadLine();

string[] valores = valor.Split(" ");

string primeiroValor = valores[0] ;
string segundoValor = valores[1];
string terceiroValor = valores[2];

float A = float.Parse(primeiroValor);
float B = float.Parse(segundoValor);
float C = float.Parse(terceiroValor);

//QUESTÃO A

//float areaTriangulo = (A * C) / 2;
//Console.WriteLine("A área é: " + areaTriangulo);

// QUESTÃO B 

//float areaCirculo = 3.14f * (C * C);
//Console.WriteLine("A área do círculó é: " + areaCirculo);

//QUESTÃO C 

//float areaTrapezio = ((A + B) * C) / 2;
//Console.WriteLine("A área do trapézio é: " + areaTrapezio);

//QUESTÃO D 

//float areaQuadrado = B * B;
//Console.WriteLine("A área do quadrado é: "+ areaQuadrado);

//QUESTÃO E

//float areaRetangulo = A * B;
//Console.WriteLine("A área do retângulo é: "+areaRetangulo);


