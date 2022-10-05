using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

       

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w pierwszym programie forms");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelloName_Click(object sender, EventArgs e)
        {
            string message = "witaj "+ textBoxName.Text + "w tym programie";
            MessageBox.Show(message);
        }
    }
}
