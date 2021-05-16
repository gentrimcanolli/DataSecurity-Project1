using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detyra___FrequencyAnalysis
{
    public partial class EncryptDialog : Form
    {
        public int celesi = 0;
        public EncryptDialog()
        {
            InitializeComponent();
        }

        private void btnDergo_Click(object sender, EventArgs e)
        {
            try
            {
                celesi = Int32.Parse(txtCelesi.Text);
                if (celesi < 0)
                {
                    MessageBox.Show("Please enter a positive integer!");
                }
                else
                {
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a positive integer!");
            }
        }
    }
}
