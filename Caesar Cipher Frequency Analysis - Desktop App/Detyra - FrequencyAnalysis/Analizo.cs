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
    public partial class Analizo : Form
    {
        public static string ENGLISH_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public int[] _letterCount;
        public Analizo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            for (int i = 0; i < ENGLISH_ALPHABET.Length; i++)
            {
                string s = ENGLISH_ALPHABET[i].ToString();
                chart1.Series["Frequency"].Points.AddXY(s, _letterCount[i]);
            }
        }
    }
}
