using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claas1_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap1=new Kitap();
            kitap1.tür = "Roman";
            kitap1.yazar = "Aslı Arslan";
            kitap1.ciltliCiltsiz = "Citli";
            kitap1.sayfaSayısı = 800;
            kitap1.kitapYılı = 2020;

            label1.Text = kitap1.tür + "\n" + kitap1.yazar + "\n" + kitap1.ciltliCiltsiz + "\n" + kitap1.sayfaSayısı + "\n" + kitap1.kitapYılı;
        }
    }
}
