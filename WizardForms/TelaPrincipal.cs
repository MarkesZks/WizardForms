using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardForms.Aluno;
using WizardForms.Professor;

namespace WizardForms
{
    public partial class TelaPrincipal : Form
    {
        // Instanciando as telas de Aluno
        // ApagarAluno alunoApagar = new ApagarAluno();
        // AtualizarAluno alunoAtualizar = new AtualizarAluno();
        CadastroAluno alunoCadastro = new CadastroAluno();
        // ConsultarAluno alunoConsultar = new ConsultarAluno();
        
        // Instanciando as telas de Professor
       // ApagarProfessor professorApagar = new ApagarProfessor();
       // AtualizarProfessor professorAtualizar = new AtualizarProfessor();
       // CadastroProfessor professorCadastro = new CadastroProfessor();
       // ConsultarProfessor professorConsultar = new ConsultarProfessor();



        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tristeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
            this.Hide();
  
        }

        private void calvoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
             // alunoAtualizar.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            // alunoConsultar.Show();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           // alunoApagar.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroProfessor cadastroprofessor = new CadastroProfessor();
            this.Hide();
            cadastroprofessor.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // professorConsultar.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // professorAtualizar.Show();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // professorApagar.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes){ this.Close(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
