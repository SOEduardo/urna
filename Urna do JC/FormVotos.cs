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
            total = pontosCarlos + pontosDimitri + pontosGabriel + pontosGustavo;
            cont = 0;
        }


        //metodo random q n apaguei pra n dar problema
        private void label2_Click(object sender, EventArgs e)
        {

        }

        ///
        /// Metodos para executar as ações de quando clicar no botão
        ///
        
        //Botão CARLOS
        private void btn_Carlos_Click(object sender, EventArgs e)
        {
            btn_Carlos.Enabled = false;
            btn_Carlos.BackColor = Color.Black;
            cont++;
            Fim();
        }
        //Botão Dimitri
        private void btn_Dimitri_Click(object sender, EventArgs e)
        {
            btn_Dimitri.Enabled = false;
            btn_Dimitri.BackColor = Color.Black;
            cont++;
            Fim();
        }
        //Botão Gabriel
        private void btn_Gabriel_Click(object sender, EventArgs e)
        {
            btn_Gabriel.Enabled = false;
            btn_Gabriel.BackColor = Color.Black;
            cont++;
            Fim();
        }
        //Botão Gustavo
        private void btn_Gustavo_Click(object sender, EventArgs e)
        {
            btn_Gustavo.Enabled = false;
            btn_Gustavo.BackColor = Color.Black;
            cont++;
            Fim();
        }

        //Botão que vai basicamente passar o valor dos atributos para o formulario onde o usuário escolhe como ele vai entrar no programa
        private void btn_Prox_Click(object sender, EventArgs e)
        {
            Contabilizador();
            instFormVot.pontosCarlos = this.pontosCarlos;
            instFormVot.pontosDimitri = this.pontosDimitri;
            instFormVot.pontosGabriel = this.pontosGabriel;
            instFormVot.pontosGustavo = this.pontosGustavo;
            instFormVot.total = this.total;
            instFormVot.Show();
            this.Close();
        }

        //Botão que vai levar pro formulário de resultados, chamei o Contabilizador pra atribuir aos atributos deste form os valor 
        private void btn_Result_Click(object sender, EventArgs e)
        {
            Contabilizador();
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

        private void Contabilizador()
        {   
            if(serAluno())
            {
            //VOTOS ALUNOS
                // Votos do CARLOS
                if(btn_Carlos.Enabled == false) { 
                    switch(cont) { 
                        case 1:
                            pontosCarlos += 1 * 0.25;
                            break;
                        case 2:
                            pontosCarlos += 0.5 * 0.25;
                            break;
                        case 3:
                            pontosCarlos += 0.3 * 0.25;
                            break;
                    }
                }

                // Votos do GUSTAVO
                if(btn_Gustavo.Enabled == false)
                {
                    switch(cont) 
                    {
                        case 1:
                            pontosGustavo += 1 * 0.25;
                            break;
                        case 2:
                            pontosGustavo += 0.5 * 0.25;
                            break;
                        case 3:
                            pontosGustavo += 0.3 * 0.25;
                            break;
                    }
                }

                //Votos do Dimitri
                if (btn_Dimitri.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosDimitri += 1 * 0.25;
                            break;
                        case 2:
                            pontosDimitri += 0.5 * 0.25;
                            break;
                        case 3:
                            pontosDimitri += 0.3 * 0.25;
                            break;
                    }
                }
                //Votos do GABRIEL
                if (btn_Gabriel.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosGabriel += 1 * 0.25;
                            break;
                        case 2:
                            pontosGabriel += 0.5 * 0.25;
                            break;
                        case 3:
                            pontosGabriel += 0.3 * 0.25;
                            break;
                    }
                }
            // VOTO FUNCIONARIO
            } else {

                // Votos do CARLOS
                if (btn_Carlos.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosCarlos += 1 * 0.75;
                            break;
                        case 2:
                            pontosCarlos += 0.5 * 0.75;
                            break;
                        case 3:
                            pontosCarlos += 0.3 * 0.75;
                            break;
                    }
                }

                // Votos do GUSTAVO
                if (btn_Gustavo.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosGustavo += 1 * 0.75;
                            break;
                        case 2:
                            pontosGustavo += 0.5 * 0.75;
                            break;
                        case 3:
                            pontosGustavo += 0.3 * 0.75;
                            break;
                    }
                }

                //Votos do Dimitri
                if (btn_Dimitri.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosDimitri += 1 * 0.75;
                            break;
                        case 2:
                            pontosDimitri += 0.5 * 0.75;
                            break;
                        case 3:
                            pontosDimitri += 0.3 * 0.75;
                            break;
                    }
                }
                //Votos do GABRIEL
                if (btn_Gabriel.Enabled == false)
                {
                    switch (cont)
                    {
                        case 1:
                            pontosGabriel += 1 * 0.75;
                            break;
                        case 2:
                            pontosGabriel += 0.5 * 0.75;
                            break;
                        case 3:
                            pontosGabriel += 0.3 * 0.75;
                            break;
                    }
                }

            }
        }
    }
}
