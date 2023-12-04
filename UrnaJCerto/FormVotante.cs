using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaJCerto
{
    public partial class FormVotante : Form
    {
        public double pontosCarlos, pontosDimitri, pontosGabriel, pontosGustavo, total;

        private void FormVotante_Load(object sender, EventArgs e)
        {
            CriarBotaoArredondado(btn_Aluno); 
            CriarBotaoArredondado(btn_Funcionario);
        }

        private void btn_Funcionario_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            FormVotos newFrm = new FormVotos(this);
            newFrm.Show();
        }

        private void btn_Aluno_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FormVotos newFrm = new FormVotos(this);
            newFrm.Show();
        }

        private void CriarBotaoArredondado(Button btn)
        {
            // Cria uma borda arredondada usando a propriedade GraphicsPath
            GraphicsPath path = new GraphicsPath();
            int radius = 25; // Ajuste o raio conforme necessário

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddLine(radius, 0, btn.Width - radius, 0);
            path.AddArc(btn.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddLine(btn.Width, radius, btn.Width, btn.Height - radius);
            path.AddArc(btn.Width - radius * 2, btn.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(btn.Width - radius, btn.Height, radius, btn.Height);
            path.AddArc(0, btn.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(0, btn.Height - radius, 0, radius);

            btn.Region = new Region(path);


            // Adiciona o botão ao formulário
            this.Controls.Add(btn);
        }

        public FormVotante()
        {
            InitializeComponent();
        }
    }
}
