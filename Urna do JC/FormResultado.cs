using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna_do_JC;

namespace Urna_do_JC
{
    public partial class FormResultado : Form
    {
        double porcentCarlos, porcentDimitri, porcentGabriel, porcentGustavo;
        FormVotos votos;
        public FormResultado(FormVotos votos)
        {
            InitializeComponent();
            this.votos = votos;
        }

        public void Porcentagem()
        {
            double total = votos.pontosCarlos + votos.pontosDimitri + votos.pontosGabriel + votos.pontosGustavo;
            porcentCarlos = (100 * votos.pontosCarlos) / total;
            porcentDimitri = (100 * votos.pontosDimitri) / total;
            porcentGabriel = (100 * votos.pontosGabriel) / total;
            porcentGustavo = (100 * votos.pontosGustavo) / total;
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            Porcentagem();
            lbl_Carlos.Text = porcentCarlos+"%";
            lbl_Dimitri.Text = porcentDimitri+"%";
            lbl_Gabriel.Text = porcentGabriel+"%";
            lbl_Gustavo.Text = porcentGustavo+"%";
        }
    }
}
