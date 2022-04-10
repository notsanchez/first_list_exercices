using System;


// 888b     d888          888    888                                      888b     d888                   888                    888          
// 8888b   d8888          888    888                                      8888b   d8888                   888                    888          
// 88888b.d88888          888    888                                      88888b.d88888                   888                    888          
// 888Y88888P888  8888b.  888888 88888b.   .d88b.  888  888 .d8888b       888Y88888P888  8888b.   .d8888b 88888b.   8888b.   .d88888  .d88b.  
// 888 Y888P 888     "88b 888    888 "88b d8P  Y8b 888  888 88K           888 Y888P 888     "88b d88P"    888 "88b     "88b d88" 888 d88""88b 
// 888  Y8P  888 .d888888 888    888  888 88888888 888  888 "Y8888b.      888  Y8P  888 .d888888 888      888  888 .d888888 888  888 888  888 
// 888   "   888 888  888 Y88b.  888  888 Y8b.     Y88b 888      X88      888   "   888 888  888 Y88b.    888  888 888  888 Y88b 888 Y88..88P 
// 888       888 "Y888888  "Y888 888  888  "Y8888   "Y88888  88888P'      888       888 "Y888888  "Y8888P 888  888 "Y888888  "Y88888  "Y88P"  


namespace media_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o numero do exercicio: ");
            double opcao = double.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    double baseT, altura, area;
                    Console.Clear();
                    Console.WriteLine("Digite a base do triangulo: ");
                    baseT = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do triangulo: ");
                    altura = Double.Parse(Console.ReadLine());
                    area = baseT * altura;

                    Console.Clear();
                    Console.WriteLine("area do triangulo: " + area);
                    break;
                case 2:
                    double x, y;
                    Console.WriteLine("Digite um número: ");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um número: ");
                    y = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Soma: ");
                    Console.WriteLine(x + y);
                    Console.WriteLine("Subtração: ");
                    Console.WriteLine(x - y);
                    Console.WriteLine("Multiplicação: ");
                    Console.WriteLine(x * y);
                    Console.WriteLine("Divisão: ");
                    Console.WriteLine(x / y);

                    break;
                case 3:
                    string nome;
                    double salariofix, comissao, comissa1, vendas;
                    Console.Clear();
                    Console.WriteLine("Digite o nome do vendedor: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o salario fixo: ");
                    salariofix = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o total das vendas (em dinheiro): ");
                    vendas = double.Parse(Console.ReadLine());

                    comissao = 20.0 / 100.0;
                    comissa1 = salariofix + (comissao * vendas);

                    Console.Clear();
                    Console.WriteLine("Nome:" + nome);
                    Console.WriteLine("Salario fixo: " + "R$" + salariofix);
                    Console.WriteLine("Salario no final do mês: " + "R$" + comissa1);
                    break;
                case 4:
                    double nota1, nota2, nota3, media, mediafinal, divisao;

                    Console.WriteLine("Nome do aluno: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Nota da prova 1 (Peso 2): ");
                    nota1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nota da prova 2 (Peso 4): ");
                    nota2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nota da prova 3 (Peso 6): ");
                    nota3 = double.Parse(Console.ReadLine());

                    media = (2 * nota1 + 4 * nota2 + 6 * nota3);
                    divisao = 2 + 4 + 6;

                    mediafinal = media / divisao;

                    Console.Clear();
                    Console.WriteLine(nome);
                    Console.WriteLine(mediafinal);
                    break;
                case 5:

                    double num5, num6;

                    Console.WriteLine("Digite o valor de x: ");
                    num5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de y: ");
                    num6 = double.Parse(Console.ReadLine());

                    if (num5 > num6)
                    {
                        Console.WriteLine(num5);
                    }
                    else
                    {
                        Console.WriteLine(num6);
                    }


                    break;
                case 6:
                    double num7;

                    Console.WriteLine("Digite um numero:");
                    num7 = double.Parse(Console.ReadLine());

                    if (num7 < 300 && num7 > 200)
                    {
                        Console.WriteLine("Esta no intervalo:)");
                    }
                    else
                    {
                        Console.WriteLine("Nao esta no intervalo:(");
                    }

                    break;
                case 7:
                    double copias;

                    Console.Clear();
                    Console.WriteLine("Digite o total de cópias");
                    copias = double.Parse(Console.ReadLine());

                    if (copias > 200)
                    {
                        Console.Clear();
                        Console.WriteLine("Valor total: " + copias * 0.50);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Valor total: " + copias * 0.30);
                    }
                    break;
                case 8:

                    double idade;

                    Console.WriteLine("Digite a idade do jogador: ");
                    idade = double.Parse(Console.ReadLine());

                    if (idade <= 13)
                    {
                        Console.Clear();
                        Console.WriteLine("Infantil");
                    }
                    if (idade <= 17 && idade > 13)
                    {
                        Console.Clear();
                        Console.WriteLine("Juvenil");
                    }
                    if (idade > 17)
                    {
                        Console.Clear();
                        Console.WriteLine("Senior");
                    }
                    break;
                case 9:

                    double num9, num10;

                    Console.WriteLine("Digite o primeiro numero: ");
                    num9 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    num10 = double.Parse(Console.ReadLine());

                    if (num9 > num10)
                    {
                        Console.WriteLine("O maior numero é: " + num9);
                    }
                    else
                    {
                        Console.WriteLine("O maior numero é: " + num10);
                    }

                    break;
                case 10:

                    double num11, num12, num13;

                    Console.WriteLine("Digite o primeiro numero: ");
                    num11 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero: ");
                    num12 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro numero: ");
                    num13 = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Média final: " + (num11 + num12 + num13) / 3);

                    break;
                case 11:
                    int num1;
                    Console.Write("Digite: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine("Par");
                    }
                    else
                    {
                        Console.WriteLine("Impar");
                    }
                    Console.ReadKey();
                    break;
                case 12:

                    string nome12;

                    Console.WriteLine("Digite o nome: ");
                    nome12 = Console.ReadLine();
                    Console.WriteLine("Digite a primeira nota: ");
                    num11 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a segunda nota: ");
                    num12 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a terceira nota: ");
                    num13 = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Nome: " + nome12);
                    Console.WriteLine("Média final: " + (num11 + num12 + num13) / 3);
                    break;
                case 13:
                    Console.WriteLine("Digite um numero:");
                    num7 = double.Parse(Console.ReadLine());

                    if (num7 < 200 && num7 > 100)
                    {
                        Console.WriteLine("Esta no intervalo:)");
                    }
                    else
                    {
                        Console.WriteLine("Nao esta no intervalo:(");
                    }
                    break;
                case 14:
                    double C, F;

                    Console.WriteLine("Digite a temperatura em Celsius");
                    C = double.Parse(Console.ReadLine());

                    F = (9 * C + 160) / 5;

                    Console.WriteLine(F);

                    break;
                case 15:
                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    F = double.Parse(Console.ReadLine());

                    C = ((F - 32) * 5) / 9;

                    Console.WriteLine(C);

                    break;
                case 16:

                    double a1, b1, c1, aux;

                    Console.WriteLine("Digite o valor de A");
                    a1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor de B");
                    b1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor de C");
                    c1 = double.Parse(Console.ReadLine());

                    if (a1 > b1)
                    {
                        aux = a1;
                        a1 = b1;
                        b1 = aux;
                    }

                    if (a1 > c1)
                    {
                        aux = a1;
                        a1 = c1;
                        c1 = aux;
                    }
                    if (b1 > c1)
                    {
                        aux = b1;
                        b1 = c1;
                        c1 = aux;
                    }

                    Console.WriteLine("Valores ordenados: " + a1 + ", " + b1 + ", " + c1);

                    break;

                case 17:
                    double nota4;

                    Console.WriteLine("Nome do aluno: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Nota da prova 1: ");
                    nota1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nota da prova 2: ");
                    nota2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nota da prova 3: ");
                    nota3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nota da prova 4: ");
                    nota4 = double.Parse(Console.ReadLine());

                    media = ((nota1 + nota2 + nota3 + nota4) / 4);
                    if(media >= 5)
                    {
                        Console.WriteLine("Nome do aluno: "+nome);
                        Console.WriteLine("Média final: " + media);
                        Console.WriteLine("Aluno Aprovado:)");
                    }
                    else
                    {
                        Console.WriteLine("Nome do aluno: " + nome);
                        Console.WriteLine("Média final: " + media);
                        Console.WriteLine("Aluno Reprovado:(");
                    }
                    break;
                case 18:

                    double num18, num19, operacao;

                    Console.WriteLine("Digite o primeiro valor: ");
                    num18 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor: ");
                    num19 = double.Parse(Console.ReadLine());

                    if(num18 > num19)
                    {
                        operacao = (num18 - num19);
                        Console.WriteLine("Diferença do maior para o menor: "+operacao);
                    
                    }
                    else
                    {
                        operacao = (num19 - num18);
                        Console.WriteLine("Diferença do maior para o menor: " + operacao);
                    }

                    break;
                case 19:

                    int num20 = 1;

                    Console.Clear();
                    while(num20 <= 10)
                    {
                        Console.WriteLine(num20);
                        num20++;
                    }

                    break;
                case 20:

                    num20 = 100;

                    Console.Clear();
                    while (num20 >= 1)
                    {
                        Console.WriteLine(num20);
                        num20--;
                    }
                    break;
            }

        }
    }
}