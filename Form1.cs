using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practico_de_vectores_1_y_2
{
     public partial class Form1 : Form
     {
	    public Form1()
	    {
		   InitializeComponent();
	    }

	    Vector v1, v2;

	    private void Form1_Load(object sender, EventArgs e)
	    {
		   v1 = new Vector();
		   v2 = new Vector();
	    }

	    private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
	    {
		   v1.Cagar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
		   textBox4.Text = v1.Descargar();
	    }

	    private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
	    {
		   textBox4.Text = v1.Descargar();
	    }

	    private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
	    {
		   int a = int.Parse(Interaction.InputBox("", "", ""));
		   int b = int.Parse(Interaction.InputBox("", "", ""));
		   v1.Eliminar_Elementos(a, b);
		   textBox5.Text = v1.Descargar();
	    }
     }
}
