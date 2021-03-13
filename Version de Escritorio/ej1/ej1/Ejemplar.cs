using System;
namespace ej1
{
    public class Ejemplar
    {
        //atributos
        private Libro libro;
        private int numeroEdicion;
        private int direccion;

        //getters y setters
        public Libro Libro { get { return libro;} set { libro = value; }}
        public int NumeroEdicion { get { return numeroEdicion;} set { numeroEdicion = value; }}
        public int Direccion { get { return direccion;} set { direccion = value; }}

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

        public String Imprimir()
        {
            return libro.Imprimir() + "\n" +
            "N° Edicion: " + NumeroEdicion + "\n"
            + "Ubicación: " + Direccion;
        }
    }
}
