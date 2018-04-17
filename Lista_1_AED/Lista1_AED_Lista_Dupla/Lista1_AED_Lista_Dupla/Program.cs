using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_AED_Lista_Dupla
{
    class Program
    {
        class elemento
        {

            public int num;

            public elemento proximo;
            public elemento ant;
        }
        class Lista_Duplamente
        {
            public elemento inicio = null;

            public elemento Pesquisar(int x) //letra A interativo 
            {
                elemento aux = inicio;
                while (aux != null && aux.num != x)
                {
                    aux = aux.proximo;
                }

                return (aux);
            }

            public elemento PesquisarRec(int x, elemento e) //letra A recursivo 
            {
                if (e == null || e.num == x)
                {
                    return (e);
                }
                else
                {
                    return (PesquisarRec(x, e.proximo));
                }
            }

            public void Inserir(elemento x) // letra B  
            {
                elemento novo = new elemento();


                novo.num = x.num;
                novo.proximo = inicio;
                novo.ant = null;

                if (inicio != null)
                {
                    inicio.ant = novo;
                }

                inicio = novo;
            }

            public void Remover(int x) // letra C
            {
                elemento aux = new elemento();
                aux = Pesquisar(x);

                if (aux == null)
                {
                    Console.WriteLine("Elemento não encontrado");
                }
                else
                {
                    if (aux.ant == null)
                    {
                        inicio = aux.proximo;
                        if (aux.proximo != null)
                        {
                            aux.proximo.ant = null;
                        }
                    }
                    else
                    {
                        aux.ant.proximo = aux.proximo;
                        if (aux.proximo != null)
                        {
                            aux.proximo.ant = null;
                        }
                    }

                }

            }

            public void Exibir() // letra D interativo
            {
                elemento aux = inicio;
                while (aux != null)
                {
                    Console.Write("{0} ", aux.num);
                    aux = aux.proximo;
                }
            }

            public void ExibirRec(elemento e) //letra D Recursivo
            {

                if (e != null)
                {
                    Console.Write("{0} ", e.num);
                    ExibirRec(e.proximo);
                }
            }

            public void Esvaziar()//Letra E 
            {
                inicio = null;
                Console.WriteLine("Lista Vazia!");
            }

            public bool Vazia() // letra F 
            {
                return (inicio == null);
            }

            public void vaiEvem()// letra G 
            {
                elemento aux = inicio;
                int x;
                while (aux != null)
                {
                    Console.WriteLine("\nNúmero: {0}", aux.num);

                    Console.Write("Digite um valor: ");
                    x = int.Parse(Console.ReadLine());

                    if (x < 0)
                    {
                        aux = aux.ant;
                    }
                    else
                    {
                        if (x > 0)
                        {
                            aux = aux.proximo;
                        }
                        else
                        {
                            Console.WriteLine("\nValor igual a 0! Não permitido!");
                        }
                    }

                }
                Console.WriteLine("\nFim da linha");
            }

            // letra h
            //letra i


            public int contagem() //letra J Interativo
            {
                elemento aux = inicio;
                int cont = 0;
                while (aux != null)
                {
                    cont = cont + 1;
                    aux = aux.proximo;
                }
                return (cont);
            }

            public int ContegemRec(elemento e) // letra J recursivo
            {
                int cont = 0;
                if (e == null)
                {
                    return (cont);
                }
                else
                {
                    cont = 1 + ContegemRec(e.proximo);
                }
                return (cont);
            }

            // letra k 
            //letra l
        }

        static char menu()
        {
            Console.Clear();
            Console.WriteLine("\n A - Pesquisar ");
            Console.WriteLine(" B - Inserir ");
            Console.WriteLine(" C - Remover ");
            Console.WriteLine(" D - Exibir  interativo e recursivo");
            Console.WriteLine(" E - Esvaziar");
            Console.WriteLine(" F - Ver se a lista está vazia");
            Console.WriteLine(" G - Vai e vem");
            Console.WriteLine(" H - ");
            Console.WriteLine(" I - ");
            Console.WriteLine(" J - Contagem de elementos Insterativo e Recursivo");
            Console.WriteLine(" K -");
            Console.WriteLine(" L -");
           
            Console.Write("Opção: ");

            return (char.Parse(Console.ReadLine().ToUpper()));
        }

        static void Main(string[] args)
        {
            int x, y;
            char op;

            Lista_Duplamente MinhaLista = new Lista_Duplamente();

            elemento o;

            do
            {
                op = menu();
                o = new elemento();

                switch (op)
                {
                    case 'A': // pesquisar
                        Console.Clear();

                        Console.Write("Digite o numero que deseja procurar: ");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n\nInterativo: ");
                        MinhaLista.Pesquisar(x);
                        if (MinhaLista.Pesquisar(x) != null)
                        {
                            Console.WriteLine("\n Valor encontrado = {0} ", MinhaLista.Pesquisar(x).num);
                        }
                        else
                        {
                            Console.WriteLine("\n Valor não encontrado!");
                        }

                        Console.WriteLine("\n\nRecursivo: ");
                        MinhaLista.PesquisarRec(x, MinhaLista.inicio);
                        if (MinhaLista.Pesquisar(x) != null)
                        {
                            Console.WriteLine("\n Valor encontrado = {0} ", MinhaLista.PesquisarRec(x, MinhaLista.inicio).num);
                        }
                        else
                        {
                            Console.WriteLine("\n Valor não encontrado!");
                        }

                        Console.ReadKey();
                        break;

                    case 'B': // inserir elemento 
                        Console.Clear();

                        Console.Write("Digite o número: ");
                        o.num = int.Parse(Console.ReadLine());

                        MinhaLista.Inserir(o);
                        Console.WriteLine("Elemento inserido com sucesso!");

                        Console.ReadKey();
                        break;

                    case 'C': // remover elemento
                        Console.Clear();

                        Console.Write("Digite o numero que deseja remover : ");
                        x = int.Parse(Console.ReadLine());

                        MinhaLista.Remover(x);
                        Console.WriteLine("Elemento removido com sucesso!");
                        Console.ReadKey();
                        break;

                    case 'D': // exibir elemento Letra D
                        Console.Clear();

                        Console.Write("Exibindo de forma interativa: ");
                        MinhaLista.Exibir();

                        Console.Write("\n\nExibindo de forma recursiva: ");

                        MinhaLista.ExibirRec(MinhaLista.inicio);

                        Console.ReadKey();
                        break;

                    case 'E': // esvaziar
                        Console.Clear();

                        MinhaLista.Esvaziar();
                        Console.WriteLine("Lista esvaziada com sucesso");

                        Console.ReadKey();
                        break;

                    case 'F': // Verificar se lista vazia 
                        Console.Clear();

                        if (MinhaLista.Vazia() == true)
                        {
                            Console.WriteLine("A lista está vazia ");
                        }
                        else
                        {
                            Console.WriteLine("A lista não está vazia ");
                        }
                        Console.ReadKey();
                        break;

                    case 'G': // vai e vem letra G
                        Console.Clear();

                        MinhaLista.vaiEvem();

                        Console.ReadKey();
                        break;
                    case 'H':
                        break;
                    case 'I':
                        break;
                    case 'J': //contagem de elementos
                        Console.Clear();

                        Console.Write("Contagem de forma  Interativa: ");// forma interativa
                        x = MinhaLista.contagem();
                        Console.Write("{0} ", x);

                        Console.Write("\nContagem de forma recursiva : "); //forma recursiva
                        x = MinhaLista.ContegemRec(MinhaLista.inicio);
                        Console.Write("{0} ", x);

                        Console.ReadKey();
                        break;
                    case 'K':
                        break;
                    case 'L':
                        break;
                }

            } while (op != 15);
        }

    }
}

