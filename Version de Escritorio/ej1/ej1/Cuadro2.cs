/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 04:40 p.m.
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
	/// Description of Cuadro2.
	/// </summary>
	public partial class Cuadro2 : Form
	{
		public List<Socio> socios;
		public Cuadro2(List<Socio> socios)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.socios = socios;
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			String nombre = textBox1.Text;
			String apellido = textBox2.Text;
			int ide = new Random().Next(99, 999);
			
			if(checkBox1.Checked == true){
				SocioVIP sv = new SocioVIP(nombre, apellido, ide, 30);
				socios.Add(sv);
				
				label3.Text = "Socio Agregado" + "\n" + sv.Imprimir();
			}else{
				Socio sc = new Socio(nombre, apellido, ide);
				socios.Add(sc);
				
				label3.Text = "Socio Agregado" + "\n" + sc.Imprimir();
			}
		}
	}
}
