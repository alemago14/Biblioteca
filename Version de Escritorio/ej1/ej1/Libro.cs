/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 12:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ej1
{
	/// <summary>
	/// Description of Libro.
	/// </summary>
	public class Libro
	{
		//Atributos
		private String nombre, autor;
		private int codigoISBN;
		private List<Ejemplar> ejemplaresDisponibles;

		public String Nombre {get {return nombre;} set{ nombre = value;}}
		public String Autor {get {return autor;} set{autor = value;}}
		public int CodigoISBN{get{return codigoISBN;}set{codigoISBN = value;}}
		public List<Ejemplar> EjemplaresDisponibles {get{return ejemplaresDisponibles;} set {ejemplaresDisponibles = value;}}
		

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

		public int bh()
		{
			int cf = EjemplaresDisponibles.Count;
			return cf;
			
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

		public String Imprimir()
		{
			return "Nombre: " + Nombre + "\n" +
			"Autor: " + Autor + "\n" +
			"Codigo: " + CodigoISBN;
		}

	}

}
