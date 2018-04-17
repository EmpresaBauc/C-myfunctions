using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_AED_Lista
{
    class elemento
    {
        public int valor;
        public elemento próximo;
    }

    class Lista
    {
        public elemento inicio = null;

        public bool Vazia()
        {
            return (inicio == null);

        }
        public elemento Pesquisar(int x) //letra A 
        {
            elemento aux = inicio;
            while (aux != null && aux.valor != x)
            {
                aux = aux.próximo;
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
                return (PesquisarRec(x, e.próximo));
            }
        }

        public void Exibir() //letra B interativo
        {
            elemento aux = inicio;
            while (aux != null)
            {
                Console.Write("{0} ", aux.valor);
                aux = aux.próximo;
            }
        }
        public void ExibirRec(elemento e) //letra B recursivo
        {
            if (e != null)
            {
                Console.Write("{0} ", e.valor);
                ExibirRec(e.próximo);
            }
        }

        public void Remover(int x)// Letra C 
        {
            elemento aux = inicio;
            elemento ant = null;

            while (aux != null && aux.valor != x)
            {
                ant = aux;
                aux = aux.próximo;
            }

            if (aux == null)
            {
                Console.WriteLine("Valor não encontrado!");
            }
            else
            {
                if (ant == null)
                {
                    inicio = aux.próximo;
                }
                else
                {
                    ant.próximo = aux.próximo;
                }
            }

        }

        public int Contagem() //letra D Interativo
        {
            elemento aux = inicio;
            int cont = 0;
            while (aux != null)
            {
                cont = cont + 1;
                aux = aux.próximo;
            }
            return (cont);
        }

        public int ContagemRec(elemento e) // letra D recursivo
        {
            int cont = 0;
            if (e == null)
            {
                return (cont);
            }
            else
            {
                cont = 1 + ContagemRec(e.próximo);
            }
            return (cont);
        }
        public void Inserir(int e) // letra G 
        {
            elemento novo = new elemento();
            elemento aux = new elemento();

            aux = Pesquisar(e);

            if (aux == null)
            {
                novo.valor = e;
                novo.próximo = inicio;
                inicio = novo;
            }
            else
            {
                Console.WriteLine("Número já existente!");
            }
        }
        public void InserirAntes(int x, int y) //letra H 
        {
            elemento aux = inicio;
            elemento ant = new elemento();
            elemento novo;
            elemento lul = new elemento();

            while ((aux != null) && (aux.valor != y))
            {
                ant = aux;
                aux = aux.próximo;
            }
            if (aux == null)
            {
                Console.WriteLine("Valor não encontrado ");
            }
            else
            {
                lul = Pesquisar(x);

                if (lul != null)
                {
                    Console.WriteLine("Número já existente!");
                }
                else
                {
                    novo = new elemento();
                    novo.valor = x;
                    novo.próximo = aux;

                    if (ant == null)
                    {
                        novo.próximo = inicio;
                        inicio = novo;
                    }
                    else
                    {
                        novo.próximo = ant.próximo;
                        ant.próximo = novo;
                    }
                }
            }
        }
        public void InserirDepois(int x, int y) //letra I 
        {
            elemento aux = inicio;
            elemento novo;
            elemento lul = new elemento();


            while (aux != null && aux.valor != y)
            {
                aux = aux.próximo;
            }

            if (aux == null)
            {
                Console.WriteLine("Valor não encontrado!");
            }
            else
            {
                lul = Pesquisar(x);
                if (lul != null)
                {
                    Console.WriteLine("Este número já existe na lista");
                }
                else
                {
                    novo = new elemento();
                    novo.valor = x;
                    novo.próximo = aux.próximo;
                    aux.próximo = novo;
                }
            }
        }
        public int quantosMaiores(int valor) //letra j interativo 
        {
            elemento aux = inicio;
            int maior = 0;
            while (aux != null)
            {
                if (aux.valor > valor)
                {
                    maior = maior + 1;
                }
                aux = aux.próximo;
            }
            return (maior);
        }

        public int quantosMaioresRec(elemento e, int num) //letra j recursivo
        {
            int result = 0;
            if (e != null)
            {
                if (e.valor > num)
                {
                    result = 1 + quantosMaioresRec(e.próximo, num);
                }

                quantosMaioresRec(e.próximo, num);
            }

            return (result);
        }
        public int Soma(elemento aux)//iterativo Letra K
        {
            int soma = 0;
            while (aux != null)
            {
                soma = soma + aux.valor;
                aux = aux.próximo;
            }

            return soma;
        }
        public int SomaRec(elemento aux) //recursivo Letra K 
        {
            if (aux == null)
            {
                return 0;
            }
            else
            {
                return aux.valor + (SomaRec(aux.próximo));
            }
        }
        public void Troca(int x, int y) // Letra L
        {
            elemento aux = new elemento();
            elemento aux2 = new elemento();

            aux = Pesquisar(x);
            aux2 = Pesquisar(y);
            if (aux == null || aux2 == null)
            {
                Console.WriteLine("\nAlgum dos valores é nulo!");
            }
            else
            {
                aux.valor = y;
                aux2.valor = x;
            }
        }
        static char menuQuestao15()
        {
            Console.Clear();
            Console.WriteLine("A - Pesquisar ");
            Console.WriteLine("B - Exibir Interativo e Recursivo");
            Console.WriteLine("C - Remover ");
            Console.WriteLine("D - Contagem Recursivo e Interativo ");
            Console.WriteLine("E - ");
            Console.WriteLine("F - ");
            Console.WriteLine("G - Inserir");
            Console.WriteLine("H - Inserir Antes");
            Console.WriteLine("I - Inserir Depois");
            Console.WriteLine("J - Quantos Maiores ");
            Console.WriteLine("K - Soma Interativo e Recursivo");
            Console.WriteLine("L - Troca ");

           
            Console.Write("Opção: ");

            return (char.Parse(Console.ReadLine().ToUpper()));
        }


        class Program
        {
            static void Main(string[] args)
            {
                int x, y;
                char op;
                Lista MinhaLista = new Lista();
                do
                {
                    op = menuQuestao15();

                    switch (op)
                    {
                        case 'A':

                            Console.Clear(); // pesquisar (letra a)

                            Console.Write("Informe o número a ser pesquisado : ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n\nInterativo: ");
                            MinhaLista.Pesquisar(x);
                            if (MinhaLista.Pesquisar(x) != null)
                            {
                                Console.WriteLine("\n Valor encontrado -> {0} ", MinhaLista.Pesquisar(x).valor);
                            }
                            else
                            {
                                Console.WriteLine("\n Valor não encontrado !!!");
                            }

                            Console.WriteLine("\n\nRecursivo: ");
                            MinhaLista.PesquisarRec(x, MinhaLista.inicio);
                            if (MinhaLista.Pesquisar(x) != null)
                            {
                                Console.WriteLine("\n Valor encontrado -> {0} ", MinhaLista.PesquisarRec(x, MinhaLista.inicio).valor);
                            }
                            else
                            {
                                Console.WriteLine("\n Valor não encontrado!");
                            }

                            Console.ReadKey();
                            break;

                        case 'B': //exibir (letra b)

                            Console.Clear();
                            if (MinhaLista.inicio != null)
                            {
                                Console.Write("Exibido de forma  Interativa: ");
                                MinhaLista.Exibir() ; //exibir interativo

                                Console.Write("\nExibir recursivo : ");
                                MinhaLista.ExibirRec(MinhaLista.inicio); // exibir recursivo
                            }
                            else
                            {
                                Console.WriteLine("Lista Vazia");
                            }
                            Console.ReadKey();
                            break;

                        case 'C':
                            Console.Clear(); // remover elemento da lista  (letra C)

                            Console.WriteLine("Informe o valor a ser removido: ");
                            x = int.Parse(Console.ReadLine());
                            MinhaLista.Remover(x);
                            Console.WriteLine("Elemento removido com sucesso!");
                            Console.ReadKey();
                            break;

                        case 'D':

                            Console.Clear();

                            Console.Write("Contagem de forma  Interativa: ");// forma interativa
                            x = MinhaLista.Contagem();
                            Console.Write("{0} ", x);

                            Console.Write("\nContagem de forma recursiva : "); //forma recursiva
                            x = MinhaLista.ContagemRec(MinhaLista.inicio);
                            Console.Write("{0} ", x);

                            Console.ReadKey();
                            break;

                        case 'E':
                            break;

                        case 'F':
                            break;

                        case 'G':  //inserir (letra G)

                            Console.Clear();

                            Console.Write("Informe um número a ser inserido: ");
                            x = int.Parse(Console.ReadLine());

                            MinhaLista.Inserir(x);
                            Console.WriteLine("Elemento inserido com sucesso!");

                            Console.ReadKey();
                            break;

                        case 'H'://inserir depois (letra H)

                            Console.Clear();
                            Console.WriteLine("Inserir Depois : ");

                            Console.Write("\n\nInserir: ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nDepois de : ");
                            y = int.Parse(Console.ReadLine());

                            MinhaLista.InserirDepois(x, y);
                            Console.WriteLine("Elemento inserido com sucesso!");

                            Console.ReadKey();
                            break;

                        case 'I'://inserir antes (letra I)

                            Console.Clear();


                            Console.WriteLine("Inserir Antes");

                            Console.Write("\n\nInserir: ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n\nAntes de : ");
                            y = int.Parse(Console.ReadLine());

                            MinhaLista.InserirAntes(x, y);
                            Console.WriteLine("Elemento inserido com sucesso!");


                            Console.ReadKey();
                            break;


                        case 'J': //quantos maiores (Letra J)

                            Console.Clear();

                            Console.Write("Digite um valor : ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nInterativo:");
                            Console.WriteLine("\n há {0} elementos maiores que {1} na lista", MinhaLista.quantosMaiores(x), x);
                            Console.WriteLine("\nRecursvio: ");
                            Console.WriteLine("\n há {0} elementos maiores que {1} na lista", MinhaLista.quantosMaioresRec(MinhaLista.inicio, x), x);
                            Console.ReadKey();
                            break;


                        case 'K': //somar (Letra K)

                            Console.Clear();

                            Console.WriteLine("Soma dos elementos: {0}", MinhaLista.Soma(MinhaLista.inicio));

                            Console.WriteLine("Soma recursivo: {0}", MinhaLista.SomaRec(MinhaLista.inicio));
                            Console.WriteLine("Elementos somados com sucesso!");

                            Console.ReadKey();
                            break;

                        case 'L': //trocar (Letra L)

                            Console.Clear();

                            Console.Write("Trocar valor : ");
                            x = int.Parse(Console.ReadLine());

                            Console.Write("Com : ");
                            y = int.Parse(Console.ReadLine());

                            MinhaLista.Troca(x, y);
                            Console.WriteLine("Elemento trocados com sucesso!");


                            Console.ReadKey();
                            break;
                    }

                } while (op != 15);
            }
        }
    }

}
    