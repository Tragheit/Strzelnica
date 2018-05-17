namespace Strzelnica
{
    partial class NewStan
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
            this.NSKulLabel = new System.Windows.Forms.Label();
            this.NSOdlegLabel = new System.Windows.Forms.Label();
            this.NSCenaLabel = new System.Windows.Forms.Label();
            this.NSStanowGrid = new System.Windows.Forms.DataGridView();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOZYCJADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILNOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kULOCHWYTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strzelnicaDS = new StrzelnicaDS();
            this.NSOk = new System.Windows.Forms.Button();
            this.NSOdlegNum = new System.Windows.Forms.NumericUpDown();
            this.NSCenaNum = new System.Windows.Forms.NumericUpDown();
            this.kULOCHWYTTableAdapter = new StrzelnicaDSTableAdapters.KULOCHWYTTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSStanowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kULOCHWYTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSOdlegNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSCenaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.NSKulLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NSOdlegLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NSCenaLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NSStanowGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NSOk, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.NSOdlegNum, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NSCenaNum, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NSKulLabel
            // 
            this.NSKulLabel.AutoSize = true;
            this.NSKulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NSKulLabel.Location = new System.Drawing.Point(45, 18);
            this.NSKulLabel.Name = "NSKulLabel";
            this.NSKulLabel.Size = new System.Drawing.Size(80, 20);
            this.NSKulLabel.TabIndex = 0;
            this.NSKulLabel.Text = "Kulochwyt";
            // 
            // NSOdlegLabel
            // 
            this.NSOdlegLabel.AutoSize = true;
            this.NSOdlegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NSOdlegLabel.Location = new System.Drawing.Point(45, 145);
            this.NSOdlegLabel.Name = "NSOdlegLabel";
            this.NSOdlegLabel.Size = new System.Drawing.Size(152, 20);
            this.NSOdlegLabel.TabIndex = 1;
            this.NSOdlegLabel.Text = "Odległość od Tarczy";
            // 
            // NSCenaLabel
            // 
            this.NSCenaLabel.AutoSize = true;
            this.NSCenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NSCenaLabel.Location = new System.Drawing.Point(45, 272);
            this.NSCenaLabel.Name = "NSCenaLabel";
            this.NSCenaLabel.Size = new System.Drawing.Size(152, 20);
            this.NSCenaLabel.TabIndex = 2;
            this.NSCenaLabel.Text = "Cena Wypożyczenia";
            // 
            // NSStanowGrid
            // 
            this.NSStanowGrid.AllowUserToAddRows = false;
            this.NSStanowGrid.AllowUserToDeleteRows = false;
            this.NSStanowGrid.AutoGenerateColumns = false;
            this.NSStanowGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NSStanowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NSStanowGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAZWADataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.pOZYCJADataGridViewTextBoxColumn,
            this.mOBILNOSCDataGridViewTextBoxColumn});
            this.NSStanowGrid.DataSource = this.kULOCHWYTBindingSource;
            this.NSStanowGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSStanowGrid.Location = new System.Drawing.Point(255, 21);
            this.NSStanowGrid.Name = "NSStanowGrid";
            this.NSStanowGrid.ReadOnly = true;
            this.NSStanowGrid.Size = new System.Drawing.Size(453, 121);
            this.NSStanowGrid.TabIndex = 3;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            this.mATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOZYCJADataGridViewTextBoxColumn
            // 
            this.pOZYCJADataGridViewTextBoxColumn.DataPropertyName = "POZYCJA";
            this.pOZYCJADataGridViewTextBoxColumn.HeaderText = "POZYCJA";
            this.pOZYCJADataGridViewTextBoxColumn.Name = "pOZYCJADataGridViewTextBoxColumn";
            this.pOZYCJADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOBILNOSCDataGridViewTextBoxColumn
            // 
            this.mOBILNOSCDataGridViewTextBoxColumn.DataPropertyName = "MOBILNOSC";
            this.mOBILNOSCDataGridViewTextBoxColumn.HeaderText = "MOBILNOSC";
            this.mOBILNOSCDataGridViewTextBoxColumn.Name = "mOBILNOSCDataGridViewTextBoxColumn";
            this.mOBILNOSCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kULOCHWYTBindingSource
            // 
            this.kULOCHWYTBindingSource.DataMember = "KULOCHWYT";
            this.kULOCHWYTBindingSource.DataSource = this.strzelnicaDS;
            // 
            // strzelnicaDS
            // 
            this.strzelnicaDS.DataSetName = "StrzelnicaDS";
            this.strzelnicaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NSOk
            // 
            this.NSOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NSOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NSOk.Location = new System.Drawing.Point(714, 275);
            this.NSOk.Name = "NSOk";
            this.NSOk.Size = new System.Drawing.Size(82, 42);
            this.NSOk.TabIndex = 6;
            this.NSOk.Text = "OK";
            this.NSOk.UseVisualStyleBackColor = false;
            this.NSOk.Click += new System.EventHandler(this.NSOk_Click);
            // 
            // NSOdlegNum
            // 
            this.NSOdlegNum.Location = new System.Drawing.Point(255, 148);
            this.NSOdlegNum.Name = "NSOdlegNum";
            this.NSOdlegNum.Size = new System.Drawing.Size(192, 20);
            this.NSOdlegNum.TabIndex = 7;
            // 
            // NSCenaNum
            // 
            this.NSCenaNum.Location = new System.Drawing.Point(255, 275);
            this.NSCenaNum.Name = "NSCenaNum";
            this.NSCenaNum.Size = new System.Drawing.Size(192, 20);
            this.NSCenaNum.TabIndex = 8;
            // 
            // kULOCHWYTTableAdapter
            // 
            this.kULOCHWYTTableAdapter.ClearBeforeFill = true;
            // 
            // NewStan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewStan";
            this.Text = "NewStan";
            this.Load += new System.EventHandler(this.NewStan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSStanowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kULOCHWYTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSOdlegNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSCenaNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NSKulLabel;
        private System.Windows.Forms.Label NSOdlegLabel;
        private System.Windows.Forms.Label NSCenaLabel;
        private System.Windows.Forms.DataGridView NSStanowGrid;
        private System.Windows.Forms.Button NSOk;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource kULOCHWYTBindingSource;
        private StrzelnicaDSTableAdapters.KULOCHWYTTableAdapter kULOCHWYTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOZYCJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILNOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown NSOdlegNum;
        private System.Windows.Forms.NumericUpDown NSCenaNum;
    }
}