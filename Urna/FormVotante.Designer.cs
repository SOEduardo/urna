﻿namespace Urna
{
    partial class FormVotante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o cargo em que você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "se encontra na instituição";
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aluno.Location = new System.Drawing.Point(233, 159);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(390, 58);
            this.btn_Aluno.TabIndex = 2;
            this.btn_Aluno.Text = "Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = true;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Funcionário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVotante";
            this.Text = "FormVotante";
            this.Load += new System.EventHandler(this.FormVotante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aluno;
        private System.Windows.Forms.Button button2;
    }
}