namespace newCRUD
{
    partial class Alterar
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
            this.newColor = new System.Windows.Forms.Label();
            this.newPlaca = new System.Windows.Forms.Label();
            this.newModel = new System.Windows.Forms.Label();
            this.alterCor = new System.Windows.Forms.TextBox();
            this.alterPlaca = new System.Windows.Forms.TextBox();
            this.alterModelo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newColor
            // 
            this.newColor.AutoSize = true;
            this.newColor.Location = new System.Drawing.Point(33, 294);
            this.newColor.Name = "newColor";
            this.newColor.Size = new System.Drawing.Size(26, 13);
            this.newColor.TabIndex = 15;
            this.newColor.Text = "Cor:";
            // 
            // newPlaca
            // 
            this.newPlaca.AutoSize = true;
            this.newPlaca.Location = new System.Drawing.Point(36, 193);
            this.newPlaca.Name = "newPlaca";
            this.newPlaca.Size = new System.Drawing.Size(37, 13);
            this.newPlaca.TabIndex = 14;
            this.newPlaca.Text = "Placa:";
            // 
            // newModel
            // 
            this.newModel.AutoSize = true;
            this.newModel.Location = new System.Drawing.Point(36, 94);
            this.newModel.Name = "newModel";
            this.newModel.Size = new System.Drawing.Size(45, 13);
            this.newModel.TabIndex = 13;
            this.newModel.Text = "Modelo:";
            // 
            // alterCor
            // 
            this.alterCor.Location = new System.Drawing.Point(36, 328);
            this.alterCor.Name = "alterCor";
            this.alterCor.Size = new System.Drawing.Size(270, 20);
            this.alterCor.TabIndex = 12;
            // 
            // alterPlaca
            // 
            this.alterPlaca.Location = new System.Drawing.Point(36, 226);
            this.alterPlaca.Name = "alterPlaca";
            this.alterPlaca.Size = new System.Drawing.Size(270, 20);
            this.alterPlaca.TabIndex = 11;
            // 
            // alterModelo
            // 
            this.alterModelo.Location = new System.Drawing.Point(36, 134);
            this.alterModelo.Name = "alterModelo";
            this.alterModelo.Size = new System.Drawing.Size(270, 20);
            this.alterModelo.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(36, 482);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(169, 55);
            this.salvar.TabIndex = 8;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 579);
            this.Controls.Add(this.newColor);
            this.Controls.Add(this.newPlaca);
            this.Controls.Add(this.newModel);
            this.Controls.Add(this.alterCor);
            this.Controls.Add(this.alterPlaca);
            this.Controls.Add(this.alterModelo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salvar);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newColor;
        private System.Windows.Forms.Label newPlaca;
        private System.Windows.Forms.Label newModel;
        private System.Windows.Forms.TextBox alterCor;
        private System.Windows.Forms.TextBox alterPlaca;
        private System.Windows.Forms.TextBox alterModelo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salvar;
    }
}