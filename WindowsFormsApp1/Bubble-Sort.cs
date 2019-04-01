using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Bubble_Sort : Form
    {
        public Bubble_Sort()
        {
            InitializeComponent();
        }

        private void Bubble_Sort_Load(object sender, EventArgs e)
        {
            string Dir = Path.GetDirectoryName(Application.ExecutablePath);
            string myfile = Path.Combine(Dir, "Bubble-Sort.html");
            webBrowser1.Url = new Uri("file:///" + myfile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teorie f1 = new Teorie();
            f1.ShowDialog();
        }
    }
}
