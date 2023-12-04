using System.Drawing;
using System.Windows.Forms;

namespace UrnaJCerto
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Carlos = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Prox = new System.Windows.Forms.Button();
            this.btn_Dimitri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Gabriel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Gustavo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha até 3 candidatos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carlos";
            // 
            // btn_Carlos
            // 
            this.btn_Carlos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Carlos.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Carlos.FlatAppearance.BorderSize = 0;
            this.btn_Carlos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Carlos.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Carlos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Carlos.Location = new System.Drawing.Point(158, 253);
            this.btn_Carlos.Name = "btn_Carlos";
            this.btn_Carlos.Size = new System.Drawing.Size(72, 27);
            this.btn_Carlos.TabIndex = 9;
            this.btn_Carlos.Text = "Votar";
            this.btn_Carlos.UseVisualStyleBackColor = false;
            this.btn_Carlos.Click += new System.EventHandler(this.btn_Carlos_Click_1);
            // 
            // btn_Result
            // 
            this.btn_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Result.FlatAppearance.BorderSize = 0;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Result.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Result.Location = new System.Drawing.Point(386, 480);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(87, 30);
            this.btn_Result.TabIndex = 13;
            this.btn_Result.Text = "Resultados";
            this.btn_Result.UseVisualStyleBackColor = false;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click_1);
            // 
            // btn_Prox
            // 
            this.btn_Prox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Prox.FlatAppearance.BorderSize = 0;
            this.btn_Prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prox.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Prox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Prox.Location = new System.Drawing.Point(377, 257);
            this.btn_Prox.Name = "btn_Prox";
            this.btn_Prox.Size = new System.Drawing.Size(110, 30);
            this.btn_Prox.TabIndex = 14;
            this.btn_Prox.Text = "Próximo Voto";
            this.btn_Prox.UseVisualStyleBackColor = false;
            this.btn_Prox.Click += new System.EventHandler(this.btn_Prox_Click_1);
            // 
            // btn_Dimitri
            // 
            this.btn_Dimitri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Dimitri.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Dimitri.FlatAppearance.BorderSize = 0;
            this.btn_Dimitri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dimitri.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Dimitri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Dimitri.Location = new System.Drawing.Point(630, 253);
            this.btn_Dimitri.Name = "btn_Dimitri";
            this.btn_Dimitri.Size = new System.Drawing.Size(72, 27);
            this.btn_Dimitri.TabIndex = 17;
            this.btn_Dimitri.Text = "Votar";
            this.btn_Dimitri.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dimitri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(602, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Gabriel
            // 
            this.btn_Gabriel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Gabriel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Gabriel.FlatAppearance.BorderSize = 0;
            this.btn_Gabriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gabriel.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Gabriel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Gabriel.Location = new System.Drawing.Point(158, 484);
            this.btn_Gabriel.Name = "btn_Gabriel";
            this.btn_Gabriel.Size = new System.Drawing.Size(72, 27);
            this.btn_Gabriel.TabIndex = 20;
            this.btn_Gabriel.Text = "Votar";
            this.btn_Gabriel.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gabriel";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(130, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Gustavo
            // 
            this.btn_Gustavo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(120)))), ((int)(((byte)(244)))));
            this.btn_Gustavo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Gustavo.FlatAppearance.BorderSize = 0;
            this.btn_Gustavo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gustavo.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Gustavo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Gustavo.Location = new System.Drawing.Point(630, 484);
            this.btn_Gustavo.Name = "btn_Gustavo";
            this.btn_Gustavo.Size = new System.Drawing.Size(72, 27);
            this.btn_Gustavo.TabIndex = 23;
            this.btn_Gustavo.Text = "Votar";
            this.btn_Gustavo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gustavo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(602, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 146);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // FormVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(863, 561);
            this.Controls.Add(this.btn_Gustavo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Gabriel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Dimitri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Prox);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Carlos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormVotos";
            this.Text = "FormVotos";
            this.Load += new System.EventHandler(this.FormVotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btn_Carlos;
        private Button btn_Result;
        private Button btn_Prox;
        private Button btn_Dimitri;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btn_Gabriel;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btn_Gustavo;
        private Label label5;
        private PictureBox pictureBox4;
    }
}