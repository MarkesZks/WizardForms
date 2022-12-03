﻿using System;
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
    public partial class ConsultarProfessor : Form
    {
        public ConsultarProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorDAO professorDAO = new ProfessorDAO();
            dataGridView1.DataSource = professorDAO.consultar();
        }
    }
}
