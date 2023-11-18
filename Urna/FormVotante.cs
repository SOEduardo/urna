using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class FormVotante : Form
    {
        public FormVotante()
        {
            InitializeComponent();
        }

        private void FormVotante_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FormVoto newForm = new FormVoto();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FormVoto newForm = new FormVoto();
            newForm.Show();
            this.Hide();
        }
    }
}
