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
    public partial class Frm_ValidaSenha : Form
    {
        bool VerSenhaTxt = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = string.Empty;
            Txt_Senha.Text = string.Empty;
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            var verifica = new ChecaForcaSenha();
            var forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" || Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }

        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Ocultar Senha";
                VerSenhaTxt = true;
            }

            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver Senha";
                VerSenhaTxt = false;
            }
            
        }

    }
}
