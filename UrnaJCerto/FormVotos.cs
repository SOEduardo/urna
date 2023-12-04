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
    public partial class FormVotos : Form
    {
        /// 
        /// Formulário onde o usuário realizará o voto, iniciaremos criando todos os atributos desse Form
        /// 
        public double pontosCarlos, pontosDimitri, pontosGabriel, pontosGustavo, total;
        int cont;
        FormVotante instFormVot;

        // Construtor para a inicializando de todos os atributos, estou puxando do outro form para não perder o valor da ultima "votação"
        public FormVotos(FormVotante frmVotante)
        {
            InitializeComponent();
            instFormVot = frmVotante;
            this.pontosGustavo = frmVotante.pontosGustavo;
            this.pontosGabriel = frmVotante.pontosGabriel;
            this.pontosDimitri = frmVotante.pontosDimitri;
            this.pontosCarlos = frmVotante.pontosCarlos;
            this.total = pontosCarlos + pontosDimitri + pontosGabriel + pontosGustavo;
            cont = 0;
        }

        private void FormVotos_Load(object sender, EventArgs e)
        {
            labelText.Parent = gradientPanel1;
            labelBiel.Parent = gradientPanel1;
            labelCarlos.Parent = gradientPanel1;
            labelGustavo.Parent = gradientPanel1;   
            labelDimitri.Parent = gradientPanel1;
        }

        private void btn_Carlos_Click_1(object sender, EventArgs e)
        {
            btn_Carlos.Enabled = false;
            btn_Carlos.BackColor = Color.Black;
            cont++;
            Fim();
        }
        //Botão que vai basicamente passar o valor dos atributos para o formulario onde o usuário escolhe como ele vai entrar no programa


        private void btn_Prox_Click_1(object sender, EventArgs e)
        {
            pontosCarlos += Contabilizador(btn_Carlos, pontosCarlos);
            pontosDimitri += Contabilizador(btn_Dimitri, pontosDimitri);
            pontosGabriel += Contabilizador(btn_Gabriel, pontosGabriel);
            pontosGustavo += Contabilizador(btn_Gustavo, pontosGustavo);
            instFormVot.pontosCarlos = this.pontosCarlos;
            instFormVot.pontosDimitri = this.pontosDimitri;
            instFormVot.pontosGabriel = this.pontosGabriel;
            instFormVot.pontosGustavo = this.pontosGustavo;
            instFormVot.total = this.total;
            instFormVot.Show();
            this.Close();
        }

        private void btn_Gabriel_Click(object sender, EventArgs e)
        {
            btn_Gabriel.Enabled = false;
            btn_Gabriel.BackColor = Color.Black;
            cont++;
            Fim();
        }

        private void btn_Gustavo_Click(object sender, EventArgs e)
        {
            btn_Gustavo.Enabled = false;
            btn_Gustavo.BackColor = Color.Black;
            cont++;
            Fim();
        }

        private void btn_Dimitri_Click(object sender, EventArgs e)
        {
            btn_Dimitri.Enabled = false;
            btn_Dimitri.BackColor = Color.Black;
            cont++;
            Fim();
        }


        //Botão que vai levar pro formulário de resultados, chamei o Contabilizador pra atribuir aos atributos deste form os valor 
        private void btn_Result_Click_1(object sender, EventArgs e)
        {
            pontosCarlos += Contabilizador(btn_Carlos, pontosCarlos);
            pontosDimitri += Contabilizador(btn_Dimitri, pontosDimitri);
            pontosGabriel += Contabilizador(btn_Gabriel, pontosGabriel);
            pontosGustavo += Contabilizador(btn_Gustavo, pontosGustavo);
            FormResultado frmNew = new FormResultado(this);
            frmNew.Show();
        }

        /// <summary>
        /// Criação de metodos para auxiliar em verificações
        /// </summary>

        //metodo pra facilitar a leitura do codigo sabendo se é ou não aluno em certas verificãções
        public Boolean serAluno()
        {
            if (DialogResult == DialogResult.OK)
            {
                return true;
            }
            else { return false; }

        }
        //metodo pra saber quando inibir o usuário de votar
        public void Fim()
        {
            if (cont == 3)
            {
                btn_Gabriel.Visible = false;
                btn_Dimitri.Visible = false;
                btn_Gustavo.Visible = false;
                btn_Carlos.Visible = false;
            }
        }

        private double Contabilizador(Button btn, double pont)
        {
            if (serAluno())
            {
                if (btn.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pont += 1 * 0.25;
                            break;
                        case 2:
                            pont += 0.5 * 0.25;
                            break;
                        case 3:
                            pont += 0.3 * 0.25;
                            break;
                    }
                }
            }
            else
            {
                if (btn.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pont += 1 * 0.75;
                            break;
                        case 2:
                            pont += 0.5 * 0.75;
                            break;
                        case 3:
                            pont += 0.3 * 0.75;
                            break;
                    }
                }
            }
            return pont;
        }
    }
}