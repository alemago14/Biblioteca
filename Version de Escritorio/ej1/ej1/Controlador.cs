/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 03:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ej1
{
	/// <summary>
	/// Description of Controlador.
	/// </summary>
	public class Controlador
	{
		//Atributos
		public Button b1, b2;
		public List<Libro> libros;
		public List<Socio> socios;
		public List<Ejemplar> ejem, ejem2, ejem3;
		
		//constructor por defecto
		public Controlador(){}
		
		//Constructor que toma el formulario como parametro
		public Controlador(Button b1, Button b2)
		{
			this.b1 = b1;
			this.b2 = b2;
			
			libros = new List<Libro>();
			socios = new List<Socio>();
			 ejem = new List<Ejemplar>();
             ejem2 = new List<Ejemplar>();
             ejem3 = new List<Ejemplar>();
             
             //Listas de socios anteriores
             Socio s1 = new Socio("Pedro", "Picapiedra", 101);
            SocioVIP s2 = new SocioVIP("Pablo", "Marmol", 102, 30);
            socios.Add(s1);
            socios.Add(s2);

            //Listas de libros
            Libro l1 = new Libro("El codigo da vinci", "Dan Bronw", 97898758, ejem);
            Libro l2 = new Libro("Inferno", "Dan Bronw", 13244567, ejem2);
            Libro l3 = new Libro("Origen", "Dan Bronw", 12345678, ejem3);

            libros.Add(l1);
            libros.Add(l2);
            libros.Add(l3);

            //lista de ejemplares
            Ejemplar e1 = new Ejemplar(l1, 3, 33);
            Ejemplar e2 = new Ejemplar(l1, 3, 34);
            Ejemplar e3 = new Ejemplar(l1, 3, 35);

            ejem.Add(e1);
            ejem.Add(e2);
            ejem.Add(e3);


            Ejemplar e11 = new Ejemplar(l2, 6, 28);
            Ejemplar e21 = new Ejemplar(l2, 2, 29);
            Ejemplar e31 = new Ejemplar(l2, 3, 25);

            ejem2.Add(e11);
            ejem2.Add(e21);
            ejem2.Add(e31);

		}
		
		public void ListaSocios(){
			// disable once SuggestUseVarKeywordEvident
			Cuadro1 c1 = new Cuadro1(socios);
			c1.Show();
		}
		
		public void AgregarSocios(){
			Cuadro2 c2 = new Cuadro2(socios);
			c2.Show();
		}
		
		public void ListaLibros(){
			Cuadro3 c3 = new Cuadro3(libros);
			c3.Show();
		}
		
		public void AgregarLibro(){
			Cuadro4 c4 = new Cuadro4(libros);
			c4.Show();
		}
		
		public void PedirLibro(){
		Cuadro5 c5 = new Cuadro5(libros , socios);
			c5.Show();
		}
		
		public void DevolverLibro(){
			Cuadro6 c6 = new Cuadro6(libros, socios);
			c6.Show();
		}

            

		
		
	}
}
