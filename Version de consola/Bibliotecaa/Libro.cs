using System;
using System.Collections.Generic;

namespace Bibliotecaa
{
    public class Libro
    {
        //Atributos
        private String nombre, autor;
        private int codigoISBN;
        private List<Ejemplar> ejemplaresDisponibles;

        //getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public int CodigoISBN { get => codigoISBN; set => codigoISBN = value; }
        public List<Ejemplar> EjemplaresDisponibles { get => ejemplaresDisponibles; set => ejemplaresDisponibles = value; }

        //constructor por defecto
        public Libro()
        {
        }

        public Libro(string nombre, string autor, int codigoISBN)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.codigoISBN = codigoISBN;
            ejemplaresDisponibles = new List<Ejemplar>();
        }

        public Libro(string nombre, string autor, int codigoISBN, List<Ejemplar> ejemplaresDisponibles) : this(nombre, autor, codigoISBN)
        {
            this.ejemplaresDisponibles = ejemplaresDisponibles;
        }


        //metodos 
        //agregar ejemplar
        public void AgregarEjemplar(Ejemplar ej1)
        {
            ejemplaresDisponibles.Add(ej1);
        }

        //consultar ejemplares
        public bool Consultar()
        {
            if (ejemplaresDisponibles.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void bh()
        {
            int cf = EjemplaresDisponibles.Count;
            Console.WriteLine(cf);
        }

        //prestar libro
        public Ejemplar PrestarLibro()
        {
            Ejemplar e1 = ejemplaresDisponibles[0];
            if (Consultar() == true)
            {
                e1 = ejemplaresDisponibles[0];
                ejemplaresDisponibles.RemoveAt(0);
                return e1;
            }
            return e1;
        }

        //reingresar libro
        public void ReingresarLibro(Ejemplar ejemplar)
        {
            ejemplaresDisponibles.Add(ejemplar);
        }

        public void Imprimir()
        {
            Console.WriteLine("Libro");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Codigo: " + CodigoISBN);
        }

    }
}

