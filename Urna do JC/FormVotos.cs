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
    public partial class FormVotos : Form
    {
        public double pontosCarlos, pontosDimitri, pontosGabriel, pontosGustavo, total;
        int cont;
        FormVotante instFormVot;

        public FormVotos(FormVotante frmVotante)
        {
            InitializeComponent();
            instFormVot = frmVotante;
            this.pontosGustavo = frmVotante.pontosGustavo;
            this.pontosGabriel = frmVotante.pontosGabriel;
            this.pontosDimitri = frmVotante.pontosDimitri;
            this.pontosCarlos = frmVotante.pontosCarlos;
            total += pontosCarlos + pontosDimitri + pontosGabriel + pontosGustavo;
            cont = 0;
        }

        public Boolean serAluno()
        {
            if (DialogResult == DialogResult.OK)
            {
                return true;
            }
            else { return false; }

        }

        public void Fim()
        {
            if (cont > 2)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Carlos_Click(object sender, EventArgs e)
        {
            if (serAluno())
            {
                if (cont == 1)
                {
                    pontosCarlos = 0.5 * 0.25;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosCarlos = 0.3 * 0.25;
                    cont++;
                }
                else
                {
                    pontosCarlos = 1 * 0.25;
                    cont++;
                }
            }
            else
            {
                if (cont == 1)
                {
                    pontosCarlos = 0.5 * 0.75;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosCarlos = 0.3 * 0.75;
                    cont++;
                }
                else
                {
                    pontosCarlos = 1 * 0.75;
                    cont++;
                }
            }
            btn_Carlos.Enabled = false;
            btn_Carlos.BackColor = Color.Black;
            Fim();
        }

        private void btn_Dimitri_Click(object sender, EventArgs e)
        {
            if (serAluno())
            {
                if (cont == 1)
                {
                    pontosDimitri = 0.5 * 0.25;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosDimitri = 0.3 * 0.25;
                    cont++;
                }
                else
                {
                    pontosDimitri = 1 * 0.25;
                    cont++;
                }
            }
            else
            {
                if (cont == 1)
                {
                    pontosDimitri = 0.5 * 0.75;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosDimitri = 0.3 * 0.75;
                    cont++;
                }
                else
                {
                    pontosDimitri = 1 * 0.75;
                    cont++;
                }
            }
            btn_Dimitri.Enabled = false;
            btn_Dimitri.BackColor = Color.Black;
            Fim();
        }

        private void btn_Gabriel_Click(object sender, EventArgs e)
        {
            if (serAluno())
            {
                if (cont == 1)
                {
                    pontosGabriel = 0.5 * 0.25;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosGabriel = 0.3 * 0.25;
                    cont++;
                }
                else
                {
                    pontosGabriel = 1 * 0.25;
                    cont++;
                }
            }
            else
            {
                if (cont == 1)
                {
                    pontosGabriel = 0.5 * 0.75;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosGabriel = 0.3 * 0.75;
                    cont++;
                }
                else
                {
                    pontosGabriel = 1 * 0.75;
                    cont++;
                }
            }
            btn_Gabriel.Enabled = false;
            btn_Gabriel.BackColor = Color.Black;
            Fim();
        }

        private void btn_Gustavo_Click(object sender, EventArgs e)
        {
            if (serAluno())
            {
                if (cont == 1)
                {
                    pontosGustavo = 0.5 * 0.25;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosGustavo = 0.3 * 0.25;
                    cont++;
                }
                else
                {
                    pontosGustavo = 1 * 0.25;
                    cont++;
                }
            }
            else
            {
                if (cont == 1)
                {
                    pontosGustavo = 0.5 * 0.75;
                    cont++;
                }
                else if (cont == 2)
                {
                    pontosGustavo = 0.3 * 0.75;
                    cont++;
                }
                else
                {
                    pontosGustavo = 1 * 0.75;
                    cont++;
                }
            }
            btn_Gustavo.Enabled = false;
            btn_Gustavo.BackColor = Color.Black;
            Fim();
        }

        private void btn_Prox_Click(object sender, EventArgs e)
        {
            instFormVot.pontosCarlos = this.pontosCarlos;
            instFormVot.pontosDimitri = this.pontosDimitri;
            instFormVot.pontosGabriel = this.pontosGabriel;
            instFormVot.pontosGustavo = this.pontosGustavo;
            instFormVot.total = this.total;
            instFormVot.Show();
            this.Close();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            FormResultado frmNew = new FormResultado(this);
            frmNew.Show();
        }
    }
}
