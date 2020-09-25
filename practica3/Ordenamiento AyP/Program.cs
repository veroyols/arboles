/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 24/9/2020
 * Hora: 22:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ordenamiento_AyP
{
	class Program
	{
		/*Metodos: Ordenar - Algoritmos y programacion*/
		public static void ordenarPorIntercambio (int [] datos)
		{
			int n = datos.Length;
			for (int i=0; i<n ; i++){
				for (int j=0; j<i ; j++){
					//Console.WriteLine("Posicion i "+ datos[i]);
					//Console.WriteLine("Posicion j "+ datos[j]);
					if (datos[i] < datos[j]){
						int swap = datos[i];
						datos[i] = datos[j];
						datos[j] = swap;
					}
				}
			}
		}
		
		public static void ordenarPorSeleccion (int [] datos)
		{
			int n = datos.Length;
			for (int i=0; i < n-1 ; i++){ //para cada uno de los datos del arreglo
				int menor = i; //guardo la posicion 
				for (int j = i ; j < n ; j++){
					if (datos[j] < datos[menor]) menor = j; 
				}
				if (menor != i) {
					int swap = datos[i];
					datos[i] = datos[menor];
					datos[menor] = swap;				
				}
			}
		}
		
		public static void ordenarPorInsercion (int [] datos)
		{
			int n = datos.Length;
			int [] datos2 = new int[n];
			for (int i = 0; i < n ; i++){
				int j = i; 
				while ((j>0) && (datos[i]<datos2[j-1])){
					datos2[j] = datos2[j-1];
					j--;
				}
				datos2[j] = datos [i];
			}
		} /*revisar*/
		
		public static void ordenarPorBurbuja (int [] datos)
		{
			int n = datos.Length;
			int i = 0;
			bool ordenado = false;
			while ((i < (n-1)) && (!ordenado)){
				ordenado = true;
				for (int j = 0; j < (n-i-1); j++){
					if (datos[j] > datos [j+1]) {
						ordenado = false;
						int swap = datos[j];
						datos[j] = datos[j+1];
						datos[j+1] = swap;
					}
				}
			}
		}	

		public static void ordenarRapido (int [] datos, int primero, int ultimo)
		{
			int central = (ultimo + primero)/2;
			int pivote = datos[central];
			int i = primero, j = ultimo;
			bool salir = false;
			
			while (!salir){
				while (datos[i] < pivote) i++;
				while (datos[j] > pivote) j--;
				if (i<=j) {
					int swap = datos[i];
					datos[i] = datos[j];
					datos[j] = swap;
					i++; j--;
				}
				else 
					salir = true;
			}
			if (primero < j)
				ordenarRapido (datos, primero, j);
				
			if (i < ultimo)
				ordenarRapido (datos, i, ultimo);
		}
				
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int [] arreglo = new int[9] {3,7,2,5,8,6,4,9,1}; //arreglo de 9 elementos

			
			for (int i = 0; i < 9 ; i++){
				Console.Write (arreglo[i]+" -> ");
			}
			Console.WriteLine();
			ordenarRapido(arreglo, 0, 8);
			
			for (int i = 0; i < 9 ; i++){
				Console.Write (arreglo[i]+" -> ");
			}


			// TODO: Implement Functionality Here
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}