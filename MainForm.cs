/*
 * Creado por SharpDevelop.
 * Usuario: Alumnos
 * Fecha: 02/05/2014
 * Hora: 09:55 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practicaGX
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string nombre = this.textBox1.Text;
			string codigo = this.textBox2.Text;
			string estados = this.numericUpDown1.Text;
			string continente = this.comboBox1.Text;
			
			int calificacion=0;
			
			if (estados == "31"){
			 calificacion++;
			}
			if(checkBox1.Checked && checkBox4.Checked){
				calificacion ++;
			}
			/*if(checkBox4.Checked){
				calificacion++;
			}
			*/if(radioButton1.Checked){
				calificacion++;
			}
			if(continente == "America"){
				calificacion++;
			}
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				calificacion++;
			}
			MessageBox.Show(nombre +',' +' ' +"tu calificacion es de " +calificacion +" de 5");
			}
		}
	}

