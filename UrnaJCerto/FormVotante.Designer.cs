using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UrnaJCerto
{
    partial class FormVotante
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.btn_Funcionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o cargo em que você se encontra na instituição:";
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aluno.FlatAppearance.BorderSize = 0;
            this.btn_Aluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aluno.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btn_Aluno.ForeColor = System.Drawing.Color.Black;
            this.btn_Aluno.Location = new System.Drawing.Point(250, 207);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(344, 52);
            this.btn_Aluno.TabIndex = 1;
            this.btn_Aluno.Text = "Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = false;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click_1);
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Funcionario.FlatAppearance.BorderSize = 0;
            this.btn_Funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Funcionario.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btn_Funcionario.ForeColor = System.Drawing.Color.Black;
            this.btn_Funcionario.Location = new System.Drawing.Point(250, 374);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.Size = new System.Drawing.Size(344, 52);
            this.btn_Funcionario.TabIndex = 2;
            this.btn_Funcionario.Text = "Funcionário";
            this.btn_Funcionario.UseVisualStyleBackColor = false;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click_1);
            // 
            // FormVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(863, 561);
            this.Controls.Add(this.btn_Funcionario);
            this.Controls.Add(this.btn_Aluno);
            this.Controls.Add(this.label1);
            this.Name = "FormVotante";
            this.Text = "FormVotante";
            this.Load += new System.EventHandler(this.FormVotante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Aluno;
        private Button btn_Funcionario;
    }
}