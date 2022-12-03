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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

           
            professor.setNome((textBox1.Text));
            professor.setSobreNome((textBox2.Text));
            professor.setEmail((textBox3.Text));
            professor.setSenha((textBox5.Text));
            professor.setCelular((textBox7.Text));
            professor.setLiguagem((textBox8.Text));
            professor.setEstado(textBox9.Text);
            professor.setCidade((textBox10.Text));
            professor.setEscolaprox((textBox11.Text));
            professor.setId(int.Parse(textBox12.Text));

            ProfessorDAO professordao = new ProfessorDAO();
            if (professordao.cadastar(professor))
            {
                MessageBox.Show("Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Nao Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
