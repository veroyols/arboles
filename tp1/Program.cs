/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 8/9/2020
 * Hora: 16:29
 * 
 */
using System;
using System.Collections.Generic;

namespace tp1
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			ArbolGeneral <int> raiz = new ArbolGeneral <int> (1);
			ArbolGeneral <int> unHijo = new ArbolGeneral <int> (2);
			ArbolGeneral <int> otroHijo = new ArbolGeneral <int> (3);
			
			raiz.agregarHijo (unHijo);
			raiz.agregarHijo (otroHijo);
			
			ArbolGeneral <int> hijo4 = new ArbolGeneral <int> (4);
			ArbolGeneral <int> hijo5 = new ArbolGeneral <int> (5);
			ArbolGeneral <int> hijo6 = new ArbolGeneral <int> (6);
			
			otroHijo.agregarHijo(hijo4);
			otroHijo.agregarHijo(hijo5);
			otroHijo.agregarHijo(hijo6);
			
			ArbolGeneral <int> nivel3 = new ArbolGeneral <int> (7);
			hijo6.agregarHijo(nivel3);
			
//			Para imprimir hijos
//			foreach (ArbolGeneral<int> element in raiz.getHijos()) {
//				Console.WriteLine(element.getDatoRaiz());
//			}
			
			Console.WriteLine(raiz);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}