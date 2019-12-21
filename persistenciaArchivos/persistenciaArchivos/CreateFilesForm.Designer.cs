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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerodechequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstitucionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.MonedaTextBox = new System.Windows.Forms.TextBox();
            this.InstitucionFinancieraTextBox = new System.Windows.Forms.TextBox();
            this.InstitucionFinancieraLabel = new System.Windows.Forms.Label();
            this.NumeroDeChequeLabel = new System.Windows.Forms.Label();
            this.NumeroDeChequeTextBox = new System.Windows.Forms.TextBox();
            this.FechaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ReceptorTextBox = new System.Windows.Forms.TextBox();
            this.EmisorTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EditarChequeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmisorColumn,
            this.ReceptorColumn,
            this.FechaColumn,
            this.NumerodechequeColumn,
            this.MontoColumn,
            this.InstitucionColumn,
            this.DescripcionColumn,
            this.MonedaColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(279, 81);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(834, 317);
            this.ChequesDataGridView.TabIndex = 2;
            // 
            // EmisorColumn
            // 
            this.EmisorColumn.HeaderText = "Emisor";
            this.EmisorColumn.Name = "EmisorColumn";
            this.EmisorColumn.ReadOnly = true;
            // 
            // ReceptorColumn
            // 
            this.ReceptorColumn.HeaderText = "Receptor";
            this.ReceptorColumn.Name = "ReceptorColumn";
            this.ReceptorColumn.ReadOnly = true;
            // 
            // FechaColumn
            // 
            this.FechaColumn.HeaderText = "Fecha";
            this.FechaColumn.Name = "FechaColumn";
            this.FechaColumn.ReadOnly = true;
            // 
            // NumerodechequeColumn
            // 
            this.NumerodechequeColumn.HeaderText = "Numero de cheque";
            this.NumerodechequeColumn.Name = "NumerodechequeColumn";
            this.NumerodechequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // InstitucionColumn
            // 
            this.InstitucionColumn.HeaderText = "Institucion Financiera";
            this.InstitucionColumn.Name = "InstitucionColumn";
            this.InstitucionColumn.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripcion";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // MonedaColumn
            // 
            this.MonedaColumn.HeaderText = "Moneda";
            this.MonedaColumn.Name = "MonedaColumn";
            this.MonedaColumn.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(279, 404);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(1020, 404);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UpsertPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpsertPanel.Controls.Add(this.MonedaLabel);
            this.UpsertPanel.Controls.Add(this.MonedaTextBox);
            this.UpsertPanel.Controls.Add(this.InstitucionFinancieraTextBox);
            this.UpsertPanel.Controls.Add(this.InstitucionFinancieraLabel);
            this.UpsertPanel.Controls.Add(this.NumeroDeChequeLabel);
            this.UpsertPanel.Controls.Add(this.NumeroDeChequeTextBox);
            this.UpsertPanel.Controls.Add(this.FechaTextBox);
            this.UpsertPanel.Controls.Add(this.label1);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.NombreLabel);
            this.UpsertPanel.Controls.Add(this.ReceptorTextBox);
            this.UpsertPanel.Controls.Add(this.EmisorTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(262, 436);
            this.UpsertPanel.TabIndex = 12;
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MonedaLabel.Location = new System.Drawing.Point(20, 246);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(46, 13);
            this.MonedaLabel.TabIndex = 28;
            this.MonedaLabel.Text = "Moneda";
            // 
            // MonedaTextBox
            // 
            this.MonedaTextBox.Location = new System.Drawing.Point(21, 262);
            this.MonedaTextBox.Name = "MonedaTextBox";
            this.MonedaTextBox.Size = new System.Drawing.Size(205, 20);
            this.MonedaTextBox.TabIndex = 27;
            // 
            // InstitucionFinancieraTextBox
            // 
            this.InstitucionFinancieraTextBox.Location = new System.Drawing.Point(21, 223);
            this.InstitucionFinancieraTextBox.Name = "InstitucionFinancieraTextBox";
            this.InstitucionFinancieraTextBox.Size = new System.Drawing.Size(205, 20);
            this.InstitucionFinancieraTextBox.TabIndex = 26;
            // 
            // InstitucionFinancieraLabel
            // 
            this.InstitucionFinancieraLabel.AutoSize = true;
            this.InstitucionFinancieraLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InstitucionFinancieraLabel.Location = new System.Drawing.Point(20, 207);
            this.InstitucionFinancieraLabel.Name = "InstitucionFinancieraLabel";
            this.InstitucionFinancieraLabel.Size = new System.Drawing.Size(107, 13);
            this.InstitucionFinancieraLabel.TabIndex = 25;
            this.InstitucionFinancieraLabel.Text = "Institucion Financiera";
            // 
            // NumeroDeChequeLabel
            // 
            this.NumeroDeChequeLabel.AutoSize = true;
            this.NumeroDeChequeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumeroDeChequeLabel.Location = new System.Drawing.Point(20, 168);
            this.NumeroDeChequeLabel.Name = "NumeroDeChequeLabel";
            this.NumeroDeChequeLabel.Size = new System.Drawing.Size(98, 13);
            this.NumeroDeChequeLabel.TabIndex = 24;
            this.NumeroDeChequeLabel.Text = "Numero de cheque";
            // 
            // NumeroDeChequeTextBox
            // 
            this.NumeroDeChequeTextBox.Location = new System.Drawing.Point(21, 184);
            this.NumeroDeChequeTextBox.Name = "NumeroDeChequeTextBox";
            this.NumeroDeChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroDeChequeTextBox.TabIndex = 23;
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.Location = new System.Drawing.Point(21, 145);
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(205, 20);
            this.FechaTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha (DD/DD/DD)";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 90);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(21, 106);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(205, 20);
            this.MontoTextBox.TabIndex = 2;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(20, 285);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 301);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 97);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 51);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(138, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Receptor (min 3 caractéres)";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(20, 12);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(125, 13);
            this.NombreLabel.TabIndex = 15;
            this.NombreLabel.Text = "Emisor (min 3 caractéres)";
            // 
            // ReceptorTextBox
            // 
            this.ReceptorTextBox.Location = new System.Drawing.Point(21, 67);
            this.ReceptorTextBox.Name = "ReceptorTextBox";
            this.ReceptorTextBox.Size = new System.Drawing.Size(205, 20);
            this.ReceptorTextBox.TabIndex = 1;
            // 
            // EmisorTextBox
            // 
            this.EmisorTextBox.Location = new System.Drawing.Point(21, 28);
            this.EmisorTextBox.Name = "EmisorTextBox";
            this.EmisorTextBox.Size = new System.Drawing.Size(205, 20);
            this.EmisorTextBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 404);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 404);
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
            this.ListaChequesLabel.Location = new System.Drawing.Point(278, 4);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(360, 404);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // EditarChequeButton
            // 
            this.EditarChequeButton.Location = new System.Drawing.Point(461, 404);
            this.EditarChequeButton.Name = "EditarChequeButton";
            this.EditarChequeButton.Size = new System.Drawing.Size(105, 23);
            this.EditarChequeButton.TabIndex = 17;
            this.EditarChequeButton.Text = "Editar un cheque";
            this.EditarChequeButton.UseVisualStyleBackColor = true;
            this.EditarChequeButton.Click += new System.EventHandler(this.TodosLosChequesbButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 436);
            this.Controls.Add(this.EditarChequeButton);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox ReceptorTextBox;
        private System.Windows.Forms.TextBox EmisorTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.TextBox MonedaTextBox;
        private System.Windows.Forms.TextBox InstitucionFinancieraTextBox;
        private System.Windows.Forms.Label InstitucionFinancieraLabel;
        private System.Windows.Forms.Label NumeroDeChequeLabel;
        private System.Windows.Forms.TextBox NumeroDeChequeTextBox;
        private System.Windows.Forms.TextBox FechaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerodechequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstitucionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaColumn;
        private System.Windows.Forms.Button EditarChequeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

