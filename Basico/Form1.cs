﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEjecuto_Click(object sender, EventArgs e)
        {
            int numCaracteres = txtNombre.TextLength;

            if (numCaracteres == 0)
            {
                MessageBox.Show("Debes escribir un nombre");
            }
            else
            {
                MessageBox.Show("Hola " + txtNombre.Text + "!!!");
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {


            try
            {
                byte revisar = Convert.ToByte(txtByte.Text);

                lblRevisaBite.Text = "Esta dentro del rango byte";
            }
            catch (Exception)
            {
                MessageBox.Show("Un Byte debe ser menor a 256");

                lblRevisaBite.Text = "No es byte";
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtByte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            string varx = "";

            for (int i = 0; i <= 10; i++)
            {
                varx += i.ToString();

                if (i==9)
                {
                    break;
                }

                varx += "-";
            }

            MessageBox.Show(varx);
        }
    }
}
