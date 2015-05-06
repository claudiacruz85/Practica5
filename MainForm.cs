/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 04/05/2015
 * Time: 04:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Practica5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//conexion a MariaDB
		MySqlConnection conexion =new MySqlConnection("server =localhost; Uid = root; password ='Cutonala080555'; database=Autores");
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void TextBoxcuerpoTextChanged(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBoxtituloTextChanged(object sender, EventArgs e)
		{
	
		}
		void FechaValueChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(textBoxautor.Text.Trim() == "")
			{
				errorP.SetError(textBoxautor, "Introduce Autor");
				textBoxautor.Focus();
			}
			if(textBoxtitulo.Text.Trim() == "")
				{
					errorP.SetError(textBoxtitulo, "Introduce Titulo");
					textBoxtitulo.Focus();
				}
			
			if(textBoxcuerpo.Text.Trim() == "")
					{
						errorP.SetError(textBoxcuerpo, "Introduce Cuerpo");
						textBoxcuerpo.Focus();
					}
				
			else
			{
			errorP.Dispose();
			try{
			conexion.Open();
			MySqlCommand guardar =new MySqlCommand("insert into articulos(id,fecha,Autor,titulo,cuerpo) values(default,'"+fecha.Text+"','"+textBoxautor.Text+"','"+textBoxtitulo.Text+"','"+textBoxcuerpo.Text+"')",conexion);
			guardar.ExecuteNonQuery();
			MessageBox.Show("Documento Guardado");
			conexion.Close();
			textBoxautor.Text = "";
			textBoxtitulo.Text = "";
			textBoxcuerpo.Text = "";
			}
			
			catch (Exception)
			{

			}
		}
		}
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("Limpiar Campos?", "Exit", MessageBoxButtons.YesNo);
			if(resultado == DialogResult.Yes){
			textBoxautor.Text = "";
			textBoxtitulo.Text = "";
			textBoxcuerpo.Text = "";
			}
				
		}
		void TextBoxautorValidated(object sender, EventArgs e)
		{
			/*if(textBoxautor.Text.Trim() == "")
			{
				errorP.SetError(textBoxautor, "Introduce Autor");
				textBoxautor.Focus();
			}
			else
			{
				errorP.Clear();
			}*/
		}
		void TextBoxtituloValidated(object sender, EventArgs e)
		{
			/*if(textBoxtitulo.Text.Trim() == "")
			{
				errorP.SetError(textBoxtitulo, "Introduce Titulo");
				textBoxtitulo.Focus();
			}
			else
			{
				errorP.Clear();
			}*/
		}
		void TextBoxcuerpoValidated(object sender, EventArgs e)
		{
			/*if(textBoxcuerpo.Text.Trim() == "")
			{
				errorP.SetError(textBoxcuerpo, "Introduce Cuerpo");
				textBoxcuerpo.Focus();
			}
			else
			{
				errorP.Clear();
			}*/
		}
		void TextBoxautorTextChanged(object sender, EventArgs e)
		{
	
		}
		void BotonenviarValidated(object sender, EventArgs e)
		{
	
		}
		
	}
}
