/*
 * Created by SharpDevelop.
 * User: Damaris Baldenegro
 * Date: 16/10/2014
 * Time: 06:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Practica3._
{
	class alumno{
		
		int sel;

		public alumno ()
		{

		}

		public void muestra(){

			Hashtable hash = new Hashtable();
		
			hash.Add(212473153, "Pablo Baldenegro Torres");
			hash.Add(212473154, "Pedro De La Rosa Zermeño");

			Console.WriteLine ("Los Codigos Ingresados son : ");

			foreach (int code in hash.Keys) 
			{
				Console.WriteLine (code);
			}

			Console.WriteLine ("Escribe el codigo que desea consultar");
			sel = int.Parse( Console.ReadLine());


			if (sel == 213473153) {
				Console.WriteLine (hash [213473153]);
			} else 
			{
				Console.WriteLine ("Error Codigo " + sel + "  No EXISTE ");
			}



		}


		public static void Main(string[] args){

			alumno simu = new alumno();
			simu.muestra();

			Console.ReadKey(true);
		}
	}
}