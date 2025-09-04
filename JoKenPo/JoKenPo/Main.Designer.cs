namespace JoKenPo
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo ao JoKenPo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(56, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sua escolha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(227, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escolha da máquina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(480, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Image = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnTesoura.Location = new System.Drawing.Point(442, 271);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(171, 143);
            this.btnTesoura.TabIndex = 12;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Image = global::JoKenPo.Properties.Resources.Papel;
            this.btnPapel.Location = new System.Drawing.Point(227, 271);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(171, 143);
            this.btnPapel.TabIndex = 11;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Image = global::JoKenPo.Properties.Resources.Pedra;
            this.btnPedra.Location = new System.Drawing.Point(26, 271);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(171, 143);
            this.btnPedra.TabIndex = 10;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // picResultado
            // 
            this.picResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picResultado.Location = new System.Drawing.Point(424, 45);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(208, 200);
            this.picResultado.TabIndex = 6;
            this.picResultado.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(218, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoKenPo";
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
    }
}

