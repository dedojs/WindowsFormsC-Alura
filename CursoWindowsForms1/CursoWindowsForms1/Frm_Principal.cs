using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms1
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        
        private void Btn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            var frm = new Frm_DemonstracaoKey();
            frm.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            var frm = new Frm_HelloWorld();
            frm.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            var frm = new Frm_Mascara();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ValidaCPF();
            frm.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ValidaCPF2();
            frm.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            var frm = new Frm_ValidaSenha();
            frm.ShowDialog();
        }
    }
}
