/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 11:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ej1
{
	/// <summary>
	/// Description of Cuadro4.
	/// </summary>
	public partial class Cuadro4 : Form
	{
		public List<Libro> libros;
		public Cuadro4(List<Libro> libros)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.libros = libros;
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			String nombre = textBox1.Text;
			String autor = textBox2.Text;
			int ide = new Random().Next(9999999, 99999999);
			
			Libro ln = new Libro(nombre, autor, ide);
			
			libros.Add(ln);
			
			label1.Text = "Libro Agregado: " + "\n" + ln.Imprimir();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int clave = 0, inde = 9, edicion = 0, ubi = 0;
			String nombre2 = textBox3.Text;
			nombre2 = nombre2.ToLower();
			
			for (int i = 0; i <= libros.Count - 1; i++){
				if (nombre2 == libros[i].Nombre.ToLower()){
					inde = i;
				}
			}
			
			if (inde == 9){
				textBox3.BackColor = Color.OrangeRed;
			}else {textBox3.BackColor = Color.White;
				clave = clave +1;}
			
			String cad = textBox4.Text;
			
			try{
				edicion = int.Parse(cad);
				textBox4.BackColor = Color.White;
				clave = clave +1;
			}
			catch(FormatException exep){
				textBox4.BackColor = Color.OrangeRed;
			}
			
			String cad1 = textBox5.Text;
			
			try{
				ubi = int.Parse(cad1);
				textBox5.BackColor = Color.White;
				clave = clave +1;
			}
			catch(FormatException exep){
				textBox5.BackColor = Color.OrangeRed;
			}
			
			if(clave == 3){
				Ejemplar e15 = new Ejemplar(libros[inde],edicion, ubi);
				libros[inde].AgregarEjemplar(e15);
				label2.Text = "Ejemplar Agregado" + "\n" + e15.Imprimir();			}
		}
		
		
	}
}
