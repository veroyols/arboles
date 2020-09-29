/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/9/2020
 * Hora: 02:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// nivel 0
			ArbolBinarioBusqueda raiz = new ArbolBinarioBusqueda (5); 
			
			// nivel 1
			ArbolBinarioBusqueda hijoizq = new ArbolBinarioBusqueda (3);
			ArbolBinarioBusqueda hijoder = new ArbolBinarioBusqueda (7); 
			raiz.agregarHijoIzquierdo(hijoizq);
			raiz.agregarHijoDerecho(hijoder);

			// nuevo elemento a agregar
			ArbolBinarioBusqueda nuevo = new ArbolBinarioBusqueda (4); 
			//raiz.agregar(IComparable nuevo);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

	}
}