using System;
namespace Bibliotecaa
{
    public class Ejemplar
    {
        //atributos
        private Libro libro;
        private int numeroEdicion;
        private int direccion;

        //getters y setters
        public Libro Libro { get => libro; set => libro = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public int Direccion { get => direccion; set => direccion = value; }

        //constructor por defecto
        public Ejemplar()
        {
        }

        //constructor
        public Ejemplar(Libro libro, int numeroEdicion, int direccion)
        {
            this.libro = libro;
            this.numeroEdicion = numeroEdicion;
            this.direccion = direccion;
        }

        public void Imprimir()
        {
            libro.Imprimir();
            Console.WriteLine("N° Edicion: " + NumeroEdicion);
            Console.WriteLine("Ubicación: " + Direccion);
        }
    }
}
