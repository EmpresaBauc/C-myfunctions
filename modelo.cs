using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Questao1()
        {

        }

        static void Questao2()
        {
        }

        static void Questao3()
        {
        }

        static void Questao4()
        {
        }

        static void Questao5()
        {
        }

        static void Questao6()
        {
        }

        static void Questao7()
        {
        }

       

        static int continuar(int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        static void Main(string[] args)
        {
            int parar;
            int questao;
            do
            {

                Console.Clear();
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1-  Questao 1- ");
                Console.WriteLine("2-  Questao 2- ");
                Console.WriteLine("3-  Questao 3- ");
                Console.WriteLine("4-  Questao 4- ");
                Console.WriteLine("5-  Questao 5- ");
                Console.WriteLine("6-  Questao 6- ");
                Console.WriteLine("7-  Questao 7- ");
                Console.WriteLine("8-  Questao 8- ");
                Console.WriteLine("9-  Questao 9- ");
                Console.WriteLine("10-  Questao 10- ");

                Console.Write("Selecione a o número correspondente a questão desejada: ");
                questao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (questao)
                {
                    case 1:
                        Questao1();
                        break;
                    case 2:
                        Questao2();
                        break;
                    case 3:
                        Questao3();
                        break;
                    case 4:
                        Questao4();
                        break;
                    case 5:
                        Questao5();
                        break;
                    case 6:
                        Questao6();
                        break;

                    case 7:
                        Questao7();
                        break;

                }
                Console.WriteLine("\nDeseja continuar no programa principal?(DIGITE 0 PARA SAIR)");
                parar = Convert.ToInt16(Console.ReadLine());
            } while (continuar(parar) == 1);

        }
    }
}
