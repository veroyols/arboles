using System;
using System.Collections.Generic;

namespace Ejercicio_4
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
		
		//ORDENAMIENTO
		public void preOrden () {
			//raiz
			Console.Write (this.getDatoRaiz()+" ");
			//los hijos recursivamente
			foreach (var hijos in this.getHijos())
				hijos.preOrden();
		}
		
		//ok
		public void inOrden () {
			//primer hijo recursivamente
			if (this.getHijos().Count > 0 ) 
				this.getHijos()[0].inOrden();
			//raiz
			Console.Write (this.getDatoRaiz()+" ");
			//otros hijos recursivamente
			for (int i = 1 ; i < this.getHijos().Count ; i++)
				this.getHijos()[i].inOrden();
		}

		public void postOrden () {
			//los hijos recursivamente
			foreach (var hijos in this.getHijos())
				hijos.postOrden();		
			//raiz
			Console.Write (this.getDatoRaiz()+" ");
		}

		public void porNiveles () {
			Cola<ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>> ();
			ArbolGeneral<T> arbolAuxiliar; //hay que poner un dato
			//referencia nombre = nuevo objeto tipo arbol -> no instancio new arbol
			cola.encolar(this);

			while (!cola.esVacia()) {
				arbolAuxiliar = cola.desencolar(); //saco el objeto de cola
				Console.Write (arbolAuxiliar.getDatoRaiz() + " ");
				foreach (ArbolGeneral<T> hijos in arbolAuxiliar.getHijos()) { //encolar hijos
					cola.encolar(hijos);
				}	
			}
		}
		
//Ejercicio4		
//altura(): int devuelve la altura del árbol, es decir, la longitud del camino más largo desde el nodo raíz hasta una hoja.
//Pista: Si el árbol es una sola hoja, se devuelve 0. 
//Sino, con getHijos() debe iterar por cada uno de los hijos, guardando la máxima altura. return AlturaMax+1.
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
		
/* ancho():int Amplitud o ancho: cantidad de nodos que se encuentran en el nivel de mayor cantidad de nodos.
Pista: Recorrido por niveles. Encolar la raíz del árbol y luego una marca null (o el número de nivel) para indicar el fin de
nivel. Mientras la cola no se vacía, itere. En cada iteración extraiga el tope de la cola, y con la operación getHijos() 
encole los mismos. Cuando encuentra la marca de fin de nivel cuente si los elementos del nivel es mayor a la máxima cantidad que poseía*/
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

/*nivel(Object dato):int devuelve el nivel o profundidad (nivel de la raiz = 0) del dato en el árbol, la longitud de la raíz al nodo.
Pista: Si el nodo raíz posee el mismo dato que pasado como parámetro, se retorna 0. En caso contrario, se debe buscar en cuales de los subárbo -
les hijos se encuentra el dato (implemente el mensaje include (Object dato) en la clase Arbol General) y se debe retornar 1 más el nivel que arroje
enviar el mensaje nivel() al subárbol que incluye el dato.*/
//		public int profundidad(int dato) {
//			if (dato == this.getDatoRaiz()) return 0;
//}
	
		
/* Ejercicio 5
Sea una red de agua potable, la cual comienza en un caño maestro y el mismo se va dividiendo hasta llegar a cada casa. 
Por el caño maestro ingresan 1000 litros y en la medida que se divide, el caudal se divide en partes iguales.
Usted debe implementar un método en la clase árbol general, que considerando que ingresan 1000 litros por el caño maestro, 
calcule el caudal de cada nodo y determine cual es el mínimo caudal que recibe una casa.
 si nivel=0 -> caudal=1000
 nivel=1 -> caudal=1000/ancho*/
		public int caudal () {
			return 0;
		}


		/*para que no aparezca namespace.tipo*/
		public override string ToString() {//sobreescritura de metodo
			return " ----Arbol General----\n|     Altura >> "+this.altura()+"    |\n|     Ancho  >> "+this.ancho()+"    |\n ---------------------";
		}
	}
}
