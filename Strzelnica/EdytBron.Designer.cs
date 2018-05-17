namespace Strzelnica
{
    partial class EdytBron
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EBOk = new System.Windows.Forms.Button();
            this.EBTypGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRONIETYPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strzelnicaDS = new StrzelnicaDS();
            this.EBCenaNum = new System.Windows.Forms.NumericUpDown();
            this.EBCenalabel = new System.Windows.Forms.Label();
            this.EBTypLabel = new System.Windows.Forms.Label();
            this.EBProdText = new System.Windows.Forms.TextBox();
            this.EBProdLabel = new System.Windows.Forms.Label();
            this.EBModText = new System.Windows.Forms.TextBox();
            this.EBModLabel = new System.Windows.Forms.Label();
            this.EBAmuGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kALIBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMUNICJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EBAmuLabel = new System.Windows.Forms.Label();
            this.EBWybLabel = new System.Windows.Forms.Label();
            this.EBWybNum = new System.Windows.Forms.NumericUpDown();
            this.aMUNICJATableAdapter = new StrzelnicaDSTableAdapters.AMUNICJATableAdapter();
            this.bRONIE_TYPTableAdapter = new StrzelnicaDSTableAdapters.BRONIE_TYPTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EBTypGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBCenaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBAmuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBWybNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.93052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.EBOk, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.EBTypGrid, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.EBCenaNum, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.EBCenalabel, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.EBTypLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.EBProdText, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EBProdLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EBModText, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.EBModLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.EBAmuGrid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.EBAmuLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EBWybLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EBWybNum, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.22581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.354838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.27508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.737864F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.67742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.090615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EBOk
            // 
            this.EBOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EBOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EBOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBOk.Location = new System.Drawing.Point(572, 348);
            this.EBOk.Name = "EBOk";
            this.EBOk.Size = new System.Drawing.Size(89, 40);
            this.EBOk.TabIndex = 10;
            this.EBOk.Text = "OK";
            this.EBOk.UseVisualStyleBackColor = false;
            this.EBOk.Click += new System.EventHandler(this.editBron);
            // 
            // EBTypGrid
            // 
            this.EBTypGrid.AllowUserToAddRows = false;
            this.EBTypGrid.AllowUserToDeleteRows = false;
            this.EBTypGrid.AutoGenerateColumns = false;
            this.EBTypGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EBTypGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EBTypGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nAZWADataGridViewTextBoxColumn});
            this.EBTypGrid.DataSource = this.bRONIETYPBindingSource;
            this.EBTypGrid.Location = new System.Drawing.Point(38, 313);
            this.EBTypGrid.Name = "EBTypGrid";
            this.EBTypGrid.ReadOnly = true;
            this.EBTypGrid.Size = new System.Drawing.Size(245, 75);
            this.EBTypGrid.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.FillWeight = 30.45685F;
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.FillWeight = 169.5432F;
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRONIETYPBindingSource
            // 
            this.bRONIETYPBindingSource.DataMember = "BRONIE_TYP";
            this.bRONIETYPBindingSource.DataSource = this.strzelnicaDS;
            // 
            // strzelnicaDS
            // 
            this.strzelnicaDS.DataSetName = "StrzelnicaDS";
            this.strzelnicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EBCenaNum
            // 
            this.EBCenaNum.Location = new System.Drawing.Point(304, 313);
            this.EBCenaNum.Name = "EBCenaNum";
            this.EBCenaNum.Size = new System.Drawing.Size(140, 20);
            this.EBCenaNum.TabIndex = 6;
            // 
            // EBCenalabel
            // 
            this.EBCenalabel.AutoSize = true;
            this.EBCenalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBCenalabel.Location = new System.Drawing.Point(304, 285);
            this.EBCenalabel.Name = "EBCenalabel";
            this.EBCenalabel.Size = new System.Drawing.Size(47, 20);
            this.EBCenalabel.TabIndex = 4;
            this.EBCenalabel.Text = "Cena";
            // 
            // EBTypLabel
            // 
            this.EBTypLabel.AutoSize = true;
            this.EBTypLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBTypLabel.Location = new System.Drawing.Point(38, 285);
            this.EBTypLabel.Name = "EBTypLabel";
            this.EBTypLabel.Size = new System.Drawing.Size(34, 20);
            this.EBTypLabel.TabIndex = 3;
            this.EBTypLabel.Text = "Typ";
            // 
            // EBProdText
            // 
            this.EBProdText.Location = new System.Drawing.Point(38, 258);
            this.EBProdText.Name = "EBProdText";
            this.EBProdText.Size = new System.Drawing.Size(140, 20);
            this.EBProdText.TabIndex = 7;
            // 
            // EBProdLabel
            // 
            this.EBProdLabel.AutoSize = true;
            this.EBProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBProdLabel.Location = new System.Drawing.Point(38, 228);
            this.EBProdLabel.Name = "EBProdLabel";
            this.EBProdLabel.Size = new System.Drawing.Size(82, 20);
            this.EBProdLabel.TabIndex = 1;
            this.EBProdLabel.Text = "Producent";
            // 
            // EBModText
            // 
            this.EBModText.Location = new System.Drawing.Point(304, 258);
            this.EBModText.Name = "EBModText";
            this.EBModText.Size = new System.Drawing.Size(140, 20);
            this.EBModText.TabIndex = 8;
            // 
            // EBModLabel
            // 
            this.EBModLabel.AutoSize = true;
            this.EBModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBModLabel.Location = new System.Drawing.Point(304, 228);
            this.EBModLabel.Name = "EBModLabel";
            this.EBModLabel.Size = new System.Drawing.Size(52, 20);
            this.EBModLabel.TabIndex = 2;
            this.EBModLabel.Text = "Model";
            // 
            // EBAmuGrid
            // 
            this.EBAmuGrid.AllowUserToAddRows = false;
            this.EBAmuGrid.AllowUserToDeleteRows = false;
            this.EBAmuGrid.AutoGenerateColumns = false;
            this.EBAmuGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EBAmuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EBAmuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kALIBERDataGridViewTextBoxColumn,
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.EBAmuGrid, 2);
            this.EBAmuGrid.DataSource = this.aMUNICJABindingSource;
            this.EBAmuGrid.Location = new System.Drawing.Point(38, 121);
            this.EBAmuGrid.Name = "EBAmuGrid";
            this.EBAmuGrid.ReadOnly = true;
            this.EBAmuGrid.Size = new System.Drawing.Size(463, 104);
            this.EBAmuGrid.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kALIBERDataGridViewTextBoxColumn
            // 
            this.kALIBERDataGridViewTextBoxColumn.DataPropertyName = "KALIBER";
            this.kALIBERDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.kALIBERDataGridViewTextBoxColumn.HeaderText = "KALIBER";
            this.kALIBERDataGridViewTextBoxColumn.Name = "kALIBERDataGridViewTextBoxColumn";
            this.kALIBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iLOSCWPAKIECIEDataGridViewTextBoxColumn
            // 
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn.DataPropertyName = "ILOSC_W_PAKIECIE";
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn.HeaderText = "ILOSC_W_PAKIECIE";
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn.Name = "iLOSCWPAKIECIEDataGridViewTextBoxColumn";
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aMUNICJABindingSource
            // 
            this.aMUNICJABindingSource.DataMember = "AMUNICJA";
            this.aMUNICJABindingSource.DataSource = this.strzelnicaDS;
            // 
            // EBAmuLabel
            // 
            this.EBAmuLabel.AutoSize = true;
            this.EBAmuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBAmuLabel.Location = new System.Drawing.Point(38, 89);
            this.EBAmuLabel.Name = "EBAmuLabel";
            this.EBAmuLabel.Size = new System.Drawing.Size(74, 20);
            this.EBAmuLabel.TabIndex = 0;
            this.EBAmuLabel.Text = "Amunicja";
            // 
            // EBWybLabel
            // 
            this.EBWybLabel.AutoSize = true;
            this.EBWybLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBWybLabel.Location = new System.Drawing.Point(38, 15);
            this.EBWybLabel.Name = "EBWybLabel";
            this.EBWybLabel.Size = new System.Drawing.Size(43, 20);
            this.EBWybLabel.TabIndex = 11;
            this.EBWybLabel.Text = "Bron";
            // 
            // EBWybNum
            // 
            this.EBWybNum.Location = new System.Drawing.Point(38, 51);
            this.EBWybNum.Name = "EBWybNum";
            this.EBWybNum.Size = new System.Drawing.Size(140, 20);
            this.EBWybNum.TabIndex = 12;
            // 
            // aMUNICJATableAdapter
            // 
            this.aMUNICJATableAdapter.ClearBeforeFill = true;
            // 
            // bRONIE_TYPTableAdapter
            // 
            this.bRONIE_TYPTableAdapter.ClearBeforeFill = true;
            // 
            // EdytBron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytBron";
            this.Text = "Edytuj Broń";
            this.Load += new System.EventHandler(this.EdytBron_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EBTypGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBCenaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBAmuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBWybNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EBAmuLabel;
        private System.Windows.Forms.Label EBProdLabel;
        private System.Windows.Forms.Label EBModLabel;
        private System.Windows.Forms.Label EBTypLabel;
        private System.Windows.Forms.Label EBCenalabel;
        private System.Windows.Forms.DataGridView EBAmuGrid;
        private System.Windows.Forms.NumericUpDown EBCenaNum;
        private System.Windows.Forms.TextBox EBProdText;
        private System.Windows.Forms.TextBox EBModText;
        private System.Windows.Forms.DataGridView EBTypGrid;
        private System.Windows.Forms.Button EBOk;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource aMUNICJABindingSource;
        private StrzelnicaDSTableAdapters.AMUNICJATableAdapter aMUNICJATableAdapter;
        private System.Windows.Forms.BindingSource bRONIETYPBindingSource;
        private StrzelnicaDSTableAdapters.BRONIE_TYPTableAdapter bRONIE_TYPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kALIBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLOSCWPAKIECIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label EBWybLabel;
        private System.Windows.Forms.NumericUpDown EBWybNum;
    }
}