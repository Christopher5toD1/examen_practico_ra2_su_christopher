using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_capture_datos_de_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)

        {

            if (dlgGuardar.ShowDialog() == DialogResult.OK)
            {

                string rutaArchivo = dlgGuardar.FileName;
                string craTexto = rutaArchivo;
                StreamWriter archivo = File.CreateText(craTexto);
                archivo.WriteLine(textMatricula.Text);
                archivo.WriteLine(textNombre.Text);
                archivo.WriteLine(cbAreaTecnica.Text);
                archivo.Flush();
                archivo.Close();
            }

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnSalir.Enabled = false;
            
            btnNuevo.Enabled = true;

            




        }
      

     
       

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = true;
            btnSalir.Enabled = true;
            
            btnNuevo.Enabled = false;

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DialogResult Resultado;

            Resultado = MessageBox.Show("Para agregar presione si para no agregar presione no ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (Resultado == DialogResult.Yes)

           

            dgv_Cuadro.Rows.Add(textMatricula.Text, textNombre.Text, textTelefono.Text, textDireccion.Text, cbGenero.Text, cbCurso.Text, textEmail.Text, cbSeccion.Text, textMaestro.Text, cbAreaTecnica.Text);
            btnNuevo.Enabled = true;
           btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminar registro seleccionado del DataGridView
                dgv_Cuadro.Rows.Remove(dgv_Cuadro.CurrentRow);
                
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textMatricula.Clear();
             textDireccion.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            textMaestro.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;

            Resultado = MessageBox.Show("Esta seguro que quieres salir ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            { Close(); }

        }
    }
    }

