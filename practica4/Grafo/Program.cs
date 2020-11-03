/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 3/11/2020
 * Hora: 03:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace tp7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Grafo <string> museo = new Grafo<string>();
			
			Vertice <string> sala1 = new Vertice <string> ("sala1");
			Vertice <string> sala2 = new Vertice <string> ("sala2");
			
			museo.agregarVertice(sala1);
			museo.agregarVertice(sala2);

			museo.conectar(sala1,sala2,0);
			museo.conectar(sala2,sala1,0);

			
			Vertice <string> sala3 = new Vertice <string> ("sala3");
			Vertice <string> sala4 = new Vertice <string> ("sala4");
			
			museo.agregarVertice(sala3);
			museo.agregarVertice(sala4);

			museo.conectar(sala1,sala3,0);
			museo.conectar(sala3,sala1,0);

			museo.conectar(sala1,sala4,0);
			museo.conectar(sala4,sala1,0);
			
			museo.conectar(sala2,sala3,0);
			museo.conectar(sala3,sala2,0);
			
			
			museo.BFS(sala4);
			//museo.DFS(sala1);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}