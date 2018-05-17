namespace Strzelnica
{
    partial class NewKarnet
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
            this.NKOk = new System.Windows.Forms.Button();
            this.DKNum = new System.Windows.Forms.NumericUpDown();
            this.NKKlieLabel = new System.Windows.Forms.Label();
            this.NKDataPoczLabel = new System.Windows.Forms.Label();
            this.NKMiesLabel = new System.Windows.Forms.Label();
            this.NKGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLIENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strzelnicaDS = new StrzelnicaDS();
            this.DKDate = new System.Windows.Forms.DateTimePicker();
            this.kLIENCITableAdapter = new StrzelnicaDSTableAdapters.KLIENCITableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NKGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.166667F));
            this.tableLayoutPanel1.Controls.Add(this.NKOk, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.DKNum, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NKKlieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NKDataPoczLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NKMiesLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NKGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DKDate, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // NKOk
            // 
            this.NKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NKOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKOk.Location = new System.Drawing.Point(497, 247);
            this.NKOk.Margin = new System.Windows.Forms.Padding(2);
            this.NKOk.Name = "NKOk";
            this.NKOk.Size = new System.Drawing.Size(69, 42);
            this.NKOk.TabIndex = 0;
            this.NKOk.Text = "OK";
            this.NKOk.UseVisualStyleBackColor = false;
            // 
            // DKNum
            // 
            this.DKNum.Location = new System.Drawing.Point(189, 247);
            this.DKNum.Margin = new System.Windows.Forms.Padding(2);
            this.DKNum.Name = "DKNum";
            this.DKNum.Size = new System.Drawing.Size(141, 20);
            this.DKNum.TabIndex = 2;
            // 
            // NKKlieLabel
            // 
            this.NKKlieLabel.AutoSize = true;
            this.NKKlieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKKlieLabel.Location = new System.Drawing.Point(32, 35);
            this.NKKlieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKKlieLabel.Name = "NKKlieLabel";
            this.NKKlieLabel.Size = new System.Drawing.Size(48, 20);
            this.NKKlieLabel.TabIndex = 4;
            this.NKKlieLabel.Text = "Klient";
            this.NKKlieLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NKDataPoczLabel
            // 
            this.NKDataPoczLabel.AutoSize = true;
            this.NKDataPoczLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKDataPoczLabel.Location = new System.Drawing.Point(32, 140);
            this.NKDataPoczLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKDataPoczLabel.Name = "NKDataPoczLabel";
            this.NKDataPoczLabel.Size = new System.Drawing.Size(114, 20);
            this.NKDataPoczLabel.TabIndex = 5;
            this.NKDataPoczLabel.Text = "Data Początek";
            // 
            // NKMiesLabel
            // 
            this.NKMiesLabel.AutoSize = true;
            this.NKMiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKMiesLabel.Location = new System.Drawing.Point(32, 245);
            this.NKMiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKMiesLabel.Name = "NKMiesLabel";
            this.NKMiesLabel.Size = new System.Drawing.Size(106, 20);
            this.NKMiesLabel.TabIndex = 6;
            this.NKMiesLabel.Text = "Ilość Miesięcy";
            // 
            // NKGrid
            // 
            this.NKGrid.AllowUserToAddRows = false;
            this.NKGrid.AllowUserToDeleteRows = false;
            this.NKGrid.AutoGenerateColumns = false;
            this.NKGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NKGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NKGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iMIEDataGridViewTextBoxColumn,
            this.nAZWISKODataGridViewTextBoxColumn});
            this.NKGrid.DataSource = this.kLIENCIBindingSource;
            this.NKGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NKGrid.Location = new System.Drawing.Point(190, 38);
            this.NKGrid.Name = "NKGrid";
            this.NKGrid.ReadOnly = true;
            this.NKGrid.Size = new System.Drawing.Size(302, 99);
            this.NKGrid.TabIndex = 7;
            this.NKGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NKGrid_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 38.61272F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMIEDataGridViewTextBoxColumn
            // 
            this.iMIEDataGridViewTextBoxColumn.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.FillWeight = 106.599F;
            this.iMIEDataGridViewTextBoxColumn.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.Name = "iMIEDataGridViewTextBoxColumn";
            this.iMIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.FillWeight = 154.7883F;
            this.nAZWISKODataGridViewTextBoxColumn.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn.Name = "nAZWISKODataGridViewTextBoxColumn";
            this.nAZWISKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kLIENCIBindingSource
            // 
            this.kLIENCIBindingSource.DataMember = "KLIENCI";
            this.kLIENCIBindingSource.DataSource = this.strzelnicaDS;
            // 
            // strzelnicaDS
            // 
            this.strzelnicaDS.DataSetName = "StrzelnicaDS";
            this.strzelnicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DKDate
            // 
            this.DKDate.Location = new System.Drawing.Point(189, 142);
            this.DKDate.Margin = new System.Windows.Forms.Padding(2);
            this.DKDate.Name = "DKDate";
            this.DKDate.Size = new System.Drawing.Size(216, 20);
            this.DKDate.TabIndex = 1;
            // 
            // kLIENCITableAdapter
            // 
            this.kLIENCITableAdapter.ClearBeforeFill = true;
            // 
            // NewKarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewKarnet";
            this.Text = "Dodaj Karnet";
            this.Load += new System.EventHandler(this.NewKarnet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NKGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button NKOk;
        private System.Windows.Forms.DateTimePicker DKDate;
        private System.Windows.Forms.NumericUpDown DKNum;
        private System.Windows.Forms.Label NKKlieLabel;
        private System.Windows.Forms.Label NKDataPoczLabel;
        private System.Windows.Forms.Label NKMiesLabel;
        private System.Windows.Forms.DataGridView NKGrid;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource kLIENCIBindingSource;
        private StrzelnicaDSTableAdapters.KLIENCITableAdapter kLIENCITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
    }
}