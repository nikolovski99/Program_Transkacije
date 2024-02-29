
namespace Program_Transkacije
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dugme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.home1 = new Program_Transkacije.Home();
            this.novA_TABELA1 = new Program_Transkacije.NOVA_TABELA();
            this.dodaJ_TRANSAKCIJU1 = new Program_Transkacije.DODAJ_TRANSAKCIJU();
            this.obrisI_TABELU1 = new Program_Transkacije.OBRISI_TABELU();
            this.stanje1 = new Program_Transkacije.STANJE();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dugme);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 499);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.home1);
            this.panel2.Controls.Add(this.novA_TABELA1);
            this.panel2.Controls.Add(this.dodaJ_TRANSAKCIJU1);
            this.panel2.Controls.Add(this.obrisI_TABELU1);
            this.panel2.Controls.Add(this.stanje1);
            this.panel2.Location = new System.Drawing.Point(193, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 499);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Program_Transkacije.Properties.Resources.Screenshot_39;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 87);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Constantia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Program_Transkacije.Properties.Resources.Screenshot_36;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "              OBRIŠI TABELU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dugme
            // 
            this.dugme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.dugme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dugme.FlatAppearance.BorderSize = 0;
            this.dugme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme.Font = new System.Drawing.Font("Constantia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme.ForeColor = System.Drawing.Color.White;
            this.dugme.Image = ((System.Drawing.Image)(resources.GetObject("dugme.Image")));
            this.dugme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme.Location = new System.Drawing.Point(0, 96);
            this.dugme.Name = "dugme";
            this.dugme.Size = new System.Drawing.Size(193, 73);
            this.dugme.TabIndex = 0;
            this.dugme.Text = "DODAJ TRANSKACIJU";
            this.dugme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dugme.UseVisualStyleBackColor = false;
            this.dugme.Click += new System.EventHandler(this.dugme_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Constantia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Program_Transkacije.Properties.Resources.Screenshot_37;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "               DODAJ TABELU";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Constantia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Program_Transkacije.Properties.Resources.Screenshot_38;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "STANJE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(602, 499);
            this.home1.TabIndex = 4;
            // 
            // novA_TABELA1
            // 
            this.novA_TABELA1.BackColor = System.Drawing.Color.White;
            this.novA_TABELA1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("novA_TABELA1.BackgroundImage")));
            this.novA_TABELA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novA_TABELA1.Location = new System.Drawing.Point(0, 0);
            this.novA_TABELA1.Name = "novA_TABELA1";
            this.novA_TABELA1.Size = new System.Drawing.Size(602, 499);
            this.novA_TABELA1.TabIndex = 3;
            // 
            // dodaJ_TRANSAKCIJU1
            // 
            this.dodaJ_TRANSAKCIJU1.Location = new System.Drawing.Point(0, 0);
            this.dodaJ_TRANSAKCIJU1.Name = "dodaJ_TRANSAKCIJU1";
            this.dodaJ_TRANSAKCIJU1.Size = new System.Drawing.Size(602, 499);
            this.dodaJ_TRANSAKCIJU1.TabIndex = 2;
            // 
            // obrisI_TABELU1
            // 
            this.obrisI_TABELU1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obrisI_TABELU1.BackgroundImage")));
            this.obrisI_TABELU1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obrisI_TABELU1.Location = new System.Drawing.Point(0, 0);
            this.obrisI_TABELU1.Name = "obrisI_TABELU1";
            this.obrisI_TABELU1.Size = new System.Drawing.Size(602, 499);
            this.obrisI_TABELU1.TabIndex = 1;
            // 
            // stanje1
            // 
            this.stanje1.BackColor = System.Drawing.Color.White;
            this.stanje1.Location = new System.Drawing.Point(0, 0);
            this.stanje1.Name = "stanje1";
            this.stanje1.Size = new System.Drawing.Size(602, 499);
            this.stanje1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(794, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PROGRAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button dugme;
        private System.Windows.Forms.Button button1;
        private NOVA_TABELA novA_TABELA1;
        private DODAJ_TRANSAKCIJU dodaJ_TRANSAKCIJU1;
        private OBRISI_TABELU obrisI_TABELU1;
        private STANJE stanje1;
        private Home home1;
    }
}

