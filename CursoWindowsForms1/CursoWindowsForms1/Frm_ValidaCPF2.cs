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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click_1(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click_1(object sender, EventArgs e)
        {
            var conteudo = Msk_CPF.Text;
            conteudo = conteudo.Replace(".", "").Replace("-", "").Trim();

            if (conteudo == "" || conteudo.Length != 11)
            {
                MessageBox.Show("Digite os 11 dígitos do CPF", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var valida = new ValidaCPF();
                var validaCPF = valida.Valida(Msk_CPF.Text);

                if (MessageBox.Show("Você deseja validar o CPF", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (validaCPF == true)
                    {
                        MessageBox.Show("CPF Válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (validaCPF == false)
                    {
                        MessageBox.Show("CPF Inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
