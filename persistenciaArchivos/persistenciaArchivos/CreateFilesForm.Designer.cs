namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            this.components = new System.ComponentModel.Container();
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.NumeroChequeColumn,
            this.MontoColumn,
            this.DescripcionColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(279, 67);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(471, 185);
            this.ChequesDataGridView.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // NumeroChequeColumn
            // 
            this.NumeroChequeColumn.HeaderText = "Número Cheque";
            this.NumeroChequeColumn.Name = "NumeroChequeColumn";
            this.NumeroChequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto en Colones";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(279, 258);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(657, 258);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.NombreLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.NombreTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 293);
            this.UpsertPanel.TabIndex = 12;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 90);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(37, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto";
            this.MontoLabel.Click += new System.EventHandler(this.MontoLabel_Click);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(21, 106);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(205, 20);
            this.MontoTextBox.TabIndex = 19;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(20, 139);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(122, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 155);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 97);
            this.DescripcionTextBox.TabIndex = 17;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 51);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(98, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque";
            this.NumeroChequeLabel.Click += new System.EventHandler(this.NumeroChequeLabel_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(18, 12);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 15;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(21, 67);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTextBox.TabIndex = 14;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(21, 28);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(205, 20);
            this.NombreTextBox.TabIndex = 13;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 258);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 258);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            this.ListaChequesLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.AutoSize = true;
            this.InformacionRutaLabel.Location = new System.Drawing.Point(276, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(137, 13);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 293);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
    }
}

