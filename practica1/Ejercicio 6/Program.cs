/* Ejercicio 6
Un quadtree es una representación usada para cubrir un espacio cuadrado en dos dimensiones y posteriormente utilizado para determinar
ciertas condiciones entre objetos en el mismo.Un artista moderno trabaja con imágenes codificadas en quadtrees. El quadtree es un árbol 
4-ario que codifica a una imagen con el siguiente criterio:
- Si toda la imagen tiene un mismo color, la misma es representada por un único nodo que almacene un dato que represente a ese color.
- En caso contrario, se divide la imagen en cuatro cuadrantes que se representan en el árbol como un nodo con 4 hijos, y cada hijo es 
la conversión de cada una de las partes de la imagen.
El artista desea saber cuántos pixeles de color negro posee una imagen dada. Usted debe implementar un método, que dado un quadtree y una
cantidad total de pixeles, cuente cuantos pixeles de color negro contiene la imagen codificada en él.*/
using System;

namespace Ejercicio_6 
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}