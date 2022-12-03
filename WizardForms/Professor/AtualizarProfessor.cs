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
    public partial class AtualizarProfessor : Form
    {
        public AtualizarProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.setId(int.Parse(textBox12.Text));
            professor.setNome((textBox1.Text));
            professor.setSobreNome((textBox2.Text));
            professor.setEmail((textBox3.Text));
            professor.setSenha((textBox5.Text));
            professor.setCelular((textBox7.Text));
            professor.setLiguagem((textBox8.Text));
            professor.setEstado(textBox9.Text);
            professor.setCidade((textBox10.Text));
            professor.setEscolaprox((textBox11.Text));

            ProfessorDAO professordao = new ProfessorDAO();
            if (professordao.cadastar(professor))
            {
                MessageBox.Show("Atualizado!", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Nao Atualizado!", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
