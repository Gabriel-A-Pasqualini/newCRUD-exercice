namespace newCRUD
{
    partial class inicial
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
            this.srcModelo = new System.Windows.Forms.TextBox();
            this.srcPlaca = new System.Windows.Forms.TextBox();
            this.srcCor = new System.Windows.Forms.TextBox();
            this.carroGrid = new System.Windows.Forms.DataGridView();
            this.novo = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // srcModelo
            // 
            this.srcModelo.Location = new System.Drawing.Point(49, 182);
            this.srcModelo.Name = "srcModelo";
            this.srcModelo.Size = new System.Drawing.Size(194, 20);
            this.srcModelo.TabIndex = 0;
            this.srcModelo.TextChanged += new System.EventHandler(this.srcModelo_TextChanged);
            // 
            // srcPlaca
            // 
            this.srcPlaca.Location = new System.Drawing.Point(49, 265);
            this.srcPlaca.Name = "srcPlaca";
            this.srcPlaca.Size = new System.Drawing.Size(194, 20);
            this.srcPlaca.TabIndex = 1;
            this.srcPlaca.TextChanged += new System.EventHandler(this.srcPlaca_TextChanged);
            // 
            // srcCor
            // 
            this.srcCor.Location = new System.Drawing.Point(49, 351);
            this.srcCor.Name = "srcCor";
            this.srcCor.Size = new System.Drawing.Size(194, 20);
            this.srcCor.TabIndex = 2;
            this.srcCor.TextChanged += new System.EventHandler(this.srcCor_TextChanged);
            // 
            // carroGrid
            // 
            this.carroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroGrid.Location = new System.Drawing.Point(314, 88);
            this.carroGrid.Name = "carroGrid";
            this.carroGrid.Size = new System.Drawing.Size(604, 388);
            this.carroGrid.TabIndex = 3;
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(314, 528);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(119, 56);
            this.novo.TabIndex = 4;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(480, 528);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(119, 56);
            this.modificar.TabIndex = 5;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(640, 528);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(119, 56);
            this.excluir.TabIndex = 6;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(799, 528);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(119, 56);
            this.sair.TabIndex = 7;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cor:";
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.carroGrid);
            this.Controls.Add(this.srcCor);
            this.Controls.Add(this.srcPlaca);
            this.Controls.Add(this.srcModelo);
            this.Name = "inicial";
            this.Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.carroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcModelo;
        private System.Windows.Forms.TextBox srcPlaca;
        private System.Windows.Forms.TextBox srcCor;
        private System.Windows.Forms.DataGridView carroGrid;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

