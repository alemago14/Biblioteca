/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 04:02 p.m.
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
	/// Description of Cuadro1.
	/// </summary>
	public partial class Cuadro1 : Form
	{
		public List<Socio> socios;
		public List<Label> etis;
		
		public Cuadro1(List<Socio> socios)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.socios = socios;
			
			//lista de etiquetas
			etis = new List<Label>();
			etis.Add(label1);
			etis.Add(label2);
			etis.Add(label3);
			etis.Add(label4);
			etis.Add(label5);
			etis.Add(label10);
			etis.Add(label9);
			etis.Add(label8);
			etis.Add(label7);
			etis.Add(label6);
			
			//Metodo para mostrar los socios
			for(int i = 0; i <= socios.Count - 1; i++){
				etis[i].Text = socios[i].Imprimir() + "\n" + "Tiene "+ socios[i].EjemplaresRetirados.Count + " ejemplares en su haber.";
			}
		}
	}
}
