﻿namespace Strzelnica
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
            this.EBAmuLabel = new System.Windows.Forms.Label();
            this.EBProdLabel = new System.Windows.Forms.Label();
            this.EBModLabel = new System.Windows.Forms.Label();
            this.EBTypLabel = new System.Windows.Forms.Label();
            this.EBCenalabel = new System.Windows.Forms.Label();
            this.EBAmuGrid = new System.Windows.Forms.DataGridView();
            this.EBCenaNum = new System.Windows.Forms.NumericUpDown();
            this.EBProdText = new System.Windows.Forms.TextBox();
            this.EBModText = new System.Windows.Forms.TextBox();
            this.EBTypGrid = new System.Windows.Forms.DataGridView();
            this.EBOk = new System.Windows.Forms.Button();
            this.strzelnicaDS = new StrzelnicaDS();
            this.aMUNICJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMUNICJATableAdapter = new StrzelnicaDSTableAdapters.AMUNICJATableAdapter();
            this.bRONIETYPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRONIE_TYPTableAdapter = new StrzelnicaDSTableAdapters.BRONIE_TYPTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kALIBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLOSCWPAKIECIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EBAmuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBCenaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBTypGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.EBAmuLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EBProdLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EBModLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.EBCenalabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.EBTypLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EBAmuGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EBCenaNum, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.EBModText, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.EBTypGrid, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EBOk, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.EBProdText, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.47331F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.38434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.117438F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.78378F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.486486F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.16216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EBAmuLabel
            // 
            this.EBAmuLabel.AutoSize = true;
            this.EBAmuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBAmuLabel.Location = new System.Drawing.Point(36, 18);
            this.EBAmuLabel.Name = "EBAmuLabel";
            this.EBAmuLabel.Size = new System.Drawing.Size(74, 20);
            this.EBAmuLabel.TabIndex = 0;
            this.EBAmuLabel.Text = "Amunicja";
            // 
            // EBProdLabel
            // 
            this.EBProdLabel.AutoSize = true;
            this.EBProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBProdLabel.Location = new System.Drawing.Point(36, 165);
            this.EBProdLabel.Name = "EBProdLabel";
            this.EBProdLabel.Size = new System.Drawing.Size(82, 20);
            this.EBProdLabel.TabIndex = 1;
            this.EBProdLabel.Text = "Producent";
            // 
            // EBModLabel
            // 
            this.EBModLabel.AutoSize = true;
            this.EBModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBModLabel.Location = new System.Drawing.Point(287, 165);
            this.EBModLabel.Name = "EBModLabel";
            this.EBModLabel.Size = new System.Drawing.Size(52, 20);
            this.EBModLabel.TabIndex = 2;
            this.EBModLabel.Text = "Model";
            // 
            // EBTypLabel
            // 
            this.EBTypLabel.AutoSize = true;
            this.EBTypLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBTypLabel.Location = new System.Drawing.Point(36, 242);
            this.EBTypLabel.Name = "EBTypLabel";
            this.EBTypLabel.Size = new System.Drawing.Size(34, 20);
            this.EBTypLabel.TabIndex = 3;
            this.EBTypLabel.Text = "Typ";
            this.EBTypLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // EBCenalabel
            // 
            this.EBCenalabel.AutoSize = true;
            this.EBCenalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBCenalabel.Location = new System.Drawing.Point(287, 242);
            this.EBCenalabel.Name = "EBCenalabel";
            this.EBCenalabel.Size = new System.Drawing.Size(47, 20);
            this.EBCenalabel.TabIndex = 4;
            this.EBCenalabel.Text = "Cena";
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
            this.EBAmuGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EBAmuGrid.Location = new System.Drawing.Point(36, 48);
            this.EBAmuGrid.Name = "EBAmuGrid";
            this.EBAmuGrid.ReadOnly = true;
            this.EBAmuGrid.Size = new System.Drawing.Size(463, 114);
            this.EBAmuGrid.TabIndex = 5;
            this.EBAmuGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EBAmuGrid_CellContentClick);
            // 
            // EBCenaNum
            // 
            this.EBCenaNum.Location = new System.Drawing.Point(287, 269);
            this.EBCenaNum.Name = "EBCenaNum";
            this.EBCenaNum.Size = new System.Drawing.Size(140, 20);
            this.EBCenaNum.TabIndex = 6;
            // 
            // EBProdText
            // 
            this.EBProdText.Location = new System.Drawing.Point(36, 194);
            this.EBProdText.Name = "EBProdText";
            this.EBProdText.Size = new System.Drawing.Size(140, 20);
            this.EBProdText.TabIndex = 7;
            // 
            // EBModText
            // 
            this.EBModText.Location = new System.Drawing.Point(287, 194);
            this.EBModText.Name = "EBModText";
            this.EBModText.Size = new System.Drawing.Size(140, 20);
            this.EBModText.TabIndex = 8;
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
            this.EBTypGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EBTypGrid.Location = new System.Drawing.Point(36, 269);
            this.EBTypGrid.Name = "EBTypGrid";
            this.EBTypGrid.ReadOnly = true;
            this.EBTypGrid.Size = new System.Drawing.Size(245, 76);
            this.EBTypGrid.TabIndex = 9;
            // 
            // EBOk
            // 
            this.EBOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EBOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EBOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EBOk.Location = new System.Drawing.Point(535, 305);
            this.EBOk.Name = "EBOk";
            this.EBOk.Size = new System.Drawing.Size(89, 40);
            this.EBOk.TabIndex = 10;
            this.EBOk.Text = "OK";
            this.EBOk.UseVisualStyleBackColor = false;
            // 
            // strzelnicaDS
            // 
            this.strzelnicaDS.DataSetName = "StrzelnicaDS";
            this.strzelnicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMUNICJABindingSource
            // 
            this.aMUNICJABindingSource.DataMember = "AMUNICJA";
            this.aMUNICJABindingSource.DataSource = this.strzelnicaDS;
            // 
            // aMUNICJATableAdapter
            // 
            this.aMUNICJATableAdapter.ClearBeforeFill = true;
            // 
            // bRONIETYPBindingSource
            // 
            this.bRONIETYPBindingSource.DataMember = "BRONIE_TYP";
            this.bRONIETYPBindingSource.DataSource = this.strzelnicaDS;
            // 
            // bRONIE_TYPTableAdapter
            // 
            this.bRONIE_TYPTableAdapter.ClearBeforeFill = true;
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
            // EdytBron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytBron";
            this.Text = "Edytuj Broń";
            this.Load += new System.EventHandler(this.EdytBron_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EBAmuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBCenaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBTypGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).EndInit();
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
    }
}