using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" &&  textBox2.Text == "admin")
            {
                Form2 form2 = new Form2 ();
                this.Hide();
                form2 . ShowDialog ();
            }

            else
            {
                MessageBox.Show(" Login ou Senha Inválidos ! ");
            }
        }
    }
}
