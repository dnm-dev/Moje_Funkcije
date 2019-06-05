using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Igra
{
    public class io
    {
        const int dim = 3;

        private static void ispisMatrica(char[,] matrica)
        {
            int x = matrica.GetLength(0);
            int y = matrica.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0} ", matrica[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void TIspis(char[,] tabela)
        {
            Console.Write(" {0} | {1} | {2}", tabela[0, 0], tabela[0, 1], tabela[0, 2]);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.Write(" {0} | {1} | {2}", tabela[1, 0], tabela[1, 1], tabela[1, 2]);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.Write(" {0} | {1} | {2}", tabela[2, 0], tabela[2, 1], tabela[2, 2]);
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void generisi(ref char[,] tabela)
        {
            string p = "abcdefghi";
            int count = 0;

            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                    tabela[i, j] = p[count++];
        }

        private static bool popunjeno(bool[,] a, int x, int y) {
            if (a[x, y] == true)
                return true;
            else
                return false;
        }

        private static void prvi(ref char[,] tabela, ref char[,] tabelaDisplay, ref bool[,]p)
        {
            Console.Write("I igrac\nPozicija: ");

            //bool ponavljaj = true;

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    tabela[2, 0] = 'X';
                    tabelaDisplay[2, 0] = 'X';
                    p[2, 0] = true;
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad2:
                    tabela[2, 1] = 'X';
                    tabelaDisplay[2, 1] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad3:
                    tabela[2, 2] = 'X';
                    tabelaDisplay[2, 2] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad4:
                    tabela[1, 0] = 'X';
                    tabelaDisplay[1, 0] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad5:
                    tabela[1, 1] = 'X';
                    tabelaDisplay[1, 1] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad6:
                    tabela[1, 2] = 'X';
                    tabelaDisplay[1, 2] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad7:
                    tabela[0, 0] = 'X';
                    tabelaDisplay[0, 0] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad8:
                    tabela[0, 1] = 'X';
                    tabelaDisplay[0, 1] = 'X';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad9:
                    tabela[0, 2] = 'X';
                    tabelaDisplay[0, 2] = 'X';
                    Console.Clear();
                    break;
            }
        }

        private static void drugi(ref char[,] tabela, ref char[,] tabelaDisplay, ref bool[,]p)
        {
            Console.Write("II igrac\nPozicija: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                        tabela[2, 0] = 'O';
                        tabelaDisplay[2, 0] = 'O';
                        Console.Clear();
                        break;                    
                case ConsoleKey.NumPad2:
                    tabela[2, 1] = 'O';
                    tabelaDisplay[2, 1] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad3:
                    tabela[2, 2] = 'O';
                    tabelaDisplay[2, 2] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad4:
                    tabela[1, 0] = 'O';
                    tabelaDisplay[1, 0] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad5:
                    tabela[1, 1] = 'O';
                    tabelaDisplay[1, 1] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad6:
                    tabela[1, 2] = 'O';
                    tabelaDisplay[1, 2] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad7:
                    tabela[0, 0] = 'O';
                    tabelaDisplay[0, 0] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad8:
                    tabela[0, 1] = 'O';
                    tabelaDisplay[0, 1] = 'O';
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad9:
                    tabela[0, 2] = 'O';
                    tabelaDisplay[0, 2] = 'O';
                    Console.Clear();
                    break;
            }

        }

        private static bool proveriKolone(char[,] tabela)
        {

            if (tabela[0, 0] == tabela[1, 0] && tabela[1, 0] == tabela[2, 0] ||
                tabela[0, 1] == tabela[1, 1] && tabela[1, 1] == tabela[2, 1] ||
                tabela[0, 2] == tabela[1, 2] && tabela[1, 2] == tabela[2, 2])
                return true;
            else
                return false;

        }

        private static bool proveriRedove(char[,] tabela)
        {
            if (tabela[0, 0] == tabela[0, 1] && tabela[0, 1] == tabela[0, 2] ||
                tabela[1, 0] == tabela[1, 1] && tabela[1, 1] == tabela[1, 2] ||
                tabela[2, 0] == tabela[2, 1] && tabela[2, 1] == tabela[2, 2])
                return true;
            else
                return false;
        }

        private static bool proveriDijagonale(char[,] tabela)
        {
            if (tabela[0, 0] == tabela[1, 1] && tabela[1, 1] == tabela[2, 2] ||
                tabela[2, 0] == tabela[1, 1] && tabela[1, 1] == tabela[0, 2])
                return true;
            else
                return false;
        }

        public static void play()
        {
            char[,] tabelaDisplay = new char[dim, dim];
            char[,] tabela = new char[dim, dim];
            bool[,] popunjeno = new bool[dim, dim];

            generisi(ref tabela);

            int potez = 1;
            
            TIspis(tabelaDisplay);
                while (potez<10) {

                    if (potez % 2 == 1)
                        prvi(ref tabela, ref tabelaDisplay, ref popunjeno);
                    else
                        drugi(ref tabela, ref tabelaDisplay, ref popunjeno);

                    if (proveriKolone(tabela) == true ||
                        proveriRedove(tabela) == true ||
                        proveriDijagonale(tabela) == true)
                        break;

                    potez++;
                    TIspis(tabelaDisplay);
                    
                    //Console.WriteLine();
          
            }
                Thread.Sleep(1000);
                Console.Clear();

                int c = potez - 1;
                
            if (c % 2 == 1)
                    Console.WriteLine("Igrac II je pobedio nakon {0} poteza", c);
                else
                    Console.WriteLine("Igrac I je pobesio nakon {0} poteza", c);

                
        }

    }
}
