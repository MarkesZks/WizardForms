using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardForms.Professor
{
    public partial class ExcluirProfessor : Form
    {
        public ExcluirProfessor()
        {
            InitializeComponent();
        }

        private void ExcluirProfessor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor= new Professor();
            professor.setId(int.Parse(textBox1.Text));


            ProfessorDAO professorDAO = new ProfessorDAO();

            if (professorDAO.excluir(professor))
            {
                MessageBox.Show("Apagado sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Nao excluido!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
