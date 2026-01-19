using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pismeni_na_satu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zapis=txtNaslov.Text + "," + txtAutor.Text + "," + godina.Text + "," + cbZanr.Text + "," + brStr.Text + "," + dostupnost.Checked;
            Admin.SaveBook(zapis);
            MessageBox.Show("Knjiga je  spremljena!");
            txtNaslov.Text = "";
            txtAutor.Text = "";
            godina.Text = "";
            cbZanr.Text = "";
            brStr.Text = "";
            dostupnost.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
