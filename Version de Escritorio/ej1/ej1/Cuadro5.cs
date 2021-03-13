/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 09/03/2021
 * Time: 12:06 a.m.
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
	/// Description of Cuadro5.
	/// </summary>
	public partial class Cuadro5 : Form
	{
		public List<Libro> libros;
		public List<Socio> socios;
		
		
		public Cuadro5(List<Libro> libros, List<Socio> socios)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.libros = libros;
			this.socios = socios;
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int ide = 0, n1 = 9, idL = 100;
			String cad = textBox1.Text;
			try {
				ide = int.Parse(cad);
				textBox1.BackColor = Color.White;
			}
			catch(FormatException exep){
				textBox1.BackColor = Color.OrangeRed;
				label1.Text = "Debe ingresar un numero de 3 cifras";
			}
			
			if (ide != 0){
				for(int i = 0; i <= socios.Count - 1; i++){
					if(socios[i].NumeroID == ide){
						label1.Text = "Socio " + socios[i].Nombre + " " + socios[i].Apellido + " Seleccionado.";
						n1 = i;
					}
				}
			}
			
			if(n1 == 9 && ide != 0){
				textBox1.BackColor = Color.OrangeRed;
				label1.Text = "Socio no encontrado";
			}
			
			if(socios[n1].EjemplaresRetirados.Count >= socios[n1].CantMaxima ){
				textBox1.BackColor = Color.OrangeRed;
				label1.Text = "El socio no tiene cupo";
				n1 = 9;
			}
			
			String nombreL = textBox2.Text;
			for(int i = 0; i <= libros.Count - 1; i++){
				if (nombreL.ToLower() == libros[i].Nombre.ToLower()){
					idL=i;
				}
			}
			
			if(idL == 100){
				textBox2.BackColor = Color.OrangeRed;
				label2.Text = "Libro no encontrado";
			}else{
				textBox2.BackColor = Color.White;
				label2.Text = " ";
			}
			
			if(libros[idL].bh() == 0 && idL != 100){
				textBox2.BackColor = Color.OrangeRed;
				label2.Text = "El libro no tiene mas ejemplares disponibles";
				idL = 100;
			}
			
			if(idL != 100 && n1 != 9){
				Ejemplar e15 = libros[idL].PrestarLibro();
				socios[n1].PedirPres(e15);
				
				Prestamo p1 = new Prestamo(socios[n1], e15);
				label3.Text = p1.ImprimirPrestamo();
			}
			
		}
	}
}
