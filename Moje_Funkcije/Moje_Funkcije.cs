using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moje_Funkcije
{
    public class Nizovi_Matrice_N
    {
        private static Random rnd = new Random();

        public void upisiNiz(out int[] niz)
        {

            Console.WriteLine("Koliko elemenata ima:");

            int n = int.Parse(Console.ReadLine());
            niz = new int[n];

            for (int i = 0; i < n; i++)
                niz[i] = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        public void randomNiz(out int[] niz)
        {

            Console.WriteLine("Koliko elemenata ima:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Opseg elemenata je: ");
            string[] range = Console.ReadLine().Split(',');
            Console.WriteLine();

            int r1 = int.Parse(range[0]);
            int r2 = int.Parse(range[1]);

            niz = new int[n];

            for (int i = 0; i < n; i++)
            {
                int rd = rnd.Next(r1, r2);
                niz[i] = rd;
            }
        }

        public void ispisNiz(int[] niz)
        {

            int len = niz.Length;

            Console.WriteLine("Elementi niza su: ");

            for (int i = 0; i < len; i++)
                Console.Write("{0} ", niz[i]);

            Console.WriteLine();
            
        }

        public void upisiMatricu(out int[,] matrica)
        {
            Console.WriteLine("Dimenzije matrice su: ");
            string[] dim = Console.ReadLine().Split(',');

            int x = int.Parse(dim[0]);
            int y = int.Parse(dim[1]);

            matrica = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                string[] elemnti = Console.ReadLine().Split(',');
                for (int j = 0; j < y; j++)
                {
                    matrica[i, j] = int.Parse(elemnti[j]);
                }
            }
            Console.WriteLine();
        }

        public void randomMatrica(out int[,] matrica)
        {

            Console.WriteLine("Dimenzije matrice su: ");
            string[] dim = Console.ReadLine().Split(',');
            Console.WriteLine();

            int x = int.Parse(dim[0]);
            int y = int.Parse(dim[1]);

            Console.WriteLine("Opseg elemenata je:");
            string[] range = Console.ReadLine().Split(',');
            Console.WriteLine();

            int r1 = int.Parse(range[0]);
            int r2 = int.Parse(range[1]);

            matrica = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int rd = rnd.Next(r1, r2);
                    matrica[i, j] = rd;
                }
            }
        }

        public void ispisMatricu(int[,] matrica)
        {

            int x = matrica.GetLength(0);
            int y = matrica.GetLength(1);

            Console.Write("Matrica :");
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                    Console.Write("{0} ", matrica[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void sort(ref int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {

                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        public void izdvoj(int[,] matrica)
        {

            int x = matrica.GetLength(0);
            int y = matrica.GetLength(1);

            Console.WriteLine("Opseg izdvajanja je: ");
            string[] range = Console.ReadLine().Split(',');
            int r1 = int.Parse(range[0]);
            int r2 = int.Parse(range[1]);

            int poz = 0;

            int[] niz = new int[x * y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int tmp = matrica[i, j];
                    if (tmp >= r1 && tmp <= r2)
                        niz[poz++] = tmp;
                }
            }
            Console.WriteLine();

            niz = niz.Where(T => T != 0).ToArray();
            int len = niz.Length;
            ispisNiz(niz);
        }

    }

    public class Nizovi_Matrice_S { 
      
    }

    public class Nizovi_Matrice_C {

        private static Random rnd = new Random();

        public void upisiNiz(out char[] niz)
        {
            Console.WriteLine("Koliko elemenata ima: ");

            int n = int.Parse(Console.ReadLine());
            niz = new char[n];
            for (int i = 0; i < n; i++)
                niz[i] = char.Parse(Console.ReadLine());
        }

        public void ispisNiz(char[] niz) {
            int n = niz.Length;
            Console.WriteLine("Elementi su: ");

            for (int i = 0; i < n; i++)
                Console.Write("{0} ",niz[i]);
        }

        public void ispisMatrica(char[,] matrica) {
            int x = matrica.GetLength(0);
            int y = matrica.GetLength(1);

            for (int i = 0; i < x; i++) {
                Console.WriteLine();
                for (int j = 0; j < y; j++) {
                    Console.Write("{0} ", matrica[i,j]);
                }
                Console.WriteLine();
            }
        }

    }

    public class Brojevi 
    {
        public bool prost(int n) {
            if (n == 2)
                return false;
            if (n % 2 == 0)
                return false;
            for(int i = 2; i < n; i++)
                if (n%i==0)
                    return false;
            return true;
        }

        public int inverzan(int n) {
            int novi = 0;
            while (n > 0) {
                int c = n % 10;
                novi = novi * 10 + c;
                n /= 10;
            }
            return novi;
        }

        public bool palindrom(int n) {
            if (inverzan(n) == n)
                return true;
            else
                return false;
        }
    }

}