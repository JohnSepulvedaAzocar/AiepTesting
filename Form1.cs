using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        double iva, totalfac;
        public Form1()
        {
            InitializeComponent();
            

        }

        public void button2_Click(object sender, EventArgs e)
        {
            int pUnitario, total;
            int cant = 0;
            int suma = 0;

            pUnitario = int.Parse(tbx_pUnitario.Text);
            cant = int.Parse(tbx_cant.Text);
            total = pUnitario * cant;
            MessageBox.Show("Se ha ingresado el articulo: " + tbx_articulo.Text + "\nPor un monto de: " +total.ToString());
            tbx_articulo.Clear();
            tbx_pUnitario.Clear();
            tbx_cant.Clear();
            suma = suma + total;
            tbx_mNeto.Text = suma.ToString();
            iva = suma * 0.19;
            tbx_Iva.Text = iva.ToString();
            totalfac = suma + iva;
            tbx_mTotal.Text = totalfac.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbx_folio.Clear();
            tbx_rut.Clear();
            tbx_dv.Clear();
            tbx_razonSocial.Clear();
            tbx_giro.Clear();
            tbx_direc.Clear();
            tbx_comuna.Clear();
            tbx_ciudad.Clear();
            tbx_mNeto.Clear();
            tbx_Iva.Clear();
            tbx_mTotal.Clear();
            tbx_articulo.Clear();
            tbx_pUnitario.Clear();
            tbx_cant.Clear();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha ingresado la factura con exito"+"\nFolio: " + tbx_folio.Text + "\nPor un monto de: " + totalfac.ToString());
            tbx_folio.Clear();
            tbx_rut.Clear();
            tbx_dv.Clear();
            tbx_razonSocial.Clear();
            tbx_giro.Clear();
            tbx_direc.Clear();
            tbx_comuna.Clear();
            tbx_ciudad.Clear();
            tbx_mNeto.Clear();
            tbx_Iva.Clear();
            tbx_mTotal.Clear();
            textBox1.Clear();
        }
    }
}
