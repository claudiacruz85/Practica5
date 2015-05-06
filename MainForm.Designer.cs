/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 04/05/2015
 * Time: 04:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker fecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxautor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxtitulo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxcuerpo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button botonenviar;
		private System.Windows.Forms.ErrorProvider errorP;
		private System.Windows.Forms.Label label4;
		
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
			this.components = new System.ComponentModel.Container();
			this.fecha = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxautor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxtitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxcuerpo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.botonenviar = new System.Windows.Forms.Button();
			this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
			this.SuspendLayout();
			// 
			// fecha
			// 
			this.fecha.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fecha.Location = new System.Drawing.Point(27, 93);
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(456, 40);
			this.fecha.TabIndex = 0;
			this.fecha.ValueChanged += new System.EventHandler(this.FechaValueChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Autor:";
			// 
			// textBoxautor
			// 
			this.textBoxautor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxautor.Location = new System.Drawing.Point(133, 162);
			this.textBoxautor.Name = "textBoxautor";
			this.textBoxautor.Size = new System.Drawing.Size(350, 40);
			this.textBoxautor.TabIndex = 2;
			this.textBoxautor.TextChanged += new System.EventHandler(this.TextBoxautorTextChanged);
			this.textBoxautor.Validated += new System.EventHandler(this.TextBoxautorValidated);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Motion Picture Personal Use ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(546, 76);
			this.label2.TabIndex = 3;
			this.label2.Text = "Recopilador de Obras Nuevas";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxtitulo
			// 
			this.textBoxtitulo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxtitulo.Location = new System.Drawing.Point(133, 216);
			this.textBoxtitulo.Name = "textBoxtitulo";
			this.textBoxtitulo.Size = new System.Drawing.Size(350, 40);
			this.textBoxtitulo.TabIndex = 4;
			this.textBoxtitulo.TextChanged += new System.EventHandler(this.TextBoxtituloTextChanged);
			this.textBoxtitulo.Validated += new System.EventHandler(this.TextBoxtituloValidated);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 40);
			this.label3.TabIndex = 5;
			this.label3.Text = "Titulo:";
			// 
			// textBoxcuerpo
			// 
			this.textBoxcuerpo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxcuerpo.Location = new System.Drawing.Point(27, 318);
			this.textBoxcuerpo.Multiline = true;
			this.textBoxcuerpo.Name = "textBoxcuerpo";
			this.textBoxcuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxcuerpo.Size = new System.Drawing.Size(456, 216);
			this.textBoxcuerpo.TabIndex = 6;
			this.textBoxcuerpo.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBoxcuerpo.Validated += new System.EventHandler(this.TextBoxcuerpoValidated);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(27, 554);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 59);
			this.button1.TabIndex = 7;
			this.button1.Text = "Limpiar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// botonenviar
			// 
			this.botonenviar.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.botonenviar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonenviar.Location = new System.Drawing.Point(266, 553);
			this.botonenviar.Name = "botonenviar";
			this.botonenviar.Size = new System.Drawing.Size(187, 59);
			this.botonenviar.TabIndex = 8;
			this.botonenviar.Text = "Enviar";
			this.botonenviar.UseVisualStyleBackColor = false;
			this.botonenviar.Click += new System.EventHandler(this.Button2Click);
			this.botonenviar.Validated += new System.EventHandler(this.BotonenviarValidated);
			// 
			// errorP
			// 
			this.errorP.ContainerControl = this;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(204, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 40);
			this.label4.TabIndex = 9;
			this.label4.Text = "Cuerpo:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 644);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.botonenviar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxcuerpo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxtitulo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxautor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fecha);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autores";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
