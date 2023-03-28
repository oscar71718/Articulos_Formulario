
namespace prjArtículos
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.grbPrecio = new System.Windows.Forms.GroupBox();
            this.Precio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.Iva = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.lblPreFi = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPrecio
            // 
            this.grbPrecio.BackColor = System.Drawing.Color.Transparent;
            this.grbPrecio.Controls.Add(this.Precio);
            this.grbPrecio.Controls.Add(this.lblPrecio);
            this.grbPrecio.Controls.Add(this.Iva);
            this.grbPrecio.Controls.Add(this.lblIVA);
            this.grbPrecio.Controls.Add(this.Total);
            this.grbPrecio.Controls.Add(this.lblPreFi);
            this.grbPrecio.Location = new System.Drawing.Point(49, 204);
            this.grbPrecio.Name = "grbPrecio";
            this.grbPrecio.Size = new System.Drawing.Size(231, 105);
            this.grbPrecio.TabIndex = 17;
            this.grbPrecio.TabStop = false;
            // 
            // Precio
            // 
            this.Precio.AutoEllipsis = true;
            this.Precio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Precio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Precio.Location = new System.Drawing.Point(90, 16);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(130, 20);
            this.Precio.TabIndex = 14;
            this.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrecio.Location = new System.Drawing.Point(27, 18);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 16);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // Iva
            // 
            this.Iva.AutoEllipsis = true;
            this.Iva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Iva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Iva.Location = new System.Drawing.Point(90, 43);
            this.Iva.Name = "Iva";
            this.Iva.Size = new System.Drawing.Size(130, 20);
            this.Iva.TabIndex = 12;
            this.Iva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.SystemColors.Info;
            this.lblIVA.Location = new System.Drawing.Point(5, 45);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(79, 16);
            this.lblIVA.TabIndex = 11;
            this.lblIVA.Text = "IVA (19%):";
            // 
            // Total
            // 
            this.Total.AutoEllipsis = true;
            this.Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Total.Location = new System.Drawing.Point(90, 70);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(130, 20);
            this.Total.TabIndex = 10;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreFi
            // 
            this.lblPreFi.AutoSize = true;
            this.lblPreFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreFi.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPreFi.Location = new System.Drawing.Point(36, 72);
            this.lblPreFi.Name = "lblPreFi";
            this.lblPreFi.Size = new System.Drawing.Size(48, 16);
            this.lblPreFi.TabIndex = 9;
            this.lblPreFi.Text = "Total:";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(132, 95);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(121, 21);
            this.cboNombre.TabIndex = 16;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(132, 58);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 15;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNombre.Location = new System.Drawing.Point(58, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTipo.Location = new System.Drawing.Point(81, 60);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 16);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTerminar.Location = new System.Drawing.Point(192, 343);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(130, 31);
            this.btnTerminar.TabIndex = 12;
            this.btnTerminar.Text = "terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Location = new System.Drawing.Point(9, 345);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 29);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Green;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnProcesar.Location = new System.Drawing.Point(99, 144);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(130, 25);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitulo.Location = new System.Drawing.Point(97, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 30);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "ARTICULOS";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.Controls.Add(this.grbPrecio);
            this.Controls.Add(this.cboNombre);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulos";
            this.Text = "Artículos Oscar Restrepo";
            this.grbPrecio.ResumeLayout(false);
            this.grbPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label Iva;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label lblPreFi;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblTitulo;
    }
}

