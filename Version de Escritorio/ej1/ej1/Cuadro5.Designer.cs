﻿/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 09/03/2021
 * Time: 12:06 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ej1
{
	partial class Cuadro5
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 325);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(172, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(278, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = " ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(172, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = " ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(65, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Pedir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(42, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(123, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Nombre del Libro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(42, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Id del socio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(42, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(408, 127);
			this.label3.TabIndex = 5;
			this.label3.Text = " ";
			// 
			// Cuadro5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 327);
			this.Controls.Add(this.panel1);
			this.Name = "Cuadro5";
			this.Text = "Pedir Libro";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
