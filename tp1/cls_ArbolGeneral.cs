using System;
using System.Collections.Generic;

namespace tp1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();
		
		/*CONSTRUCTOR ok*/
		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
		
		/*DEVUELVE EL VALOR DE ESE NODO ok*/
		public T getDatoRaiz() {
			return this.dato;
		}
		
		/*DEVUELVE LOS HIJOS DE ESTE ARBOL ok*/
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
		
		/*AGREGA UN HIJO ok*/
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
		
		/*ELIMINA HIJO DE LA LISTA */
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
		
		/*DEVUELVE TRUE SI NO TIENE HIJOS */
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
		
//altura(): int devuelve la altura del árbol, es decir, la longitud del camino más largo desde el nodo raíz hasta una hoja.
//Pista: El mensaje altura debe chequear si el árbol es una sola hoja o no. 
//Si el árbol es una sola hoja, se devuelve 0. 
//Si no, se utiliza el mensaje getHijos() para obtener la lista de hijos (recuerde que devuelve una lista de árboles hijos). 
//Luego, debe iterar por cada uno de los hijos, guardando la máxima altura. A este valor se le debe sumar 1 y retornarlo.
		
		public int altura() {
			/*CASO BASE: SI ES HOJA*/
			if (this.esHoja())
				return 0;
			else {
				int alturaMaxima =  -100;
				/*si no es hoja: no hace falta el else porque si no es el caso base entra por aca*/
				foreach (ArbolGeneral<T> Hijo in this.getHijos()) {
					int alturaHijo = Hijo.altura();
					if (alturaHijo > alturaMaxima) 
						alturaMaxima = alturaHijo;
				}
				return alturaMaxima+1;
			}
		} /*revisar*/
		
/* ancho():int La amplitud (ancho) de un árbol se define como la cantidad de nodos que se encuentran en el nivel 
 * que posee la mayor cantidad de nodos.
		Pista: Realice un recorrido por niveles. Encole inicialmente la raíz del árbol y luego una marca null (o el número de nivel) para indicar el fin de
		nivel. Mientras la cola no se vacía, itere. En cada iteración extraiga el tope de la cola, y con la operación getH*/
		public int ancho() {
			if (this.esHoja())
				return 1;
			Queue <ArbolGeneral<T>> cola = new Queue <ArbolGeneral<T>>();
			cola.Enqueue(this);//Encolo raiz
			int maxCantidadNivel = 0;
			while (cola.Count !=0) { //mientras la cola no este vacia.. agregar metodo IsEmpty
				int cantidadNivel = cola.Count; //Me quedo con la cantidad de nodos que tengo en la cola, nodos por nivel
				if (cantidadNivel > maxCantidadNivel)
					maxCantidadNivel = cantidadNivel; //actualizo el maximo
				//while (cantidadNivel > 0) { //utilizo la cantidad de nivel y decremento
				for (int i = 0; i<cantidadNivel; i++) {
					ArbolGeneral<T> arbol = cola.Dequeue(); //desencola
					foreach (ArbolGeneral<T> hijo in arbol.getHijos()){
						cola.Enqueue(hijo);
					}
					cantidadNivel = cantidadNivel-1;
				}
			}
			return maxCantidadNivel;
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
		
		/*para que no aparezca namespace.tipo*/
		public override string ToString() {//sobreescritura de metodo
			return " ----Arbol General----\n|     Altura >> "+this.altura()+"    |\n|     Ancho  >> "+this.ancho()+"    |\n ---------------------";
		}
	}
}
