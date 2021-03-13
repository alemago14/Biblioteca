/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 11:06 p.m.
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
	/// Description of Cuadro3.
	/// </summary>
	public partial class Cuadro3 : Form
	{
		public List<Libro> libros;
		public List<Label> etis;
		public Cuadro3(List<Libro> libros)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.libros = libros;
			etis = new List<Label>();
			
			etis.Add(label1);
			etis.Add(label2);
			etis.Add(label3);
			etis.Add(label4);
			etis.Add(label6);
			etis.Add(label5);
			
			for(int i = 0; i <= libros.Count - 1; i++){
				etis[i].Text = libros[i].Imprimir() + "\n" + "Ejemplares disponibles: " + libros[i].bh().ToString();
			}
		}
	}
}
