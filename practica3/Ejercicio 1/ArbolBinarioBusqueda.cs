using System;

namespace Ejercicio_1
{

	public class ArbolBinarioBusqueda{
		
		private IComparable dato;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
		
		/*CONSTRUCTOR*/
		public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
		}
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		// si se encuentra un punto de inserción → crear nuevo vértice
		// si el valor a ser insertado < this clave → 	ir a izquierda; 
		// sino ir a derecha
		public void agregar(IComparable elem) {
			Console.WriteLine((this.getDatoRaiz()));
		}
		
		public bool incluye(IComparable elem) {
			return false;
		}

		public void preorden() {
		}
		
		public void inorden() {
		}
		
		public void postorden() {
		}
		
	}
}