using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace INSS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        inss ci = new inss();
        private void button1_Click(object sender, EventArgs e)
        {
            ci.salario = Convert.ToDouble(txtsalario.Text);
            ci.horasextras = Convert.ToDouble(txthorasextras.Text);
            ci.Calcularsalbruto();
            ci.Calcularinss();
            txtsalariobruto.Text = ci.salariobruto.ToString();
            txtdesconto.Text = ci.dsctoinss.ToString();
            txtsalarioliquido.Text = ci.salarioliquido.ToString();
            txtfuncio.Text = txtfuncionario.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfuncionario.Text = "";
            txtsalario.Text = "";
            txthorasextras.Text = "";
            txtfuncio.Text = "";
            txtsalariobruto.Text = "";
            txtdesconto.Text = "";
            txtsalarioliquido.Text = "";
        }
    }
}
