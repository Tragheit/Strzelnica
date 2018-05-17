namespace Strzelnica
{
    partial class EdytKlient
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
            this.EKImieLabel = new System.Windows.Forms.Label();
            this.EKNazwiskoLabel = new System.Windows.Forms.Label();
            this.EKKarnetLabel = new System.Windows.Forms.Label();
            this.EKWiekLabel = new System.Windows.Forms.Label();
            this.EKImieBox = new System.Windows.Forms.TextBox();
            this.EKNazwiskoBox = new System.Windows.Forms.TextBox();
            this.EKWiekNum = new System.Windows.Forms.NumericUpDown();
            this.EKOk = new System.Windows.Forms.Button();
            this.strzelnicaDS = new StrzelnicaDS();
            this.kLIENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLIENCITableAdapter = new StrzelnicaDSTableAdapters.KLIENCITableAdapter();
            this.EKKarnetGrid = new System.Windows.Forms.DataGridView();
            this.kARNETYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kARNETYTableAdapter = new StrzelnicaDSTableAdapters.KARNETYTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rODZAJKARNETUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWAZNOSCIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKWiekNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EKKarnetGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARNETYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.EKImieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EKNazwiskoLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EKKarnetLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EKWiekLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.EKImieBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EKNazwiskoBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.EKWiekNum, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.EKOk, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.EKKarnetGrid, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EKImieLabel
            // 
            this.EKImieLabel.AutoSize = true;
            this.EKImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKImieLabel.Location = new System.Drawing.Point(43, 22);
            this.EKImieLabel.Name = "EKImieLabel";
            this.EKImieLabel.Size = new System.Drawing.Size(39, 20);
            this.EKImieLabel.TabIndex = 0;
            this.EKImieLabel.Text = "Imię";
            // 
            // EKNazwiskoLabel
            // 
            this.EKNazwiskoLabel.AutoSize = true;
            this.EKNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKNazwiskoLabel.Location = new System.Drawing.Point(283, 22);
            this.EKNazwiskoLabel.Name = "EKNazwiskoLabel";
            this.EKNazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.EKNazwiskoLabel.TabIndex = 1;
            this.EKNazwiskoLabel.Text = "Nazwisko";
            // 
            // EKKarnetLabel
            // 
            this.EKKarnetLabel.AutoSize = true;
            this.EKKarnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKKarnetLabel.Location = new System.Drawing.Point(43, 224);
            this.EKKarnetLabel.Name = "EKKarnetLabel";
            this.EKKarnetLabel.Size = new System.Drawing.Size(56, 20);
            this.EKKarnetLabel.TabIndex = 2;
            this.EKKarnetLabel.Text = "Karnet";
            // 
            // EKWiekLabel
            // 
            this.EKWiekLabel.AutoSize = true;
            this.EKWiekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKWiekLabel.Location = new System.Drawing.Point(283, 224);
            this.EKWiekLabel.Name = "EKWiekLabel";
            this.EKWiekLabel.Size = new System.Drawing.Size(44, 20);
            this.EKWiekLabel.TabIndex = 3;
            this.EKWiekLabel.Text = "Wiek";
            // 
            // EKImieBox
            // 
            this.EKImieBox.Location = new System.Drawing.Point(43, 70);
            this.EKImieBox.Name = "EKImieBox";
            this.EKImieBox.Size = new System.Drawing.Size(197, 20);
            this.EKImieBox.TabIndex = 4;
            // 
            // EKNazwiskoBox
            // 
            this.EKNazwiskoBox.Location = new System.Drawing.Point(283, 70);
            this.EKNazwiskoBox.Name = "EKNazwiskoBox";
            this.EKNazwiskoBox.Size = new System.Drawing.Size(197, 20);
            this.EKNazwiskoBox.TabIndex = 5;
            // 
            // EKWiekNum
            // 
            this.EKWiekNum.Location = new System.Drawing.Point(283, 272);
            this.EKWiekNum.Name = "EKWiekNum";
            this.EKWiekNum.Size = new System.Drawing.Size(197, 20);
            this.EKWiekNum.TabIndex = 7;
            // 
            // EKOk
            // 
            this.EKOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EKOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKOk.Location = new System.Drawing.Point(666, 380);
            this.EKOk.Name = "EKOk";
            this.EKOk.Size = new System.Drawing.Size(91, 43);
            this.EKOk.TabIndex = 8;
            this.EKOk.Text = "OK";
            this.EKOk.UseVisualStyleBackColor = false;
            // 
            // strzelnicaDS
            // 
            this.strzelnicaDS.DataSetName = "StrzelnicaDS";
            this.strzelnicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kLIENCIBindingSource
            // 
            this.kLIENCIBindingSource.DataMember = "KLIENCI";
            this.kLIENCIBindingSource.DataSource = this.strzelnicaDS;
            // 
            // kLIENCITableAdapter
            // 
            this.kLIENCITableAdapter.ClearBeforeFill = true;
            // 
            // EKKarnetGrid
            // 
            this.EKKarnetGrid.AllowUserToAddRows = false;
            this.EKKarnetGrid.AllowUserToDeleteRows = false;
            this.EKKarnetGrid.AutoGenerateColumns = false;
            this.EKKarnetGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EKKarnetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EKKarnetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rODZAJKARNETUDataGridViewTextBoxColumn,
            this.dATAWAZNOSCIDataGridViewTextBoxColumn});
            this.EKKarnetGrid.DataSource = this.kARNETYBindingSource;
            this.EKKarnetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EKKarnetGrid.Location = new System.Drawing.Point(43, 272);
            this.EKKarnetGrid.Name = "EKKarnetGrid";
            this.EKKarnetGrid.ReadOnly = true;
            this.EKKarnetGrid.Size = new System.Drawing.Size(234, 151);
            this.EKKarnetGrid.TabIndex = 9;
            // 
            // kARNETYBindingSource
            // 
            this.kARNETYBindingSource.DataMember = "KARNETY";
            this.kARNETYBindingSource.DataSource = this.strzelnicaDS;
            // 
            // kARNETYTableAdapter
            // 
            this.kARNETYTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 30.45685F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rODZAJKARNETUDataGridViewTextBoxColumn
            // 
            this.rODZAJKARNETUDataGridViewTextBoxColumn.DataPropertyName = "RODZAJ_KARNETU";
            this.rODZAJKARNETUDataGridViewTextBoxColumn.FillWeight = 134.7716F;
            this.rODZAJKARNETUDataGridViewTextBoxColumn.HeaderText = "RODZAJ_KARNETU";
            this.rODZAJKARNETUDataGridViewTextBoxColumn.Name = "rODZAJKARNETUDataGridViewTextBoxColumn";
            this.rODZAJKARNETUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAWAZNOSCIDataGridViewTextBoxColumn
            // 
            this.dATAWAZNOSCIDataGridViewTextBoxColumn.DataPropertyName = "DATA_WAZNOSCI";
            this.dATAWAZNOSCIDataGridViewTextBoxColumn.FillWeight = 134.7716F;
            this.dATAWAZNOSCIDataGridViewTextBoxColumn.HeaderText = "DATA_WAZNOSCI";
            this.dATAWAZNOSCIDataGridViewTextBoxColumn.Name = "dATAWAZNOSCIDataGridViewTextBoxColumn";
            this.dATAWAZNOSCIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EdytKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytKlient";
            this.Text = "Edytuj Klienta";
            this.Load += new System.EventHandler(this.EdytKlient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKWiekNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EKKarnetGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARNETYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EKImieLabel;
        private System.Windows.Forms.Label EKNazwiskoLabel;
        private System.Windows.Forms.Label EKKarnetLabel;
        private System.Windows.Forms.Label EKWiekLabel;
        private System.Windows.Forms.TextBox EKImieBox;
        private System.Windows.Forms.TextBox EKNazwiskoBox;
        private System.Windows.Forms.NumericUpDown EKWiekNum;
        private System.Windows.Forms.Button EKOk;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource kLIENCIBindingSource;
        private StrzelnicaDSTableAdapters.KLIENCITableAdapter kLIENCITableAdapter;
        private System.Windows.Forms.DataGridView EKKarnetGrid;
        private System.Windows.Forms.BindingSource kARNETYBindingSource;
        private StrzelnicaDSTableAdapters.KARNETYTableAdapter kARNETYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rODZAJKARNETUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAWAZNOSCIDataGridViewTextBoxColumn;
    }
}