using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        class elementolistasimples
        {
            public elementolistasimples prox;
            public int valor;
        }
        class listasimples
        {
            public elementolistasimples inicio=null;
            public elementolistasimples fim = null;

            public elementolistasimples pesquisariterativo(int n)
            {
                elementolistasimples aux;
                aux = inicio;
                if (aux==null)
                {
                    Console.WriteLine("Não Existe!");
                    return null;
                }
                else
                {

                    return
                }
            }
        }
        static void Main(string[] args)
        {
            int questao, continuar;
            do
            {
                Console.WriteLine("Questões da Lista:");
                Console.WriteLine("1 - Fatorial Recursiva");
                Console.WriteLine("2 - Soma Inteiros Positivos");
                Console.WriteLine("3 - Soma Inteiros Positivos Pares");
                Console.WriteLine("4 - Soma Inteiros Positivos Impares");
                Console.WriteLine("5 - Potencia Recursiva");
                Console.WriteLine("6 - Fibonnaci Recursiva");
                Console.WriteLine("7 - Produto Recursiva");
                Console.WriteLine("8 - Soma Fibonnaci Recursiva");
                Console.WriteLine("9 - Mudança Base 2 Recursiva");
                Console.WriteLine("10 - Mudança Base Recursiva");
                Console.WriteLine("11 - Palindromo Recursiva");
                Console.WriteLine("12 - Maior Elemento Recursiva");
                Console.WriteLine("13 - Número Primo Recursiva");
                Console.WriteLine("14 - Torres Hanoi");
                Console.WriteLine("15 - Lista Simplesmente Encadeada");
                Console.WriteLine("16 -  Lista Duplamente Encadeada");
                Console.WriteLine("17 - Pilha");
                Console.WriteLine("18 - Fila");
                Console.WriteLine("Escolha a questão desejada digitando o número correspondente:");
                questao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (questao)
                {
                    case 1:
                        //questao1();
                        break;
                    case 2:
                        //questao2();
                        break;
                    case 3:
                        //questao3();
                        break;
                    case 4:
                        //questao4();
                        break;
                    case 5:
                        //questao5();
                        break;
                    case 6:
                        //questao6();
                        break;
                    case 7:
                        //questao7();
                        break;
                    case 8:
                        //questao8();
                        break;
                    case 9:
                        //questao9();
                        break;
                    case 10:
                        //questao10();
                        break;
                    case 11:
                        //questao11();
                        break;
                    case 12:
                        //questao12();
                        break;
                    case 13:
                        //questao13();
                        break;
                    case 14:
                        //questao14();
                        break;
                    case 15:
                        //questao15();
                        break;
                    case 16:
                        //questao16();
                        break;
                    case 17:
                        //questao17();
                        break;
                    case 18:
                        //questao18();
                        break;
                }
                Console.Clear();
                Console.WriteLine("Deseja continuar? (Digite 0 para sair)");
                continuar = Convert.ToInt16(Console.ReadLine());
            } while (continuar != 0);
        }
    }
}

