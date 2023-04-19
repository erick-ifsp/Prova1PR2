using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;

            for (int i = 0; ; i++)
            {
                Console.WriteLine("\nqual o programa que voce deseja executar? \ndigite 0 para finalizar\n");
                program = int.Parse(Console.ReadLine());

                if (program == 0)
                {
                    break;
                }

                switch (program)
                {
                    case 1:
                        int num, numab;

                        Console.WriteLine("digite o valor do número desejado:");
                        num = int.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            numab = num;
                        }
                        else
                        {
                            numab = num * (-1);
                        }
                        Console.WriteLine("o número absoluto é: " + numab);
                        break;


                    case 2:
                        int n;

                        Console.WriteLine("digite o número desejado:");
                        n = int.Parse(Console.ReadLine());

                        if (n % 5 == 00 && n % 3 == 0)
                        {
                            Console.WriteLine("este numero é multiplo de 3 e 5");
                        }
                        else
                        {
                            if (n % 3 == 0)
                            {
                                Console.WriteLine("este numero é divisivel por 3");
                            }
                            if (n % 5 == 0)
                            {
                                Console.WriteLine("este numero é divisivel por 5");
                            }
                            if (n % 5 != 0 && n % 3 != 0)
                            {
                                Console.WriteLine("este numero é nao divisivel por 3 e nem por 5");
                            }
                        }
                        if (n % 7 == 0 && n % 4 == 0)
                        {
                            Console.WriteLine("este numero é multiplo de 4 e 7");
                        }
                        else
                        {
                            if (n % 4 == 0)
                            {
                                Console.WriteLine("este numero é divisivel por 4");
                            }
                            if (n % 7 == 0)
                            {
                                Console.WriteLine("este numero é divisivel por 7");
                            }
                            if (n % 4 != 0 && n % 7 != 0)
                            {
                                Console.WriteLine("este numero é nao divisivel por 4 e nem por 7");
                            }
                        }
                        break;

                    case 3:
                        int numero, maior;
                        Console.WriteLine("digite um numero:");
                        maior = int.Parse(Console.ReadLine());

                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine("digite um numero");
                            numero = int.Parse(Console.ReadLine());
                            if (numero > maior)
                                maior = numero;
                        }
                        Console.WriteLine("O maior numero é: " + maior);
                        break;

                    case 4:
                        int d;
                        Console.WriteLine("digite um numero que represente um dia da semana:");
                        d = int.Parse(Console.ReadLine());
                        switch (d)
                        {
                            case 1:
                                Console.WriteLine("domingo: gosto de assistir séries e estudar para PR2");
                                break;

                            case 2:
                                Console.WriteLine("segunda-feira: na segunda-feira assisto aula de filosofia, português e matemática");
                                break;

                            case 3:
                                Console.WriteLine("terça-feira: na terça-feira assisto aula de química, história e inglês para o mundo da informática");
                                break;

                            case 4:
                                Console.WriteLine("quarta-feira: na quarta-feira assisto aula de biologia, português e programação");
                                break;

                            case 5:
                                Console.WriteLine("quinta-feira: na quinta-feira assisto aula de física, redes de computador e sociologia");
                                break;

                            case 6:
                                Console.WriteLine("sexta-feira: na sexta-feira assisto aula de geografia, matemática e banco de dados");
                                break;

                            case 7:
                                Console.WriteLine("sábado: gosto de desenhar e jogar zelda");
                                break;

                            default:
                                Console.WriteLine("O numero é inválido");
                                break;
                        }
                        break;

                    case 5:
                        int numm, nmaior, nmenor;
                        Console.WriteLine("digite um numero:");
                        nmaior = int.Parse(Console.ReadLine());
                        nmenor = nmaior;
                        numm = 0;
                        for (int j = 0; ; j++)
                        {
                            Console.WriteLine("digite um numero (digite 0 para finalizar)");
                            numm = int.Parse(Console.ReadLine());
                            if (numm == 0)
                            {
                                break;
                            }
                            if (numm > nmaior)
                                maior = numm;
                            if (numm < nmenor)
                                nmenor = numm;
                        }
                        Console.WriteLine("O menor numero é: " + nmenor + " e o maior é: " + nmaior);
                        break;

                    case 6:
                        int nump, soma;
                        Console.WriteLine("digite um numero:");
                        nump = int.Parse(Console.ReadLine());
                        soma = 0;
                        for (i = 1; i < nump; i++)
                        {
                            if (nump % i == 0)
                            {
                                soma = soma + i;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        if (soma == nump)
                        {
                            Console.WriteLine("o numero " + soma + " é perfeito");
                        }
                        else
                        {
                            Console.WriteLine("este numero não é perfeito");
                        }
                        break;

                    case 7:
                        double numint, nn, media;
                        media = 0;
                        nn = 0;
                        for (i = 0; ; i++)
                        {
                            Console.WriteLine("digite um numero (digite 0 para finalizar)");
                            numint = double.Parse(Console.ReadLine());

                            if (numint == 0)
                            {
                                break;
                            }

                            if (numint % 2 == 0)
                            {
                                nn = nn + numint;
                                media = media + 1;
                            }
                            else
                            {
                                nn = 0;
                            }
                        }
                        if (nn == 0)
                        {
                            Console.WriteLine("não há numeros pares na sequência");
                        }
                        media = nn / media;
                        Console.WriteLine("a média aritmética da sequência é: " + media);
                        break;

                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }
        }
    }
}