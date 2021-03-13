/*
 * Created by SharpDevelop.
 * User: Maugouber
 * Date: 08/03/2021
 * Time: 11:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ej1
{
	partial class Cuadro3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadro3));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(458, 343);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(249, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 70);
			this.label5.TabIndex = 5;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(249, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(158, 70);
			this.label6.TabIndex = 4;
			this.label6.Text = "label6";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 70);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(249, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 70);
			this.label4.TabIndex = 2;
			this.label4.Text = "label4";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 70);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// Cuadro3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 343);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cuadro3";
			this.Text = "Lista de Libros";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
