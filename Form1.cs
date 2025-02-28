using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FrmNotas
{
    public partial class FrmNotas : Form
    {
        // Inicializar Variables Globales
        String alumno;
        int nota1, nota2, nota3, promedioGeneral = 0;

        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = lstAlumno.SelectedIndex;

            // Eliminar elementos de la lista
            lstAlumno.Items.RemoveAt(indice);
            lstNota1.Items.RemoveAt(indice);
            lstNota2.Items.RemoveAt(indice);
            lstNota3.Items.RemoveAt(indice);
            lstPromedio.Items.RemoveAt(indice);

            int total = 0;
            for (int i = 0; i < lstPromedio.Items.Count; i++)
            {
                total += Convert.ToInt32(lstPromedio.Items[i]);
            }

            txtPromedioGeneral.Text = total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar Datos
            txtAlumno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void lstPromedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstPromedio);
        }

        private void lstNota1_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota1);
        }

        private void lstNota2_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota2);
        }

        private void lstNota3_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstNota3);
        }

        private void lstAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcar(lstAlumno);
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Asignar campos a las variables
            nota1 = Convert.ToInt32(txtNota1.Text);
            nota2 = Convert.ToInt32(txtNota2.Text);
            nota3 = Convert.ToInt32(txtNota3.Text);
            alumno = txtAlumno.Text;
            promedioGeneral = (nota1 + nota2 + nota3) / 3;

            // Agregar datos a las listas
            lstNota1.Items.Add(nota1);
            lstNota2.Items.Add(nota2);
            lstNota3.Items.Add(nota3);
            lstPromedio.Items.Add(promedioGeneral);
            lstAlumno.Items.Add(alumno);

            int total = 0;
            for (int i = 0; i < lstPromedio.Items.Count; i++)
            {
                total += Convert.ToInt32(lstPromedio.Items[i]);
            }

            txtPromedioGeneral.Text = total.ToString();
        }

        private void marcar(ListBox lista)
        {
            int indice;

            indice = lista.SelectedIndex;
            lstAlumno.SelectedIndex = indice;
            lstNota1.SelectedIndex = indice;
            lstNota2.SelectedIndex = indice;
            lstNota3.SelectedIndex = indice;
            lstPromedio.SelectedIndex = indice;

        }
    }
}
