/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 12/9/2020
 * Hora: 22:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace tp2
{
	class Program
	{
		public static void Main(string[] args)
		{		
			ArbolBinario<int> raiz = new ArbolBinario<int> (1);
			ArbolBinario<int> izq = new ArbolBinario<int> (2);			
			ArbolBinario<int> der = new ArbolBinario<int> (3);
			
			raiz.agregarHijoIzquierdo(izq);
			raiz.agregarHijoDerecho(der);
			
			izq.agregarHijoIzquierdo(new ArbolBinario<int> (4));
			izq.agregarHijoDerecho(new ArbolBinario<int> (5));

			der.agregarHijoIzquierdo(new ArbolBinario<int> (6));
			der.agregarHijoDerecho(new ArbolBinario<int> (7));
			
			Console.WriteLine("Raiz tiene {0} hojas.",raiz.contarHojas());
			
			Console.WriteLine("arbol ejemplo");
			Console.WriteLine("		    1 \n" +
			                  "	    2		    3 \n" +
			                  "	4	5	6	7");
			Console.WriteLine ("-----------------------------------");

			Console.WriteLine("\n INORDEN: HIJO1 - RAIZ - HIJO2");
			raiz.inorden();
			
			Console.WriteLine("\n PREORDEN: RAIZ - HIJOS");
			raiz.preorden();
			
			Console.WriteLine("\n POSTORDEN: HIJOS - RAIZ");
			raiz.postorden();

			Console.WriteLine("\n RECORRIDO POR NIVELES");
			raiz.recorridoPorNiveles();
			Console.ReadKey(true);
		}
	}
}