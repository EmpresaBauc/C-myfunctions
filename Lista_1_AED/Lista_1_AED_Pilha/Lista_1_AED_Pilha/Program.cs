using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_AED_Pilha
{
    class elemento
    {
        public int valor;
        public elemento proximo;
    }

    class pilha
    {
        public elemento topo = null;
        public int tamanho = 0; // Informa quantidade de elementos da pilha

        public elemento Pesquisar(int x) //letra A interativo 
        {
            elemento aux = topo;
            while (aux != null && aux.valor != x)
            {
                aux = aux.proximo;
            }

            return (aux);
        }

        public elemento PesquisarRec(int x, elemento e) //letra A recursivo 
        {
            if (e == null || e.valor == x)
            {
                return (e);
            }
            else
            {
                return (PesquisarRec(x, e.proximo));
            }
        }
        public void Empilhar(int x)
        {
            elemento novo = new elemento();
            novo.valor = x;
            novo.proximo = topo;
            topo = novo;
            tamanho++;
        }

        public elemento Desempilhar()
        {
            elemento aux = topo;
            if (topo != null)
            {
                topo = topo.proximo;
                tamanho--;
            }
            return (aux);
        }

        public void Exibir() //Iterativo
        {
            elemento aux = topo;
            while (aux != null)
            {
                Console.WriteLine(aux.valor);
                aux = aux.proximo;
            }
        }

        public void Exibir(elemento e) //Recursivo
        {
            if (e != null)
            {
                Console.WriteLine(e.valor);
                Exibir(e.proximo);
            }
        }

        public void Esvaziar()
        {
            topo = null;
            tamanho = 0;
        }
        public bool Vazia()
        {
            return (topo == null);
        }

    }


    class Program
    {
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("A - Pesquisar");
            Console.WriteLine("B - Empilhar");
            Console.WriteLine("C - Desempilhar");
            Console.WriteLine("D - Exibir pilha");
            Console.WriteLine("E - Esvaziar pilha");
            Console.WriteLine("F - Verificar se está vazia");
            Console.WriteLine("G - Contagem");

            
            Console.Write("Opção: ");

            return (char.Parse(Console.ReadLine().ToUpper()));
        }


        static void Main(string[] args)
        {
            {
                int op, x;
                pilha p = new pilha();


                do
                {
                    op = menu();

                    switch (op)
                    {
                        case 'A':
                            Console.Clear();

                            Console.Write("Digite o numero que deseja procurar: ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n\nInterativo: ");
                            p.Pesquisar(x);
                            if (p.Pesquisar(x) != null)
                            {
                                Console.WriteLine("\n Valor encontrado -> {0} ", p.Pesquisar(x).valor);
                            }
                            else
                            {
                                Console.WriteLine("\n Valor não encontrado!");
                            }

                            Console.WriteLine("\n\nRecursivo: ");
                            p.PesquisarRec(x, p.topo);
                            if (p.Pesquisar(x) != null)
                            {
                                Console.WriteLine("\n Valor encontrado -> {0} ", p.PesquisarRec(x, p.topo).valor);
                            }
                            else
                            {
                                Console.WriteLine("\n Valor não encontrado!");
                            }

                            Console.ReadKey();
                            break;

                        case 'B':
                            Console.Clear();  // empilhar
                            Console.Write("Informe um valor para ser empilhado : ");
                            x = int.Parse(Console.ReadLine());
                            p.Empilhar(x);
                            Console.WriteLine("Valor empilhado");

                            Console.ReadKey();
                            break;

                        case 'C':
                            Console.Clear();  // desempilhar
                            if (p.tamanho == 0)
                                Console.WriteLine("Pilha está vazia");
                            else
                                Console.WriteLine(p.Desempilhar().valor);
                            Console.WriteLine("Valor desempilhado");
                            Console.ReadKey();
                            break;

                        case 'D':
                            Console.Clear();  // exibir pilha
                            Console.WriteLine("Pilha Exibida de forma Iterativa");
                            p.Exibir();
                            Console.WriteLine("Pilha Exibida de forma Recursiva");
                            p.Exibir(p.topo);
                            Console.ReadKey();
                            break;
                        case 'E':
                            Console.Clear();  // esvaziar pilha
                            p.Esvaziar();
                            Console.WriteLine("Pilha esvaziada com sucesso!");
                            Console.ReadKey();
                            break;
                        case 'F':
                            Console.Clear();

                            if (p.Vazia() == true)
                            {
                                Console.WriteLine("A pilha está vazia ");
                            }
                            else
                            {
                                Console.WriteLine("A pilha não está vazia ");
                            }
                            Console.ReadKey();
                            break;
                        case 'G':
                            break;


                    }
                } while (op != 15);
            }
        }
    }
}
