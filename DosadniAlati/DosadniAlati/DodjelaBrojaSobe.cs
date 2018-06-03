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
    public partial class DodjelaBrojaSobe : Form
    {
        public int brojSobe;
        public Boolean auto = false;
        public Boolean unos = false;
        public DodjelaBrojaSobe()
        {
            InitializeComponent();
            this.MinimumSize =new Size(300, 190);
            this.MaximumSize = new Size(300, 190);
            this.CenterToScreen();
        }

        private void tbBrojSobe_TextChanged(object sender, EventArgs e)
        {
            brojSobe =Convert.ToInt32(tbBrojSobe.Text);
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            auto = true;
            this.Dispose();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            unos = true;
            this.Dispose();
          
        }

        private void DodjelaBrojaSobe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
