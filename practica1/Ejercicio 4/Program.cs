/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 8/9/2020
 * Hora: 16:29
 * 
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			//nivel 0
			ArbolGeneral <int> raiz = new ArbolGeneral <int> (1);
			
			//nivel 1
			ArbolGeneral <int> unHijo = new ArbolGeneral <int> (2);
			ArbolGeneral <int> otroHijo = new ArbolGeneral <int> (3);
			raiz.agregarHijo (unHijo);
			raiz.agregarHijo (otroHijo);
			
			//nivel 2
			ArbolGeneral <int> hijo4 = new ArbolGeneral <int> (4);
			ArbolGeneral <int> hijo5 = new ArbolGeneral <int> (5);
			ArbolGeneral <int> hijo6 = new ArbolGeneral <int> (6);
			unHijo.agregarHijo(hijo4);
			unHijo.agregarHijo(hijo5);
			unHijo.agregarHijo(hijo6);
			
			//nivel 3
			ArbolGeneral <int> nivel3 = new ArbolGeneral <int> (7);
			otroHijo.agregarHijo(nivel3);
			
			//nivel 4
			otroHijo.agregarHijo(new ArbolGeneral<int> (8)); //no tiene nombre de referencia
			
//			Para imprimir hijos
//			foreach (ArbolGeneral<int> ele in raiz.getHijos()) {
//				Console.WriteLine(ele.getDatoRaiz());
//			}
			
			Console.WriteLine(raiz);
			
			List<int> lista = new List<int> () {3,6,9,2,5,8,0,2,1,4};
			int i = lista.IndexOf(9);
			foreach (int element in lista.GetRange(i, lista.Count - i)) {
				Console.Write (element);
			}
			
			Console.WriteLine ("\npreOrden");
			raiz.preOrden();
			
		
//			Console.WriteLine ("\ninOrden");
//			raiz.inOrden();
//			
//			Console.WriteLine ("\npostOrden");
//			raiz.postOrden();
//			
//			Console.WriteLine ("\nporNiveles");
//			raiz.porNiveles();
			
			Console.WriteLine();
			
/*nivel(Object dato):int devuelve el nivel o profundidad (nivel de la raiz = 0) del dato en el árbol, la longitud de la raíz al nodo.
Pista: Si el nodo raíz posee el mismo dato que pasado como parámetro, se retorna 0. En caso contrario, se debe buscar en cuales de los subárbo -
les hijos se encuentra el dato (implemente el mensaje include (Object dato) en la clase Arbol General) y se debe retornar 1 más el nivel que arroje
enviar el mensaje nivel() al subárbol que incluye el dato.*/
			int dato = 6;			
			if (dato == raiz.getDatoRaiz()) {
				Console.WriteLine ("El dato {0} se encuentra en la raiz", dato);
			}
			Console.WriteLine ("El dato {0} no se encuentra en la raiz", dato);
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}