using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_AED_Fila
{
    class elemento
    {
        public int valor;
        public elemento proximo;
    }

    class fila
    {
        public elemento inicio = null;
        public elemento fim = null;
        public int tamanho = 0;

        public elemento Pesquisar(int x) //letra A interativo 
        {
            elemento aux = inicio;
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

        public void enfileirar(int x)
        {
            elemento novo = new elemento();
            novo.valor = x;
            novo.proximo = null;

            if (fim != null)
                fim.proximo = novo;
            else
                inicio = novo;
            fim = novo;
            tamanho++;
        }

        public elemento desenfileirar()
        {
            elemento aux = inicio;

            if (inicio != null)
            {
                inicio = inicio.proximo;
                if (inicio == null)
                    fim = null;
                tamanho--;
            }
            return (aux);
        }

        public void Exibir() //Iterativo
        {
            elemento aux = inicio;
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
            inicio = null;
            tamanho = 0;
        }

        public bool Vazia() 
        {
            return (inicio == null);
        }

    }

    class Program
    {
        static char menu()
        {
            Console.Clear();
            Console.WriteLine("\n A - Pesquisar ");
            Console.WriteLine(" B - Enfileirar ");
            Console.WriteLine(" C - Desenfileirar ");
            Console.WriteLine(" D - Exibir  interativo e recursivo");
            Console.WriteLine(" E - Esvaziar");
            Console.WriteLine(" F - Verificar se fila está vazia");
            Console.WriteLine(" G - Contagem > inicio");
            Console.WriteLine(" H - Contagem > fim");
          
            Console.Write("Opção: ");

            return (char.Parse(Console.ReadLine().ToUpper()));
        }
        static void Main(string[] args)
        {
            int x, y;
            char op;
            do
            {
                op = menu();
                fila f = new fila();

                switch (op)
                {
                    case 'A': // pesquisar  
                        Console.Clear();

                        Console.Write("Digite o numero que deseja procurar: ");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n\nInterativo: ");
                        f.Pesquisar(x);
                        if (f.Pesquisar(x) != null)
                        {
                            Console.WriteLine("\n Valor encontrado -> {0} ", f.Pesquisar(x).valor);
                        }
                        else
                        {
                            Console.WriteLine("\n Valor não encontrado !!!");
                        }

                        Console.WriteLine("\n\nRecursivo: ");
                        f.PesquisarRec(x, f.inicio);
                        if (f.Pesquisar(x) != null)
                        {
                            Console.WriteLine("\n Valor encontrado -> {0} ", f.PesquisarRec(x, f.inicio).valor);
                        }
                        else
                        {
                            Console.WriteLine("\n Valor não encontrado !!!");
                        }

                        Console.ReadKey();
                        break;

                    case 'B': 
                        Console.Clear();  // enfileirar
                        Console.Write("Informe um valor para ser enfileirado : ");
                        x = int.Parse(Console.ReadLine());
                        f.enfileirar(x);
                        Console.WriteLine("Valor inserido");
                        Console.ReadKey();
                        break;


                    case 'C': 
                        Console.Clear();  // desenfileirar
                        if (f.tamanho == 0)
                            Console.WriteLine("Fila está vazia");
                        else
                            Console.WriteLine(f.desenfileirar().valor);
                        Console.ReadKey();
                        break;


                    case 'D': 
                        Console.Clear();  // exibir fila

                        Console.WriteLine("Fila Exibida de forma Iterativa");
                        f.Exibir();
                        Console.WriteLine("Fila Exibida de forma Recursiva");
                        f.Exibir(f.inicio);
                        Console.ReadKey();
                        break;


                    case 'E':
                        Console.Clear();  // esvaziar fila
                        f.Esvaziar();
                        Console.WriteLine("Fila esvaziada com sucesso!");
                        Console.ReadKey();
                        break;


                    case 'F': // Verificar se fila está vazia 
                        Console.Clear();

                        if (f.Vazia() == true)
                        {
                            Console.WriteLine("A fila está vazia ");
                        }
                        else
                        {
                            Console.WriteLine("A fila não está vazia ");
                        }
                        Console.ReadKey();
                        break;

                    case 'G': // vai e vem letra G
                        break;
                }

            } while (op != 15);
        }
    }
}
