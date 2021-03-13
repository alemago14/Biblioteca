/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 12:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ej1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 243);
			this.panel1.TabIndex = 0;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(187, 188);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(114, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "Devolver Libro";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(65, 188);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "Pedir Libro";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Opciones";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(187, 100);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(114, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Agregar nuevo libro";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.NuevoLibro);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(65, 102);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 22);
			this.button3.TabIndex = 4;
			this.button3.Text = "Lista de libros";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Libros";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(187, 29);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Agregar nuevo socio";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(65, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "Lista de Socios";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Socios";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 242);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Biblioteca";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
