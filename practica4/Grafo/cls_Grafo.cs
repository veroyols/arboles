using System;
using System.Collections.Generic;

namespace tp7
{

	public class Grafo<T>
	{
		public Grafo()
		{
		}
		
		private List<Vertice<T>>vertices = new List<Vertice<T>>();
	
		public void agregarVertice(Vertice<T> v) {
			v.setPosicion(vertices.Count + 1);
			vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v) {
			vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso) {
			origen.getAdyacentes().Add(new Arista<T>(destino,peso));
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}

//		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
//			Arista<T> arista;
//			foreach (var a in origen.getAdyacentes()) {
//				if (a.getDestino().Equals(destino))
//			}		arista = a;
//			origen.getAdyacentes().Remove(arista);
//		}		
	
		public List<Vertice<T>> getVertices() {
			return vertices;
		}

	
		public Vertice<T> vertice(int indice) {
			return this.vertices[indice];
		}
	

		public void DFS(Vertice<T> origen) {
			bool [] visitados = new bool [this.vertices.Count];
			this._DFS (origen, visitados);
		}
		
		private void _DFS(Vertice<T> origen, bool [ ] visitados) {
			//Imprimo el origen
			Console.WriteLine (origen.getDato ());
			//Marcar origen como visitado
			visitados [origen.getPosicion()-1] = true;
			//Recorro adyacentes
			foreach (var adyacente in origen.getAdyacentes()) {
				//si no fue visitado -> recursiva
				if (!visitados[adyacente.getDestino().getPosicion()-1])
					this._DFS(adyacente.getDestino(),visitados);
			}
		}
		
		public void BFS(Vertice<T> origen) {
			bool [] visitados = new bool [this.vertices.Count];
			Queue<Vertice<T>> cola = new Queue<Vertice<T>>();
			Vertice<T> verticeAux;
			
			cola.Enqueue(origen);
			visitados[origen.getPosicion() - 1] = true;
			
			while (cola.Count!=0) {
				verticeAux = cola.Dequeue();
				Console.WriteLine(verticeAux.getDato());
				//recorro adyacentes y encolo no visitados
				foreach (var adyacentes in verticeAux.getAdyacentes()) { //chequeo si fue visitado
					if (!visitados[adyacentes.getDestino().getPosicion() - 1]) {
						cola.Enqueue(adyacentes.getDestino());
						visitados[adyacentes.getDestino().getPosicion() - 1] = true;
					}
				}
				
			}
		}
		
		
	}
}
