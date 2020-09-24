using System;

namespace Ejercicio_1
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		/*inorden: hijo1 - raiz - hijos der*/
		public void inorden() {
			if (this.getHijoIzquierdo() != null){
				this.getHijoIzquierdo().inorden();
			}
			Console.Write (" -> " + this.getDatoRaiz());
			if (this.getHijoDerecho() != null){
				this.getHijoDerecho().inorden();
			}
		}
		
		/*raiz - hijos*/
		public void preorden() {
			Console.Write (" -> " + this.getDatoRaiz());
			if (this.getHijoIzquierdo() != null){
				this.getHijoIzquierdo().preorden();
			}
			
			if (this.getHijoDerecho() != null){
				this.getHijoDerecho().preorden();
			}
		}
		
		/*HIJOS - RAIZ*/
		public void postorden() {
			if (this.getHijoIzquierdo() != null){
				this.getHijoIzquierdo().postorden();
			}
			
			if (this.getHijoDerecho() != null){
				this.getHijoDerecho().postorden();
			}
			Console.Write (" -> " + this.getDatoRaiz());
		}
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			cola.encolar(this);
			while (!cola.esVacia()) {
				ArbolBinario<T> nodo = cola.desencolar();
				Console.Write(" -> " + nodo.getDatoRaiz());
				if (nodo.getHijoIzquierdo() != null)
					cola.encolar(nodo.getHijoIzquierdo());
				if (nodo.getHijoDerecho() != null)
					cola.encolar(nodo.getHijoDerecho());
			}
			
		}
	
		public int contarHojas() {
			/*CASO BASE: SI ES HOJA*/
			if (this.esHoja()){
				return 1;
			}   
			int cdad =  0;
			if (this.getHijoIzquierdo() != null) {
				Console.WriteLine(this.getHijoIzquierdo().getDatoRaiz());
				cdad += this.getHijoIzquierdo().contarHojas();
			}
			if (this.getHijoDerecho() != null) {
				Console.WriteLine(this.getHijoDerecho().getDatoRaiz());
				cdad += this.getHijoDerecho().contarHojas();
			}
			return cdad;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
