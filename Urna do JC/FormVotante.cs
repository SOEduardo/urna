using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_do_JC
{
    public partial class FormVotante : Form
    {
        public double pontosCarlos, pontosDimitri, pontosGabriel, pontosGustavo, total;
        public FormVotante()
        {
            InitializeComponent();
        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FormVotos newFrm = new FormVotos(this);
            newFrm.Show();
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FormVotos newFrm = new FormVotos(this);
            newFrm.Show();
        }
    }
}
