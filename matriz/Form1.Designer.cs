namespace matriz
{
    partial class frmMatriz
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.txtMostrarMatriz = new System.Windows.Forms.TextBox();
            this.btnMaiorValor = new System.Windows.Forms.Button();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitulo.Location = new System.Drawing.Point(89, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Matriz Bidimensional";
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.BackColor = System.Drawing.Color.MistyRose;
            this.btnMostrarMatriz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriz.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMostrarMatriz.Location = new System.Drawing.Point(130, 96);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(110, 53);
            this.btnMostrarMatriz.TabIndex = 1;
            this.btnMostrarMatriz.Text = "Mostrar Matriz";
            this.btnMostrarMatriz.UseVisualStyleBackColor = false;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click);
            // 
            // txtMostrarMatriz
            // 
            this.txtMostrarMatriz.BackColor = System.Drawing.Color.MistyRose;
            this.txtMostrarMatriz.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarMatriz.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMostrarMatriz.Location = new System.Drawing.Point(94, 165);
            this.txtMostrarMatriz.Multiline = true;
            this.txtMostrarMatriz.Name = "txtMostrarMatriz";
            this.txtMostrarMatriz.Size = new System.Drawing.Size(188, 129);
            this.txtMostrarMatriz.TabIndex = 2;
            this.txtMostrarMatriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMaiorValor
            // 
            this.btnMaiorValor.BackColor = System.Drawing.Color.MistyRose;
            this.btnMaiorValor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorValor.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMaiorValor.Location = new System.Drawing.Point(130, 310);
            this.btnMaiorValor.Name = "btnMaiorValor";
            this.btnMaiorValor.Size = new System.Drawing.Size(110, 51);
            this.btnMaiorValor.TabIndex = 3;
            this.btnMaiorValor.Text = "Qual é o maior valor?";
            this.btnMaiorValor.UseVisualStyleBackColor = false;
            this.btnMaiorValor.Click += new System.EventHandler(this.btnMaiorValor_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.MistyRose;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(368, 87);
            this.panelTopo.TabIndex = 4;
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(368, 389);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.btnMaiorValor);
            this.Controls.Add(this.txtMostrarMatriz);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Name = "frmMatriz";
            this.Text = "Matriz";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.TextBox txtMostrarMatriz;
        private System.Windows.Forms.Button btnMaiorValor;
        private System.Windows.Forms.Panel panelTopo;
    }
}

