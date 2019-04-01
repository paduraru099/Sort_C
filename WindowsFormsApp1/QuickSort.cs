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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void QuickSort_Load(object sender, EventArgs e)
        {
            string Dir = Path.GetDirectoryName(Application.ExecutablePath);
            string myfile = Path.Combine(Dir, "Quick-Sort.html");
            webBrowser1.Url = new Uri("file:///" + myfile);
            
        }

       
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Teorie f1 = new Teorie();
            f1.ShowDialog();
        }
    }
}
