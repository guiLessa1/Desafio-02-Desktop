namespace Desafio_02
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnFiltrarPreco = new System.Windows.Forms.Button();
            this.btnFiltrarCategoria = new System.Windows.Forms.Button();
            this.txFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.txFiltrarPreco = new System.Windows.Forms.TextBox();
            this.btnAdicionarFavorito = new System.Windows.Forms.Button();
            this.btnListarFavoritos = new System.Windows.Forms.Button();
            this.txPreco2 = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbPrecoMin = new System.Windows.Forms.Label();
            this.btnObter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(517, 356);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick_1);
            // 
            // btnFiltrarPreco
            // 
            this.btnFiltrarPreco.Location = new System.Drawing.Point(537, 123);
            this.btnFiltrarPreco.Name = "btnFiltrarPreco";
            this.btnFiltrarPreco.Size = new System.Drawing.Size(149, 23);
            this.btnFiltrarPreco.TabIndex = 3;
            this.btnFiltrarPreco.Text = "Filtrar por Preço";
            this.btnFiltrarPreco.UseVisualStyleBackColor = true;
            this.btnFiltrarPreco.Click += new System.EventHandler(this.btnFiltrarPreco_Click);
            // 
            // btnFiltrarCategoria
            // 
            this.btnFiltrarCategoria.Location = new System.Drawing.Point(537, 208);
            this.btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            this.btnFiltrarCategoria.Size = new System.Drawing.Size(149, 23);
            this.btnFiltrarCategoria.TabIndex = 4;
            this.btnFiltrarCategoria.Text = "Filtrar por Categoria";
            this.btnFiltrarCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarCategoria.Click += new System.EventHandler(this.btnFiltrarCategoria_Click);
            // 
            // txFiltrarCategoria
            // 
            this.txFiltrarCategoria.Location = new System.Drawing.Point(537, 182);
            this.txFiltrarCategoria.Name = "txFiltrarCategoria";
            this.txFiltrarCategoria.Size = new System.Drawing.Size(100, 20);
            this.txFiltrarCategoria.TabIndex = 5;
            // 
            // txFiltrarPreco
            // 
            this.txFiltrarPreco.Location = new System.Drawing.Point(537, 97);
            this.txFiltrarPreco.Name = "txFiltrarPreco";
            this.txFiltrarPreco.Size = new System.Drawing.Size(100, 20);
            this.txFiltrarPreco.TabIndex = 6;
            // 
            // btnAdicionarFavorito
            // 
            this.btnAdicionarFavorito.Location = new System.Drawing.Point(537, 286);
            this.btnAdicionarFavorito.Name = "btnAdicionarFavorito";
            this.btnAdicionarFavorito.Size = new System.Drawing.Size(139, 23);
            this.btnAdicionarFavorito.TabIndex = 7;
            this.btnAdicionarFavorito.Text = "AdicionarFavorito";
            this.btnAdicionarFavorito.UseVisualStyleBackColor = true;
            this.btnAdicionarFavorito.Click += new System.EventHandler(this.btnAdicionarFavorito_Click);
            // 
            // btnListarFavoritos
            // 
            this.btnListarFavoritos.Location = new System.Drawing.Point(537, 315);
            this.btnListarFavoritos.Name = "btnListarFavoritos";
            this.btnListarFavoritos.Size = new System.Drawing.Size(139, 23);
            this.btnListarFavoritos.TabIndex = 8;
            this.btnListarFavoritos.Text = "Listar Favoritos";
            this.btnListarFavoritos.UseVisualStyleBackColor = true;
            this.btnListarFavoritos.Click += new System.EventHandler(this.btnListarFavoritos_Click);
            // 
            // txPreco2
            // 
            this.txPreco2.Location = new System.Drawing.Point(537, 43);
            this.txPreco2.Name = "txPreco2";
            this.txPreco2.Size = new System.Drawing.Size(100, 20);
            this.txPreco2.TabIndex = 9;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(537, 27);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(74, 13);
            this.lbPreco.TabIndex = 10;
            this.lbPreco.Text = "Preço Máximo";
            // 
            // lbPrecoMin
            // 
            this.lbPrecoMin.AutoSize = true;
            this.lbPrecoMin.Location = new System.Drawing.Point(538, 81);
            this.lbPrecoMin.Name = "lbPrecoMin";
            this.lbPrecoMin.Size = new System.Drawing.Size(73, 13);
            this.lbPrecoMin.TabIndex = 11;
            this.lbPrecoMin.Text = "Preço Mínimo";
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(3, 392);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(149, 23);
            this.btnObter.TabIndex = 12;
            this.btnObter.Text = "Obter Lista";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.lbPrecoMin);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.txPreco2);
            this.Controls.Add(this.btnListarFavoritos);
            this.Controls.Add(this.btnAdicionarFavorito);
            this.Controls.Add(this.txFiltrarPreco);
            this.Controls.Add(this.txFiltrarCategoria);
            this.Controls.Add(this.btnFiltrarCategoria);
            this.Controls.Add(this.btnFiltrarPreco);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnFiltrarPreco;
        private System.Windows.Forms.Button btnFiltrarCategoria;
        private System.Windows.Forms.TextBox txFiltrarCategoria;
        private System.Windows.Forms.TextBox txFiltrarPreco;
        private System.Windows.Forms.Button btnAdicionarFavorito;
        private System.Windows.Forms.Button btnListarFavoritos;
        private System.Windows.Forms.TextBox txPreco2;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbPrecoMin;
        private System.Windows.Forms.Button btnObter;
    }
}

