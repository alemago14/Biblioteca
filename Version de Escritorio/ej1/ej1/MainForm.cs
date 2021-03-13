/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 12:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ej1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Controlador con1 = new Controlador();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			con1 = new Controlador(button1, button2);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			con1.ListaSocios();
		}
		void Button2Click(object sender, EventArgs e)
		{
			con1.AgregarSocios();
		}
		void Button3Click(object sender, EventArgs e)
		{
			con1.ListaLibros();
		}
		
		void NuevoLibro(object sender, EventArgs e)
		{
			con1.AgregarLibro();
		}
		void Button5Click(object sender, EventArgs e)
		{
			con1.PedirLibro();
		}
		void Button6Click(object sender, EventArgs e)
		{
			con1.DevolverLibro();
		}
	}
}
