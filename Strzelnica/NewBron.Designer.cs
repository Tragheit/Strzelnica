namespace Strzelnica
{
    partial class NewBron
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
            this.NBProdLabel = new System.Windows.Forms.Label();
            this.NBModLabel = new System.Windows.Forms.Label();
            this.NBTypLabel = new System.Windows.Forms.Label();
            this.NBAmuLabel = new System.Windows.Forms.Label();
            this.NBCenaLabel = new System.Windows.Forms.Label();
            this.NBProdText = new System.Windows.Forms.TextBox();
            this.NBModText = new System.Windows.Forms.TextBox();
            this.NBTypGrid = new System.Windows.Forms.DataGridView();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRONIETYPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strzelnicaDS = new StrzelnicaDS();
            this.NBAmuGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kALIBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMUNICJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NBOk = new System.Windows.Forms.Button();
            this.NBCenaNum = new System.Windows.Forms.NumericUpDown();
            this.bRONIE_TYPTableAdapter = new StrzelnicaDSTableAdapters.BRONIE_TYPTableAdapter();
            this.aMUNICJATableAdapter = new StrzelnicaDSTableAdapters.AMUNICJATableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBTypGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBAmuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCenaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.NBProdLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NBModLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NBTypLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NBAmuLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NBCenaLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.NBProdText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NBModText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NBTypGrid, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NBAmuGrid, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.NBOk, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.NBCenaNum, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NBProdLabel
            // 
            this.NBProdLabel.AutoSize = true;
            this.NBProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBProdLabel.Location = new System.Drawing.Point(43, 18);
            this.NBProdLabel.Name = "NBProdLabel";
            this.NBProdLabel.Size = new System.Drawing.Size(82, 20);
            this.NBProdLabel.TabIndex = 0;
            this.NBProdLabel.Text = "Producent";
            // 
            // NBModLabel
            // 
            this.NBModLabel.AutoSize = true;
            this.NBModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBModLabel.Location = new System.Drawing.Point(43, 55);
            this.NBModLabel.Name = "NBModLabel";
            this.NBModLabel.Size = new System.Drawing.Size(52, 20);
            this.NBModLabel.TabIndex = 1;
            this.NBModLabel.Text = "Model";
            // 
            // NBTypLabel
            // 
            this.NBTypLabel.AutoSize = true;
            this.NBTypLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBTypLabel.Location = new System.Drawing.Point(43, 92);
            this.NBTypLabel.Name = "NBTypLabel";
            this.NBTypLabel.Size = new System.Drawing.Size(34, 20);
            this.NBTypLabel.TabIndex = 2;
            this.NBTypLabel.Text = "Typ";
            // 
            // NBAmuLabel
            // 
            this.NBAmuLabel.AutoSize = true;
            this.NBAmuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBAmuLabel.Location = new System.Drawing.Point(43, 202);
            this.NBAmuLabel.Name = "NBAmuLabel";
            this.NBAmuLabel.Size = new System.Drawing.Size(74, 20);
            this.NBAmuLabel.TabIndex = 3;
            this.NBAmuLabel.Text = "Amunicja";
            // 
            // NBCenaLabel
            // 
            this.NBCenaLabel.AutoSize = true;
            this.NBCenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBCenaLabel.Location = new System.Drawing.Point(43, 391);
            this.NBCenaLabel.Name = "NBCenaLabel";
            this.NBCenaLabel.Size = new System.Drawing.Size(47, 20);
            this.NBCenaLabel.TabIndex = 4;
            this.NBCenaLabel.Text = "Cena";
            // 
            // NBProdText
            // 
            this.NBProdText.Location = new System.Drawing.Point(323, 21);
            this.NBProdText.Name = "NBProdText";
            this.NBProdText.Size = new System.Drawing.Size(180, 20);
            this.NBProdText.TabIndex = 5;
            // 
            // NBModText
            // 
            this.NBModText.Location = new System.Drawing.Point(323, 58);
            this.NBModText.Name = "NBModText";
            this.NBModText.Size = new System.Drawing.Size(180, 20);
            this.NBModText.TabIndex = 6;
            // 
            // NBTypGrid
            // 
            this.NBTypGrid.AllowUserToAddRows = false;
            this.NBTypGrid.AllowUserToDeleteRows = false;
            this.NBTypGrid.AutoGenerateColumns = false;
            this.NBTypGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NBTypGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBTypGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAZWADataGridViewTextBoxColumn});
            this.NBTypGrid.DataSource = this.bRONIETYPBindingSource;
            this.NBTypGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NBTypGrid.Location = new System.Drawing.Point(323, 95);
            this.NBTypGrid.Name = "NBTypGrid";
            this.NBTypGrid.ReadOnly = true;
            this.NBTypGrid.Size = new System.Drawing.Size(339, 104);
            this.NBTypGrid.TabIndex = 8;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
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
            // NBAmuGrid
            // 
            this.NBAmuGrid.AllowUserToAddRows = false;
            this.NBAmuGrid.AllowUserToDeleteRows = false;
            this.NBAmuGrid.AutoGenerateColumns = false;
            this.NBAmuGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NBAmuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBAmuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.kALIBERDataGridViewTextBoxColumn});
            this.NBAmuGrid.DataSource = this.aMUNICJABindingSource;
            this.NBAmuGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NBAmuGrid.Location = new System.Drawing.Point(323, 205);
            this.NBAmuGrid.Name = "NBAmuGrid";
            this.NBAmuGrid.ReadOnly = true;
            this.NBAmuGrid.Size = new System.Drawing.Size(339, 183);
            this.NBAmuGrid.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50.76142F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // kALIBERDataGridViewTextBoxColumn
            // 
            this.kALIBERDataGridViewTextBoxColumn.DataPropertyName = "KALIBER";
            this.kALIBERDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.kALIBERDataGridViewTextBoxColumn.HeaderText = "KALIBER";
            this.kALIBERDataGridViewTextBoxColumn.Name = "kALIBERDataGridViewTextBoxColumn";
            this.kALIBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aMUNICJABindingSource
            // 
            this.aMUNICJABindingSource.DataMember = "AMUNICJA";
            this.aMUNICJABindingSource.DataSource = this.strzelnicaDS;
            // 
            // NBOk
            // 
            this.NBOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NBOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NBOk.Location = new System.Drawing.Point(668, 394);
            this.NBOk.Name = "NBOk";
            this.NBOk.Size = new System.Drawing.Size(88, 31);
            this.NBOk.TabIndex = 10;
            this.NBOk.Text = "OK";
            this.NBOk.UseVisualStyleBackColor = false;
            // 
            // NBCenaNum
            // 
            this.NBCenaNum.Location = new System.Drawing.Point(323, 394);
            this.NBCenaNum.Name = "NBCenaNum";
            this.NBCenaNum.Size = new System.Drawing.Size(180, 20);
            this.NBCenaNum.TabIndex = 11;
            // 
            // bRONIE_TYPTableAdapter
            // 
            this.bRONIE_TYPTableAdapter.ClearBeforeFill = true;
            // 
            // aMUNICJATableAdapter
            // 
            this.aMUNICJATableAdapter.ClearBeforeFill = true;
            // 
            // NewBron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewBron";
            this.Text = "NewBron";
            this.Load += new System.EventHandler(this.NewBron_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBTypGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIETYPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBAmuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMUNICJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCenaNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NBProdLabel;
        private System.Windows.Forms.Label NBModLabel;
        private System.Windows.Forms.Label NBTypLabel;
        private System.Windows.Forms.Label NBAmuLabel;
        private System.Windows.Forms.Label NBCenaLabel;
        private System.Windows.Forms.TextBox NBProdText;
        private System.Windows.Forms.TextBox NBModText;
        private System.Windows.Forms.DataGridView NBTypGrid;
        private System.Windows.Forms.DataGridView NBAmuGrid;
        private System.Windows.Forms.Button NBOk;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource bRONIETYPBindingSource;
        private StrzelnicaDSTableAdapters.BRONIE_TYPTableAdapter bRONIE_TYPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aMUNICJABindingSource;
        private StrzelnicaDSTableAdapters.AMUNICJATableAdapter aMUNICJATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kALIBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown NBCenaNum;
    }
}