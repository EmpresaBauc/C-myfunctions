using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_AED
{
    class Program
    {

        static int FatorialRecursivo(int n) 
        {
            if (n == 0 || n == 1)
            {
                return (1);
            }
            else
            {
                return (n * FatorialRecursivo(n - 1));
            }

        }
        static int somaInteirosPositivos(int n)
        {
            if (n > 0) return (n + somaInteirosPositivos(n - 1));
            else return n;
        }

        static int somaInteirosPositivosPares(int n)
        {
            if (n == 1)
                return (2);
            else
            {
                return (2 * n + somaInteirosPositivosPares(n - 1));
            }
        }
        static int somaInteirosPositivosImpares(int n)
        {
            if (n == 1)
                return (1);
            else
                return (2 * n - 1 + somaInteirosPositivosImpares(n - 1));
        }

        static int potência(int a, int b)
        {
            if (b == 0)
                return 1;
            else if (b == 1)
                return a;
            else
                return (a * potência(a, b - 1));
        }

        static int Fibonacci(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        static int Produto(int a, int b)
        {
            if (b == 0)
                return 0;
            else if (b == 1)
                return a;
            else
                return (a + Produto(a, b - 1));
        }

        static int SomaFibonacci(int n)
        {

            if ((n == 1))
                return 1;
            else

                return Fibonacci(n) + SomaFibonacci(n - 1);
        }

        static bool Palindrome(string p, int i, int j)
        {
            if (p[i] != p[j])
                return (false);
            else if (i >= j)
                return (true);
            else
                return (Palindrome(p, i + 1, j - 1));
        }




        static int Menu()
        {

            Console.WriteLine("1 - Fatorial Recursivo");
            Console.WriteLine("2 - Soma de inteiros Positivos");
            Console.WriteLine("3 - Soma de inteiros Positivos Pares"); 
            Console.WriteLine("4 - Soma de inteiros Positivos Impares");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Fibonacci");
            Console.WriteLine("7 - Produto");
            Console.WriteLine("8 - Soma de Fibonacci");
            Console.WriteLine("9 - Mudança de base 2"); //Não feita
            Console.WriteLine("10 - Mudança de base B"); //Não feita
            Console.WriteLine("11 - Palindrome");
            Console.WriteLine("12 - Maior Elemento");//Não feita
            Console.WriteLine("13 - Número Primo");//Não feita
            Console.WriteLine("14 - Torre Hanoi");//Não feita

            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }


        static void Main(string[] args)
        {
            int x, y, op;
            string p;
            do
            {
                op = Menu();

                switch (op)
                {
                    case 1:
                   
                        Console.Clear();
                        Console.Write("Digite um número: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n{0}! = {1}", x, FatorialRecursivo(x));

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Informe quantos elementos positivos deverão ser somados: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("A soma dos {0} primeiros números  positivos é igual a : {1}", x, somaInteirosPositivos(x));
                        Console.ReadKey();
                        break;


                    case 3:
                        Console.Clear();
                        Console.Write("Informe quantos elementos pares positivos deverão ser somados: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("A soma dos {0} primeiros números pares positivos é igual a : {1}", x, somaInteirosPositivosPares(x));
                        Console.ReadKey();
                        break;


                    case 4:
                        Console.Clear();
                        Console.Write("Informe quantos elementos ímpares positivos deverão ser somados: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("A soma dos {0} primeiros números ímpares positivos é igual a : {1}", x, somaInteirosPositivosImpares(x));
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        int a;
                        int b;
                        Console.Write("Insira o valor da base: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Insira o valor do expoente: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("A potência de {0} elevado a {1} é {2}", a, b, potência(a, b));
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Informe uma posição da sequência de Fibonacci : ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nNa posição {0} está o valor {1} ", x, Fibonacci(x));
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Insira o valor de A : ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Insira o valor de B : ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("O produto de {0} com {1} é {2}", a, b, Produto(a, b));
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("Digite uma sequência para a soma dos elementos : ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("A soma {0} dos primeiros elementos é {1} ", x, SomaFibonacci(x));
                        Console.ReadKey();
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.Clear();
                        Console.Write("Digite uma palavra ou número :");
                        p = Console.ReadLine();
                        if (Palindrome(p, 0, p.Length - 1))
                        {
                            Console.WriteLine("É palindrome");
                        }
                        else
                        {
                            Console.WriteLine("Não é palindrome");
                        }

                        Console.ReadKey();
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                }

            } while (op != 14);
        }
    }
}

