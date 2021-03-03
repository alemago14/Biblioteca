using System;
using System.Collections.Generic;

namespace Bibliotecaa
{
    public class Socio
    {
        //atributos
        protected String nombre, apellido;
        protected int numeroID, cantMaxima;
        protected List<Ejemplar> ejemplaresRetirados;
        public Ejemplar ej2;

        //getter y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroID { get => numeroID; set => numeroID = value; }
        public int CantMaxima { get => cantMaxima; set => cantMaxima = value; }
        public List<Ejemplar> EjemplaresRetirados { get => ejemplaresRetirados; set => ejemplaresRetirados = value; }

        //constructor po defecto
        public Socio()
        {
        }

        //constructor con todos los elem de la clase
        public Socio(string nombre, string apellido, int numeroID)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroID = numeroID;
            cantMaxima = 3;
            ejemplaresRetirados = new List<Ejemplar>();
        }

        public Socio(string nombre, string apellido, int numeroID, List<Ejemplar> ejemplaresRetirados) : this(nombre, apellido, numeroID)
        {
            this.ejemplaresRetirados = ejemplaresRetirados;
        }



        //metodos
        //consultar si el socio tiene cupo disponible para retirar libros socio comun max 3
        public virtual bool ConsultarCupo()
        {
            if (ejemplaresRetirados.Count <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool ConsultarCant()
        {
            return ejemplaresRetirados.Count == 0 ? true : false;
        }

        //pedir prestado un ejemplar y agregarlo a la lista del socio
        public virtual void PedirPres(Ejemplar ej1)
        {
            ejemplaresRetirados.Add(ej1);
        }

        //devolver un ejemplar
        //devolver un ejemplar
        public virtual Ejemplar DevolverEj(String nLibro)
        {

            for (int i = 0; i <= ejemplaresRetirados.Count - 1; i++)
            {
                if (ejemplaresRetirados[i].Libro.Nombre.ToLower() == nLibro.ToLower())
                {
                    ej2 = ejemplaresRetirados[i];
                    ejemplaresRetirados.RemoveAt(i);
                }
            }

            return ej2;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine("Socio Clasico");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("ID: " + NumeroID);
        }

        public virtual void ImprimirE()
        {
            for(int i = 0; i <= ejemplaresRetirados.Count - 1; i++)
            {
                ejemplaresRetirados[i].Imprimir();
            }
        }
    }
}
