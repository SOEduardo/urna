namespace Urna_do_JC
{
    partial class FormVotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotos));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Carlos = new Button();
            btn_Dimitri = new Button();
            btn_Gabriel = new Button();
            btn_Gustavo = new Button();
            btn_Result = new Button();
            btn_Prox = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 30);
            label1.Name = "label1";
            label1.Size = new Size(342, 32);
            label1.TabIndex = 0;
            label1.Text = "Escolha até 3 candidatos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(589, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(93, 373);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 175);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(589, 373);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 175);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 94);
            label2.Name = "label2";
            label2.Size = new Size(65, 22);
            label2.TabIndex = 5;
            label2.Text = "Carlos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(631, 94);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 6;
            label3.Text = "Dimitri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(130, 346);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 7;
            label4.Text = "Gabriel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(622, 348);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 8;
            label5.Text = "Gustavo";
            // 
            // btn_Carlos
            // 
            btn_Carlos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Carlos.Location = new Point(121, 297);
            btn_Carlos.Name = "btn_Carlos";
            btn_Carlos.Size = new Size(80, 27);
            btn_Carlos.TabIndex = 9;
            btn_Carlos.Text = "Votar";
            btn_Carlos.UseVisualStyleBackColor = true;
            btn_Carlos.Click += btn_Carlos_Click;
            // 
            // btn_Dimitri
            // 
            btn_Dimitri.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Dimitri.Location = new Point(631, 297);
            btn_Dimitri.Name = "btn_Dimitri";
            btn_Dimitri.Size = new Size(80, 27);
            btn_Dimitri.TabIndex = 10;
            btn_Dimitri.Text = "Votar";
            btn_Dimitri.UseVisualStyleBackColor = true;
            btn_Dimitri.Click += btn_Dimitri_Click;
            // 
            // btn_Gabriel
            // 
            btn_Gabriel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Gabriel.Location = new Point(128, 554);
            btn_Gabriel.Name = "btn_Gabriel";
            btn_Gabriel.Size = new Size(80, 27);
            btn_Gabriel.TabIndex = 11;
            btn_Gabriel.Text = "Votar";
            btn_Gabriel.UseVisualStyleBackColor = true;
            btn_Gabriel.Click += btn_Gabriel_Click;
            // 
            // btn_Gustavo
            // 
            btn_Gustavo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Gustavo.Location = new Point(631, 554);
            btn_Gustavo.Name = "btn_Gustavo";
            btn_Gustavo.Size = new Size(80, 27);
            btn_Gustavo.TabIndex = 12;
            btn_Gustavo.Text = "Votar";
            btn_Gustavo.UseVisualStyleBackColor = true;
            btn_Gustavo.Click += btn_Gustavo_Click;
            // 
            // btn_Result
            // 
            btn_Result.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Result.Location = new Point(359, 554);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new Size(101, 27);
            btn_Result.TabIndex = 13;
            btn_Result.Text = "Resultados";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Click += btn_Result_Click;
            // 
            // btn_Prox
            // 
            btn_Prox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Prox.Location = new Point(349, 297);
            btn_Prox.Name = "btn_Prox";
            btn_Prox.Size = new Size(128, 27);
            btn_Prox.TabIndex = 14;
            btn_Prox.Text = "Próximo Voto";
            btn_Prox.UseVisualStyleBackColor = true;
            btn_Prox.Click += btn_Prox_Click;
            // 
            // FormVotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 647);
            Controls.Add(btn_Prox);
            Controls.Add(btn_Result);
            Controls.Add(btn_Gustavo);
            Controls.Add(btn_Gabriel);
            Controls.Add(btn_Dimitri);
            Controls.Add(btn_Carlos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormVotos";
            Text = "FormVotos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Carlos;
        private Button btn_Dimitri;
        private Button btn_Gabriel;
        private Button btn_Gustavo;
        private Button btn_Result;
        private Button btn_Prox;
    }
}