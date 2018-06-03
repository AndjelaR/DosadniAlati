using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosadniAlati
{
    public partial class Komande : Form
    {
        public int komand;

        public Komande()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimumSize = new Size(400, 250);
            this.MaximumSize = new Size(400, 250);
            
        }
        

        private void lblSoba_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            komand =1;
            this.Dispose();
            
        }

        private void lblNamjestaj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            komand = 2;
            this.Dispose();
        }

        private void lblParametri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            komand = 3;
            this.Dispose();
        }

       
    }
}
