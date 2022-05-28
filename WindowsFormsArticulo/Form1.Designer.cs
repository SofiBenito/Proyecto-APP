namespace WindowsFormsArticulo
{
    partial class LblAviso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvArticulo = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminarFisico = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.LblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.LblFiltroAvanzado = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblAvisos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(185, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Listado De Articulos";
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulo.Location = new System.Drawing.Point(6, 82);
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulo.Size = new System.Drawing.Size(643, 303);
            this.DgvArticulo.TabIndex = 1;
            this.DgvArticulo.SelectionChanged += new System.EventHandler(this.DgvArticulo_SelectionChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(46, 388);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 32);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminarFisico
            // 
            this.BtnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFisico.Location = new System.Drawing.Point(266, 388);
            this.BtnEliminarFisico.Name = "BtnEliminarFisico";
            this.BtnEliminarFisico.Size = new System.Drawing.Size(104, 32);
            this.BtnEliminarFisico.TabIndex = 3;
            this.BtnEliminarFisico.Text = "Eliminar Fisico";
            this.BtnEliminarFisico.UseVisualStyleBackColor = true;
            this.BtnEliminarFisico.Click += new System.EventHandler(this.BtnEliminarFisico_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(156, 388);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(104, 32);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(655, 100);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(263, 271);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // LblFiltroRapido
            // 
            this.LblFiltroRapido.AutoSize = true;
            this.LblFiltroRapido.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltroRapido.Location = new System.Drawing.Point(14, 57);
            this.LblFiltroRapido.Name = "LblFiltroRapido";
            this.LblFiltroRapido.Size = new System.Drawing.Size(89, 16);
            this.LblFiltroRapido.TabIndex = 7;
            this.LblFiltroRapido.Text = "Filtro Rapido";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(109, 56);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(192, 20);
            this.txtFiltroRapido.TabIndex = 0;
            this.txtFiltroRapido.Click += new System.EventHandler(this.txtFiltroRapido_Click);
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(664, 450);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(138, 35);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(13, 459);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(52, 16);
            this.LblCampo.TabIndex = 10;
            this.LblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(64, 457);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(138, 21);
            this.cboCampo.TabIndex = 5;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // LblFiltroAvanzado
            // 
            this.LblFiltroAvanzado.AutoSize = true;
            this.LblFiltroAvanzado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltroAvanzado.Location = new System.Drawing.Point(428, 459);
            this.LblFiltroAvanzado.Name = "LblFiltroAvanzado";
            this.LblFiltroAvanzado.Size = new System.Drawing.Size(40, 16);
            this.LblFiltroAvanzado.TabIndex = 12;
            this.LblFiltroAvanzado.Text = "Filtro";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(208, 459);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(54, 16);
            this.LblCriterio.TabIndex = 13;
            this.LblCriterio.Text = "Criterio";
            // 
            // CboCriterio
            // 
            this.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(268, 457);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(138, 21);
            this.CboCriterio.TabIndex = 6;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(474, 457);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(138, 20);
            this.txtFiltroAvanzado.TabIndex = 7;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(376, 388);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(95, 32);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblAvisos
            // 
            this.LblAvisos.AutoSize = true;
            this.LblAvisos.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvisos.Location = new System.Drawing.Point(307, 12);
            this.LblAvisos.Name = "LblAvisos";
            this.LblAvisos.Size = new System.Drawing.Size(244, 60);
            this.LblAvisos.TabIndex = 17;
            this.LblAvisos.Text = "En en el filtro rapido solo puede filtrar Por:\r\nNombre\r\nMarca \r\nCategoria\r\n";
            // 
            // LblAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 494);
            this.Controls.Add(this.LblAvisos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.CboCriterio);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblFiltroAvanzado);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.LblFiltroRapido);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminarFisico);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvArticulo);
            this.Controls.Add(this.LblTitulo);
            this.MaximumSize = new System.Drawing.Size(941, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(941, 533);
            this.Name = "LblAviso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvArticulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminarFisico;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label LblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label LblFiltroAvanzado;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblAvisos;
    }
}

