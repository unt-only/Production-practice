using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Naem_sot : Form
    {
        public Naem_sot()
        {
            InitializeComponent();
        }

        private void Naem_sot_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://naem-mjko.vercel.app/");
        }
    }
}
