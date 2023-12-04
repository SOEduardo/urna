using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaJCerto
{
    public partial class FormResultado : Form
    {
        double porcentCarlos, porcentDimitri, porcentGabriel, porcentGustavo;
        FormVotos votos;

        private void FormResultado_Load_1(object sender, EventArgs e)
        {
            Porcentagem();
            lbl_Carlos.Text = string.Format("{0:P2}", porcentCarlos);
            lbl_Dimitri.Text = string.Format("{0:P2}", porcentDimitri);
            lbl_Gabriel.Text = string.Format("{0:P2}", porcentGabriel);
            lbl_Gustavo.Text = string.Format("{0:P2}", porcentGustavo);
        }

        public FormResultado(FormVotos votos)
        {
            InitializeComponent();
            this.votos = votos;
        }

        public void Porcentagem()
        {
            double total = votos.pontosCarlos + votos.pontosDimitri + votos.pontosGabriel + votos.pontosGustavo;
            porcentCarlos = votos.pontosCarlos / total;
            porcentDimitri = votos.pontosDimitri / total;
            porcentGabriel = votos.pontosGabriel / total;
            porcentGustavo = votos.pontosGustavo / total;
        }
    }
}
