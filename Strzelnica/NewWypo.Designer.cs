namespace Strzelnica
{
    partial class NewWypo
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
            this.NWKlieLabel = new System.Windows.Forms.Label();
            this.NWTrenLabel = new System.Windows.Forms.Label();
            this.NWStanoLabel = new System.Windows.Forms.Label();
            this.NWBronLabel = new System.Windows.Forms.Label();
            this.NWAmuLabel = new System.Windows.Forms.Label();
            this.NDDatPoczLabel = new System.Windows.Forms.Label();
            this.NWKlieGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLIENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strzelnicaDS = new StrzelnicaDS();
            this.NWTreGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMIEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWISKODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRENERZYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NWStaGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAWYNAJMUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTANOWISKABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NWBroGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMUNICJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRONIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NWOk = new System.Windows.Forms.Button();
            this.NWDatKonLabel = new System.Windows.Forms.Label();
            this.NWDatPoczPick = new System.Windows.Forms.DateTimePicker();
            this.NWDatKonPick = new System.Windows.Forms.DateTimePicker();
            this.NWAmoNum = new System.Windows.Forms.NumericUpDown();
            this.kLIENCITableAdapter = new StrzelnicaDSTableAdapters.KLIENCITableAdapter();
            this.tRENERZYTableAdapter = new StrzelnicaDSTableAdapters.TRENERZYTableAdapter();
            this.sTANOWISKATableAdapter = new StrzelnicaDSTableAdapters.STANOWISKATableAdapter();
            this.bRONIETableAdapter = new StrzelnicaDSTableAdapters.BRONIETableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NWKlieGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWTreGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENERZYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWStaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANOWISKABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWBroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWAmoNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.21359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.443954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.NWKlieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NWTrenLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NWStanoLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NWBronLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NWAmuLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NDDatPoczLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.NWKlieGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NWTreGrid, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NWStaGrid, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.NWBroGrid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NWOk, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.NWDatKonLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.NWDatPoczPick, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.NWDatKonPick, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.NWAmoNum, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.560371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.643963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.417957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.82972F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.049536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.037152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 646);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NWKlieLabel
            // 
            this.NWKlieLabel.AutoSize = true;
            this.NWKlieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWKlieLabel.Location = new System.Drawing.Point(59, 23);
            this.NWKlieLabel.Name = "NWKlieLabel";
            this.NWKlieLabel.Size = new System.Drawing.Size(48, 20);
            this.NWKlieLabel.TabIndex = 1;
            this.NWKlieLabel.Text = "Klient";
            // 
            // NWTrenLabel
            // 
            this.NWTrenLabel.AutoSize = true;
            this.NWTrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWTrenLabel.Location = new System.Drawing.Point(342, 23);
            this.NWTrenLabel.Name = "NWTrenLabel";
            this.NWTrenLabel.Size = new System.Drawing.Size(55, 20);
            this.NWTrenLabel.TabIndex = 0;
            this.NWTrenLabel.Text = "Trener";
            this.NWTrenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NWStanoLabel
            // 
            this.NWStanoLabel.AutoSize = true;
            this.NWStanoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWStanoLabel.Location = new System.Drawing.Point(639, 23);
            this.NWStanoLabel.Name = "NWStanoLabel";
            this.NWStanoLabel.Size = new System.Drawing.Size(91, 20);
            this.NWStanoLabel.TabIndex = 2;
            this.NWStanoLabel.Text = "Stanowisko";
            // 
            // NWBronLabel
            // 
            this.NWBronLabel.AutoSize = true;
            this.NWBronLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWBronLabel.Location = new System.Drawing.Point(59, 257);
            this.NWBronLabel.Name = "NWBronLabel";
            this.NWBronLabel.Size = new System.Drawing.Size(43, 20);
            this.NWBronLabel.TabIndex = 3;
            this.NWBronLabel.Text = "Broń";
            // 
            // NWAmuLabel
            // 
            this.NWAmuLabel.AutoSize = true;
            this.NWAmuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWAmuLabel.Location = new System.Drawing.Point(342, 257);
            this.NWAmuLabel.Name = "NWAmuLabel";
            this.NWAmuLabel.Size = new System.Drawing.Size(105, 20);
            this.NWAmuLabel.TabIndex = 4;
            this.NWAmuLabel.Text = "Ilość Amunicji";
            // 
            // NDDatPoczLabel
            // 
            this.NDDatPoczLabel.AutoSize = true;
            this.NDDatPoczLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NDDatPoczLabel.Location = new System.Drawing.Point(59, 517);
            this.NDDatPoczLabel.Name = "NDDatPoczLabel";
            this.NDDatPoczLabel.Size = new System.Drawing.Size(75, 20);
            this.NDDatPoczLabel.TabIndex = 6;
            this.NDDatPoczLabel.Text = "Początek";
            // 
            // NWKlieGrid
            // 
            this.NWKlieGrid.AllowUserToAddRows = false;
            this.NWKlieGrid.AllowUserToDeleteRows = false;
            this.NWKlieGrid.AutoGenerateColumns = false;
            this.NWKlieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NWKlieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NWKlieGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iMIEDataGridViewTextBoxColumn,
            this.nAZWISKODataGridViewTextBoxColumn});
            this.NWKlieGrid.DataSource = this.kLIENCIBindingSource;
            this.NWKlieGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NWKlieGrid.Location = new System.Drawing.Point(59, 56);
            this.NWKlieGrid.Name = "NWKlieGrid";
            this.NWKlieGrid.ReadOnly = true;
            this.NWKlieGrid.Size = new System.Drawing.Size(277, 198);
            this.NWKlieGrid.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // iMIEDataGridViewTextBoxColumn
            // 
            this.iMIEDataGridViewTextBoxColumn.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn.Name = "iMIEDataGridViewTextBoxColumn";
            this.iMIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn
            // 
            this.nAZWISKODataGridViewTextBoxColumn.DataPropertyName = "NAZWISKO";
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
            // NWTreGrid
            // 
            this.NWTreGrid.AllowUserToAddRows = false;
            this.NWTreGrid.AllowUserToDeleteRows = false;
            this.NWTreGrid.AutoGenerateColumns = false;
            this.NWTreGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NWTreGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NWTreGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iMIEDataGridViewTextBoxColumn1,
            this.nAZWISKODataGridViewTextBoxColumn1});
            this.NWTreGrid.DataSource = this.tRENERZYBindingSource;
            this.NWTreGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NWTreGrid.Location = new System.Drawing.Point(342, 56);
            this.NWTreGrid.Name = "NWTreGrid";
            this.NWTreGrid.ReadOnly = true;
            this.NWTreGrid.Size = new System.Drawing.Size(291, 198);
            this.NWTreGrid.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMIEDataGridViewTextBoxColumn1
            // 
            this.iMIEDataGridViewTextBoxColumn1.DataPropertyName = "IMIE";
            this.iMIEDataGridViewTextBoxColumn1.HeaderText = "IMIE";
            this.iMIEDataGridViewTextBoxColumn1.Name = "iMIEDataGridViewTextBoxColumn1";
            this.iMIEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nAZWISKODataGridViewTextBoxColumn1
            // 
            this.nAZWISKODataGridViewTextBoxColumn1.DataPropertyName = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn1.HeaderText = "NAZWISKO";
            this.nAZWISKODataGridViewTextBoxColumn1.Name = "nAZWISKODataGridViewTextBoxColumn1";
            this.nAZWISKODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tRENERZYBindingSource
            // 
            this.tRENERZYBindingSource.DataMember = "TRENERZY";
            this.tRENERZYBindingSource.DataSource = this.strzelnicaDS;
            // 
            // NWStaGrid
            // 
            this.NWStaGrid.AllowUserToAddRows = false;
            this.NWStaGrid.AllowUserToDeleteRows = false;
            this.NWStaGrid.AutoGenerateColumns = false;
            this.NWStaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NWStaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NWStaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn,
            this.cENAWYNAJMUDataGridViewTextBoxColumn});
            this.NWStaGrid.DataSource = this.sTANOWISKABindingSource;
            this.NWStaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NWStaGrid.Location = new System.Drawing.Point(639, 56);
            this.NWStaGrid.Name = "NWStaGrid";
            this.NWStaGrid.ReadOnly = true;
            this.NWStaGrid.Size = new System.Drawing.Size(324, 198);
            this.NWStaGrid.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oDLEGLOSCODCELUDataGridViewTextBoxColumn
            // 
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn.DataPropertyName = "ODLEGLOSC_OD_CELU";
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn.HeaderText = "ODLEGLOSC_OD_CELU";
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn.Name = "oDLEGLOSCODCELUDataGridViewTextBoxColumn";
            this.oDLEGLOSCODCELUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENAWYNAJMUDataGridViewTextBoxColumn
            // 
            this.cENAWYNAJMUDataGridViewTextBoxColumn.DataPropertyName = "CENA_WYNAJMU";
            this.cENAWYNAJMUDataGridViewTextBoxColumn.HeaderText = "CENA_WYNAJMU";
            this.cENAWYNAJMUDataGridViewTextBoxColumn.Name = "cENAWYNAJMUDataGridViewTextBoxColumn";
            this.cENAWYNAJMUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTANOWISKABindingSource
            // 
            this.sTANOWISKABindingSource.DataMember = "STANOWISKA";
            this.sTANOWISKABindingSource.DataSource = this.strzelnicaDS;
            // 
            // NWBroGrid
            // 
            this.NWBroGrid.AllowUserToAddRows = false;
            this.NWBroGrid.AllowUserToDeleteRows = false;
            this.NWBroGrid.AutoGenerateColumns = false;
            this.NWBroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NWBroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NWBroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.pRODUCENTDataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.tYPDataGridViewTextBoxColumn,
            this.AMUNICJA,
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.NWBroGrid, 2);
            this.NWBroGrid.DataSource = this.bRONIEBindingSource;
            this.NWBroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NWBroGrid.Location = new System.Drawing.Point(59, 295);
            this.NWBroGrid.Name = "NWBroGrid";
            this.NWBroGrid.ReadOnly = true;
            this.NWBroGrid.Size = new System.Drawing.Size(574, 219);
            this.NWBroGrid.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pRODUCENTDataGridViewTextBoxColumn
            // 
            this.pRODUCENTDataGridViewTextBoxColumn.DataPropertyName = "PRODUCENT";
            this.pRODUCENTDataGridViewTextBoxColumn.HeaderText = "PRODUCENT";
            this.pRODUCENTDataGridViewTextBoxColumn.Name = "pRODUCENTDataGridViewTextBoxColumn";
            this.pRODUCENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            this.mODELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPDataGridViewTextBoxColumn
            // 
            this.tYPDataGridViewTextBoxColumn.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn.Name = "tYPDataGridViewTextBoxColumn";
            this.tYPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AMUNICJA
            // 
            this.AMUNICJA.DataPropertyName = "AMUNICJA";
            this.AMUNICJA.HeaderText = "AMUNICJA";
            this.AMUNICJA.Name = "AMUNICJA";
            this.AMUNICJA.ReadOnly = true;
            // 
            // cENAWYPOZYCZENIADataGridViewTextBoxColumn
            // 
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn.DataPropertyName = "CENA_WYPOZYCZENIA";
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn.HeaderText = "CENA_WYPOZYCZENIA";
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn.Name = "cENAWYPOZYCZENIADataGridViewTextBoxColumn";
            this.cENAWYPOZYCZENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRONIEBindingSource
            // 
            this.bRONIEBindingSource.DataMember = "BRONIE";
            this.bRONIEBindingSource.DataSource = this.strzelnicaDS;
            // 
            // NWOk
            // 
            this.NWOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NWOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWOk.Location = new System.Drawing.Point(969, 572);
            this.NWOk.Name = "NWOk";
            this.NWOk.Size = new System.Drawing.Size(100, 33);
            this.NWOk.TabIndex = 14;
            this.NWOk.Text = "OK";
            this.NWOk.UseVisualStyleBackColor = false;
            // 
            // NWDatKonLabel
            // 
            this.NWDatKonLabel.AutoSize = true;
            this.NWDatKonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NWDatKonLabel.Location = new System.Drawing.Point(342, 517);
            this.NWDatKonLabel.Name = "NWDatKonLabel";
            this.NWDatKonLabel.Size = new System.Drawing.Size(57, 20);
            this.NWDatKonLabel.TabIndex = 5;
            this.NWDatKonLabel.Text = "Koniec";
            // 
            // NWDatPoczPick
            // 
            this.NWDatPoczPick.Location = new System.Drawing.Point(59, 572);
            this.NWDatPoczPick.Name = "NWDatPoczPick";
            this.NWDatPoczPick.Size = new System.Drawing.Size(194, 20);
            this.NWDatPoczPick.TabIndex = 15;
            // 
            // NWDatKonPick
            // 
            this.NWDatKonPick.Location = new System.Drawing.Point(342, 572);
            this.NWDatKonPick.Name = "NWDatKonPick";
            this.NWDatKonPick.Size = new System.Drawing.Size(194, 20);
            this.NWDatKonPick.TabIndex = 16;
            // 
            // NWAmoNum
            // 
            this.NWAmoNum.Location = new System.Drawing.Point(639, 295);
            this.NWAmoNum.Name = "NWAmoNum";
            this.NWAmoNum.Size = new System.Drawing.Size(255, 20);
            this.NWAmoNum.TabIndex = 17;
            this.NWAmoNum.ValueChanged += new System.EventHandler(this.NWAmoNum_ValueChanged);
            // 
            // kLIENCITableAdapter
            // 
            this.kLIENCITableAdapter.ClearBeforeFill = true;
            // 
            // tRENERZYTableAdapter
            // 
            this.tRENERZYTableAdapter.ClearBeforeFill = true;
            // 
            // sTANOWISKATableAdapter
            // 
            this.sTANOWISKATableAdapter.ClearBeforeFill = true;
            // 
            // bRONIETableAdapter
            // 
            this.bRONIETableAdapter.ClearBeforeFill = true;
            // 
            // NewWypo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 646);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewWypo";
            this.Text = "Dodaj Wypożyczenie";
            this.Load += new System.EventHandler(this.NewWypo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NWKlieGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzelnicaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWTreGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRENERZYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWStaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTANOWISKABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWBroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRONIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWAmoNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NWTrenLabel;
        private System.Windows.Forms.Label NWKlieLabel;
        private System.Windows.Forms.Label NWStanoLabel;
        private System.Windows.Forms.Label NWBronLabel;
        private System.Windows.Forms.Label NWAmuLabel;
        private System.Windows.Forms.Label NWDatKonLabel;
        private System.Windows.Forms.Label NDDatPoczLabel;
        private System.Windows.Forms.DataGridView NWKlieGrid;
        private System.Windows.Forms.DataGridView NWTreGrid;
        private System.Windows.Forms.DataGridView NWStaGrid;
        private System.Windows.Forms.DataGridView NWBroGrid;
        private System.Windows.Forms.Button NWOk;
        private System.Windows.Forms.DateTimePicker NWDatPoczPick;
        private System.Windows.Forms.DateTimePicker NWDatKonPick;
        private System.Windows.Forms.NumericUpDown NWAmoNum;
        private StrzelnicaDS strzelnicaDS;
        private System.Windows.Forms.BindingSource kLIENCIBindingSource;
        private StrzelnicaDSTableAdapters.KLIENCITableAdapter kLIENCITableAdapter;
        private System.Windows.Forms.BindingSource tRENERZYBindingSource;
        private StrzelnicaDSTableAdapters.TRENERZYTableAdapter tRENERZYTableAdapter;
        private System.Windows.Forms.BindingSource sTANOWISKABindingSource;
        private StrzelnicaDSTableAdapters.STANOWISKATableAdapter sTANOWISKATableAdapter;
        private System.Windows.Forms.BindingSource bRONIEBindingSource;
        private StrzelnicaDSTableAdapters.BRONIETableAdapter bRONIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDLEGLOSCODCELUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAWYNAJMUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMUNICJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAWYPOZYCZENIADataGridViewTextBoxColumn;
    }
}