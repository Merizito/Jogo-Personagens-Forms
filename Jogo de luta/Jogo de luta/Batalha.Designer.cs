namespace Jogo_de_luta
{
    partial class Batalha
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
            this.ImagemPlayer1 = new System.Windows.Forms.PictureBox();
            this.ImagemPlayer2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.player1Atk = new System.Windows.Forms.Button();
            this.player1Def = new System.Windows.Forms.Button();
            this.player2Def = new System.Windows.Forms.Button();
            this.player2Atk = new System.Windows.Forms.Button();
            this.HP1 = new System.Windows.Forms.ProgressBar();
            this.ATK1 = new System.Windows.Forms.ProgressBar();
            this.DEF1 = new System.Windows.Forms.ProgressBar();
            this.DEF2 = new System.Windows.Forms.ProgressBar();
            this.ATK2 = new System.Windows.Forms.ProgressBar();
            this.HP2 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textHP1 = new System.Windows.Forms.TextBox();
            this.textATK1 = new System.Windows.Forms.TextBox();
            this.textDEF1 = new System.Windows.Forms.TextBox();
            this.textHP2 = new System.Windows.Forms.TextBox();
            this.textATK2 = new System.Windows.Forms.TextBox();
            this.textDEF2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.botaoRecomeçar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemPlayer1
            // 
            this.ImagemPlayer1.Location = new System.Drawing.Point(42, 49);
            this.ImagemPlayer1.Name = "ImagemPlayer1";
            this.ImagemPlayer1.Size = new System.Drawing.Size(235, 205);
            this.ImagemPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemPlayer1.TabIndex = 0;
            this.ImagemPlayer1.TabStop = false;
            // 
            // ImagemPlayer2
            // 
            this.ImagemPlayer2.Location = new System.Drawing.Point(637, 49);
            this.ImagemPlayer2.Name = "ImagemPlayer2";
            this.ImagemPlayer2.Size = new System.Drawing.Size(235, 205);
            this.ImagemPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemPlayer2.TabIndex = 1;
            this.ImagemPlayer2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ATK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ATK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DEF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DEF";
            // 
            // player1Atk
            // 
            this.player1Atk.Location = new System.Drawing.Point(42, 422);
            this.player1Atk.Name = "player1Atk";
            this.player1Atk.Size = new System.Drawing.Size(75, 23);
            this.player1Atk.TabIndex = 14;
            this.player1Atk.Text = "ATACAR";
            this.player1Atk.UseVisualStyleBackColor = true;
            this.player1Atk.Click += new System.EventHandler(this.player1Atk_Click);
            // 
            // player1Def
            // 
            this.player1Def.Location = new System.Drawing.Point(133, 422);
            this.player1Def.Name = "player1Def";
            this.player1Def.Size = new System.Drawing.Size(75, 23);
            this.player1Def.TabIndex = 15;
            this.player1Def.Text = "DEFENDER";
            this.player1Def.UseVisualStyleBackColor = true;
            this.player1Def.Click += new System.EventHandler(this.player1Def_Click);
            // 
            // player2Def
            // 
            this.player2Def.Location = new System.Drawing.Point(737, 422);
            this.player2Def.Name = "player2Def";
            this.player2Def.Size = new System.Drawing.Size(75, 23);
            this.player2Def.TabIndex = 17;
            this.player2Def.Text = "DEFENDER";
            this.player2Def.UseVisualStyleBackColor = true;
            this.player2Def.Click += new System.EventHandler(this.player2Def_Click);
            // 
            // player2Atk
            // 
            this.player2Atk.Location = new System.Drawing.Point(646, 422);
            this.player2Atk.Name = "player2Atk";
            this.player2Atk.Size = new System.Drawing.Size(75, 23);
            this.player2Atk.TabIndex = 16;
            this.player2Atk.Text = "ATACAR";
            this.player2Atk.UseVisualStyleBackColor = true;
            this.player2Atk.Click += new System.EventHandler(this.player2Atk_Click);
            // 
            // HP1
            // 
            this.HP1.Location = new System.Drawing.Point(94, 284);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(100, 23);
            this.HP1.TabIndex = 18;
            this.HP1.Click += new System.EventHandler(this.HP1_Click);
            // 
            // ATK1
            // 
            this.ATK1.Location = new System.Drawing.Point(94, 326);
            this.ATK1.Name = "ATK1";
            this.ATK1.Size = new System.Drawing.Size(100, 23);
            this.ATK1.TabIndex = 19;
            // 
            // DEF1
            // 
            this.DEF1.Location = new System.Drawing.Point(94, 366);
            this.DEF1.Name = "DEF1";
            this.DEF1.Size = new System.Drawing.Size(100, 23);
            this.DEF1.TabIndex = 20;
            // 
            // DEF2
            // 
            this.DEF2.Location = new System.Drawing.Point(692, 366);
            this.DEF2.Name = "DEF2";
            this.DEF2.Size = new System.Drawing.Size(100, 23);
            this.DEF2.TabIndex = 23;
            // 
            // ATK2
            // 
            this.ATK2.Location = new System.Drawing.Point(692, 326);
            this.ATK2.Name = "ATK2";
            this.ATK2.Size = new System.Drawing.Size(100, 23);
            this.ATK2.TabIndex = 22;
            // 
            // HP2
            // 
            this.HP2.Location = new System.Drawing.Point(692, 284);
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(100, 23);
            this.HP2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(692, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textHP1
            // 
            this.textHP1.Location = new System.Drawing.Point(213, 284);
            this.textHP1.Name = "textHP1";
            this.textHP1.ReadOnly = true;
            this.textHP1.Size = new System.Drawing.Size(41, 20);
            this.textHP1.TabIndex = 26;
            this.textHP1.TextChanged += new System.EventHandler(this.textHP1_TextChanged);
            // 
            // textATK1
            // 
            this.textATK1.Location = new System.Drawing.Point(213, 329);
            this.textATK1.Name = "textATK1";
            this.textATK1.ReadOnly = true;
            this.textATK1.Size = new System.Drawing.Size(41, 20);
            this.textATK1.TabIndex = 27;
            // 
            // textDEF1
            // 
            this.textDEF1.Location = new System.Drawing.Point(213, 369);
            this.textDEF1.Name = "textDEF1";
            this.textDEF1.ReadOnly = true;
            this.textDEF1.Size = new System.Drawing.Size(41, 20);
            this.textDEF1.TabIndex = 28;
            // 
            // textHP2
            // 
            this.textHP2.Location = new System.Drawing.Point(813, 284);
            this.textHP2.Name = "textHP2";
            this.textHP2.ReadOnly = true;
            this.textHP2.Size = new System.Drawing.Size(41, 20);
            this.textHP2.TabIndex = 31;
            // 
            // textATK2
            // 
            this.textATK2.Location = new System.Drawing.Point(813, 326);
            this.textATK2.Name = "textATK2";
            this.textATK2.ReadOnly = true;
            this.textATK2.Size = new System.Drawing.Size(41, 20);
            this.textATK2.TabIndex = 30;
            // 
            // textDEF2
            // 
            this.textDEF2.Location = new System.Drawing.Point(813, 366);
            this.textDEF2.Name = "textDEF2";
            this.textDEF2.ReadOnly = true;
            this.textDEF2.Size = new System.Drawing.Size(41, 20);
            this.textDEF2.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 30);
            this.button5.TabIndex = 32;
            this.button5.Text = "SAIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // botaoRecomeçar
            // 
            this.botaoRecomeçar.Location = new System.Drawing.Point(306, 529);
            this.botaoRecomeçar.Name = "botaoRecomeçar";
            this.botaoRecomeçar.Size = new System.Drawing.Size(90, 30);
            this.botaoRecomeçar.TabIndex = 33;
            this.botaoRecomeçar.Text = "Recomeçar";
            this.botaoRecomeçar.UseVisualStyleBackColor = true;
            this.botaoRecomeçar.Click += new System.EventHandler(this.botaoRecomeçar_Click);
            // 
            // Batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 631);
            this.Controls.Add(this.botaoRecomeçar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textHP2);
            this.Controls.Add(this.textATK2);
            this.Controls.Add(this.textDEF2);
            this.Controls.Add(this.textDEF1);
            this.Controls.Add(this.textATK1);
            this.Controls.Add(this.textHP1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DEF2);
            this.Controls.Add(this.ATK2);
            this.Controls.Add(this.HP2);
            this.Controls.Add(this.DEF1);
            this.Controls.Add(this.ATK1);
            this.Controls.Add(this.HP1);
            this.Controls.Add(this.player2Def);
            this.Controls.Add(this.player2Atk);
            this.Controls.Add(this.player1Def);
            this.Controls.Add(this.player1Atk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagemPlayer2);
            this.Controls.Add(this.ImagemPlayer1);
            this.Name = "Batalha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalha";
            this.Load += new System.EventHandler(this.Batalha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemPlayer1;
        private System.Windows.Forms.PictureBox ImagemPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button player1Atk;
        private System.Windows.Forms.Button player1Def;
        private System.Windows.Forms.Button player2Def;
        private System.Windows.Forms.Button player2Atk;
        private System.Windows.Forms.ProgressBar HP1;
        private System.Windows.Forms.ProgressBar ATK1;
        private System.Windows.Forms.ProgressBar DEF1;
        private System.Windows.Forms.ProgressBar DEF2;
        private System.Windows.Forms.ProgressBar ATK2;
        private System.Windows.Forms.ProgressBar HP2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textHP1;
        private System.Windows.Forms.TextBox textATK1;
        private System.Windows.Forms.TextBox textDEF1;
        private System.Windows.Forms.TextBox textHP2;
        private System.Windows.Forms.TextBox textATK2;
        private System.Windows.Forms.TextBox textDEF2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button botaoRecomeçar;
    }
}