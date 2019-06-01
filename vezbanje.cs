using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Program
{
	class Program
	{
		static Random rnd = new Random();

		static void upisiNiz(out int[] niz){
			
			Console.WriteLine("Koliko elemenata ima:");

			int n = int.Parse(Console.ReadLine());
			niz = new int[n];

			for(int i = 0; i < n; i++)
				niz[i] = int.Parse(Console.ReadLine());
		}

		static void randomNiz(out int[] niz){
			
			Console.WriteLine("Koliko elemenata ima:");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Opseg elemenata je: ");
			string[] range = Console.ReadLine().Split(',');
			Console.WriteLine();

			int r1 = int.Parse(range[0]);
			int r2 = int.Parse(range[1]);

			niz = new int[n];

			for(int i = 0; i < n; i++){
				int rd = rnd.Next(r1, r2);
				niz[i] = rd;
			}
		}
		
		static void isipisNiz(int[] niz, int len){
			
			Console.WriteLine("Elementi niza su: ");
			
			for(int i = 0; i<len;i++)
				Console.Write("{0} ", niz[i]);

			Console.WriteLine();
			Console.WriteLine("Ima {0} elemenata", len);
			Console.WriteLine();
		}

		static void upisiMatricu(out int[,] matrica){
			Console.WriteLine("Dimenzije matrice su: ");
			string[] dim = Console.ReadLine().Split(',');

			int x = int.Parse(dim[0]);
			int y = int.Parse(dim[1]);

			matrica = new int[x,y];

			for(int i = 0; i < x; i++){
				for(int j = 0; j < y; j++){
					matrica[i,j] = int.Parse(Console.ReadLine());
				}
			}
		}

		static void randomMatrica(out int[,] matrica){
			
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

			matrica = new int[x,y];

			for(int i = 0; i < x; i++){
				for(int j = 0; j < y; j++){
					int rd = rnd.Next(r1, r2);
					matrica[i,j] = rd;
				}
			}
		}

		static void ispisMatricu(int[,] matrica, int x, int y) {
			
			Console.Write("Matrica :");
			Console.WriteLine();

			for(int i = 0;i<x;i++){
				Console.WriteLine();
				for(int j = 0;j<y;j++)
					Console.Write("{0} ", matrica[i, j]);
			}
			Console.WriteLine();
			Console.WriteLine();
		}

		static void izdvoj(int[,] matrica, int x, int y){

			Console.WriteLine("Opseg izdvajanja je: ");
			string[] range = Console.ReadLine().Split(',');
			int r1 = int.Parse(range[0]);
			int r2 = int.Parse(range[1]);

			int poz = 0;
			
			int[] niz = new int[x*y];

			for(int i = 0; i<x;i++){
				for(int j = 0;j<y;j++){
					int tmp = matrica[i,j];
					if(tmp >= r1 && tmp <= r2)
						niz[poz++]=tmp;
				}
			}
			Console.WriteLine();

			niz = niz.Where(T => T != 0).ToArray();
			int len = niz.Length;
			isipisNiz(niz, len);
		}

		static void Main(string [] args){

		}
	}	
}

