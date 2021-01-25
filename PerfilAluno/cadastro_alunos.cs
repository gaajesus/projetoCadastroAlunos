using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfilAluno
{
	public partial class cadastro_alunos : Form
	{
		public cadastro_alunos()
		{
			InitializeComponent();
		}

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string mensagem = "olá, eu sou ";
            if(rdbMasc.Checked)
            {
                mensagem += "o ";
            }
            else
            {
                mensagem += "a ";
            }
            mensagem += txtNome.Text;
            mensagem += ", eu sou da turma " + cmbTurma.Text;
            if(chkTrab.Checked)
            {
                mensagem += ", atualmente estou trabalhando";
            }
            if(chkEsp.Checked)
            {
                mensagem += " e curso espanhol";
            }
            //mensagem += " e curso " + gpbCurso;
            MessageBox.Show(mensagem,
                        "Perfil do Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);//+ concatena o nome com o texto definido
            
        }

     
        private void cadastro_alunos_Load(object sender, EventArgs e)
        {
            cmbTurma.SelectedIndex = 0;//todo array é começado em 0
        }

        private void cmbTurma_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTurma.Text.Substring(0, 1) == "5")
            {
                rdbEletro.Checked = true;
            }
            else if (cmbTurma.Text.Substring(0, 1) == "7")
            {
                rdbInfo.Checked = true;
            }
            else if (cmbTurma.Text.Substring(0, 1) == "1")
            {
                rdbMec.Checked = true;
            }
            else
            {
                rdbMedio.Checked = true;
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            string sobrenome;
            if(txtNome.Text !="")
            {
                sobrenome = txtNome.Text.Substring(5, 8);
                MessageBox.Show(sobrenome);
            }
        }
    }
}
