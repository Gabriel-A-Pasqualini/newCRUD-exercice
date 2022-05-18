namespace newCRUD
{
    partial class Novo
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
            this.salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newModelo = new System.Windows.Forms.TextBox();
            this.newPlaca = new System.Windows.Forms.TextBox();
            this.newCor = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(35, 495);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(169, 55);
            this.salvar.TabIndex = 0;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newModelo
            // 
            this.newModelo.Location = new System.Drawing.Point(35, 147);
            this.newModelo.Name = "newModelo";
            this.newModelo.Size = new System.Drawing.Size(270, 20);
            this.newModelo.TabIndex = 2;
            // 
            // newPlaca
            // 
            this.newPlaca.Location = new System.Drawing.Point(35, 239);
            this.newPlaca.Name = "newPlaca";
            this.newPlaca.Size = new System.Drawing.Size(270, 20);
            this.newPlaca.TabIndex = 3;
            // 
            // newCor
            // 
            this.newCor.Location = new System.Drawing.Point(35, 341);
            this.newCor.Name = "newCor";
            this.newCor.Size = new System.Drawing.Size(270, 20);
            this.newCor.TabIndex = 4;
            // 
            // newModel
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(35, 107);
            this.Model.Name = "newModel";
            this.Model.Size = new System.Drawing.Size(45, 13);
            this.Model.TabIndex = 5;
            this.Model.Text = "Modelo:";
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Location = new System.Drawing.Point(35, 206);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(37, 13);
            this.Placa.TabIndex = 6;
            this.Placa.Text = "Placa:";
            // 
            // newColor
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(32, 307);
            this.Color.Name = "newColor";
            this.Color.Size = new System.Drawing.Size(26, 13);
            this.Color.TabIndex = 7;
            this.Color.Text = "Cor:";
            // 
            // Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 584);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.newCor);
            this.Controls.Add(this.newPlaca);
            this.Controls.Add(this.newModelo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salvar);
            this.Name = "Novo";
            this.Text = "Novo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newModelo;
        private System.Windows.Forms.TextBox newPlaca;
        private System.Windows.Forms.TextBox newCor;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.Label Color;
    }
}