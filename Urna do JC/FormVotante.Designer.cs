namespace Urna_do_JC
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
            label1 = new Label();
            btn_Aluno = new Button();
            btn_Funcionario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 50);
            label1.Name = "label1";
            label1.Size = new Size(749, 32);
            label1.TabIndex = 0;
            label1.Text = "Informe o cargo em que você se encontra na instituição";
            // 
            // btn_Aluno
            // 
            btn_Aluno.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Aluno.Location = new Point(207, 196);
            btn_Aluno.Name = "btn_Aluno";
            btn_Aluno.Size = new Size(401, 51);
            btn_Aluno.TabIndex = 1;
            btn_Aluno.Text = "Aluno";
            btn_Aluno.UseVisualStyleBackColor = true;
            btn_Aluno.Click += btn_Aluno_Click;
            // 
            // btn_Funcionario
            // 
            btn_Funcionario.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Funcionario.Location = new Point(207, 354);
            btn_Funcionario.Name = "btn_Funcionario";
            btn_Funcionario.Size = new Size(401, 51);
            btn_Funcionario.TabIndex = 2;
            btn_Funcionario.Text = "Funcionário";
            btn_Funcionario.UseVisualStyleBackColor = true;
            btn_Funcionario.Click += btn_Funcionario_Click;
            // 
            // FormVotante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(843, 547);
            Controls.Add(btn_Funcionario);
            Controls.Add(btn_Aluno);
            Controls.Add(label1);
            Name = "FormVotante";
            Text = "FormVotante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Aluno;
        private Button btn_Funcionario;
    }
}