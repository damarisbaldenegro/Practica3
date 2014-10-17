using System;
using System.Collections;
namespace Practica_03
{
    public class Alumno
    {
        private Hashtable Table=new Hashtable();
        private string Nombre;
        private string Codigo;
        private string edad;
        private string telefono;
        public Alumno()
        {

        }

        private void alta()
        {
            Console.Write("Ingrese nombre del alumno: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingresa codigo del alumno: ");
            Codigo = Console.ReadLine();
             Console.Write("Ingresa edad del alumno: ");
            edad = Console.ReadLine();
             Console.Write("Ingresa telefono del alumno: ");
            telefono = Console.ReadLine();
            try
            {
                Table.Add(Codigo, Nombre);
                Table.Add(edad,telefono);
            }
            catch
            {
                Console.Write("\nCodigo de alumno repetido\n");
            }
            
        }
         public void chido()
        {
            this.alta();
            this.alta();
            this.editar();
            this.imprimir();
            this.eliminar();
            this.imprimir();
            Console.ReadKey(true);
        }
        private void editar()
        {
            Console.Write("Codigo del alumno que desea Editar: ");
            Codigo = Console.ReadLine();
            if (Table.Contains(Codigo))
            {
                Console.Write("Coloque nuevo nombre: ");
                Nombre = Console.ReadLine();
                Table[Codigo] = Nombre;
                Console.WriteLine("Codigo " + Codigo + " Se ha editado");
            }
            else
            {
                Console.Write("\nNo Encontrado\n");
            }
        }
        private void eliminar()
        {
            Console.Write("\nCodigo del alumno que desea Eliminar");
            Codigo = Console.ReadLine();
            if (Table.ContainsKey(Codigo))
            {
                Console.WriteLine("Codigo "+Codigo+" Eliminado");
            }
            else
            {
                Console.Write("Codigo " + Codigo + " No se ha encontrado");
            }
            Table.Remove(Codigo);
        }
        private void imprimir()
        {
            Console.WriteLine("\n   Clave    Nombre");
            foreach (DictionaryEntry Bd in Table)
                Console.WriteLine("    {0}:    {1}", Bd.Key, Bd.Value);
        }
        	public static void Main(string[] args){

			Alumno s = new Alumno();
			s.chido();
       	    s.alta();
       	    
            s.editar();
            s.imprimir();
            s.eliminar();
            s.imprimir();

			Console.ReadKey(true);
		}

    }
}