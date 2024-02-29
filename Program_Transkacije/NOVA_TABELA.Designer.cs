
namespace Program_Transkacije
{
    partial class NOVA_TABELA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ime_nova = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime_nova
            // 
            this.ime_nova.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_nova.ForeColor = System.Drawing.Color.DimGray;
            this.ime_nova.Location = new System.Drawing.Point(82, 254);
            this.ime_nova.Name = "ime_nova";
            this.ime_nova.Size = new System.Drawing.Size(202, 27);
            this.ime_nova.TabIndex = 0;
            this.ime_nova.Text = "Ukucajte ime nove tabele";
            this.ime_nova.Enter += new System.EventHandler(this.ime_nova_Enter);
            this.ime_nova.Leave += new System.EventHandler(this.ime_nova_Leave);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Program_Transkacije.Properties.Resources.Screenshot_12;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOVA_TABELA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Program_Transkacije.Properties.Resources.Screenshot_28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ime_nova);
            this.DoubleBuffered = true;
            this.Name = "NOVA_TABELA";
            this.Size = new System.Drawing.Size(602, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime_nova;
        private System.Windows.Forms.Button button1;
    }
}
