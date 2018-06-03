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
    public partial class PrikazParametara : Form
    {
        int  brojParametara;
      public  List<CheckBox> cb_list = new List<CheckBox>();
      public  List<TextBox> tb_list = new List<TextBox>();
      public  List<Button> btn_list = new List<Button>();
      private  CheckBox cb;
      private  TextBox tb;
      private  Button btnOK;
      public string promjena;
      public  int indexPromijenjenogPolja;
      public string nazivPromijenjenogParametra;


        public PrikazParametara(int brojParametara, List<string> listaParametaraIme, List<string> listaParametaraVrijednost)
        {
            InitializeComponent();
            this.Size = new Size(500, brojParametara * 30 + 50);
            for( int i = 0; i < brojParametara; i++)
            {
                this.brojParametara = brojParametara;

                cb = new CheckBox();
                cb.Visible = true;
                cb.Checked = false;
                cb.Name = i.ToString();
                cb.Size = new Size(200, 20);
                cb.Location = new Point(10, i * 22);
                cb.Text = listaParametaraIme[i];
                cb.Click += cb_click;
                cb.Click += cb_unclick;
                Controls.Add(cb);

                tb = new TextBox();
                tb.Name = i.ToString();
                tb.Visible = false;
                tb.Size = new Size(100, 20);
                tb.Location = new Point(230, i * 22);
                tb.Text = listaParametaraVrijednost[i];
                Controls.Add(tb);

                btnOK = new Button();
                btnOK.Name = i.ToString();
                btnOK.Visible = false;
                btnOK.Size = new Size(30, 20);
                btnOK.Location = new Point(350, i * 22);
                btnOK.Text = "OK";
                btnOK.Click += btn_click;
                Controls.Add(btnOK);

                cb_list.Insert(i, cb);
                tb_list.Insert(i, tb);
                btn_list.Insert(i, btnOK);

                
            }
        }
        public void cb_click(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox; 
            if (cb.Checked == true)
            {
                int i = Convert.ToInt16(cb.Name);
                TextBox tb = tb_list[i];
                tb.Visible = true;

                Button btn = btn_list[i];
                btn.Visible = true;
            }
            else if (cb.Checked== false)
            {
                tb.Hide();
                btnOK.Hide();
            }
        }
        public void cb_unclick(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == false)
            {
                int i = Convert.ToInt16(cb.Name);
                TextBox tb = tb_list[i];
                tb.Visible = false;

                Button btn = btn_list[i];
                btn.Visible =false;
            }
        }
        public void btn_click( object sender, EventArgs e)//ne radi logicno
        {
            Button btn = sender as Button;
            string ime = btn.Name;
            for(int j = 0; j < brojParametara; j++)
            {
                if( tb.Name == ime)
                {
                    promjena = tb_list[j].Text;
                    indexPromijenjenogPolja = j;
                    nazivPromijenjenogParametra = cb_list[j].Text;
                }
            }

        }


    }
}
