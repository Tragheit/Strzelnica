namespace Strzelnica
{
    partial class NewKlient
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NKImieLabel = new System.Windows.Forms.Label();
            this.NKNazwiskoLabel = new System.Windows.Forms.Label();
            this.NKWiekLabel = new System.Windows.Forms.Label();
            this.NKImieText = new System.Windows.Forms.TextBox();
            this.NKNazwiskoText = new System.Windows.Forms.TextBox();
            this.NKOk = new System.Windows.Forms.Button();
            this.NKCheckBox = new System.Windows.Forms.CheckBox();
            this.NKWiekNum = new System.Windows.Forms.NumericUpDown();
            this.klienciTableAdapter1 = new StrzelnicaDSTableAdapters.KLIENCITableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NKWiekNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.NKImieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NKNazwiskoLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NKWiekLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NKImieText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NKNazwiskoText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NKOk, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.NKCheckBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.NKWiekNum, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NKImieLabel
            // 
            this.NKImieLabel.AutoSize = true;
            this.NKImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKImieLabel.Location = new System.Drawing.Point(20, 15);
            this.NKImieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKImieLabel.Name = "NKImieLabel";
            this.NKImieLabel.Size = new System.Drawing.Size(39, 20);
            this.NKImieLabel.TabIndex = 0;
            this.NKImieLabel.Text = "Imię";
            // 
            // NKNazwiskoLabel
            // 
            this.NKNazwiskoLabel.AutoSize = true;
            this.NKNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKNazwiskoLabel.Location = new System.Drawing.Point(20, 69);
            this.NKNazwiskoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKNazwiskoLabel.Name = "NKNazwiskoLabel";
            this.NKNazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.NKNazwiskoLabel.TabIndex = 1;
            this.NKNazwiskoLabel.Text = "Nazwisko";
            // 
            // NKWiekLabel
            // 
            this.NKWiekLabel.AutoSize = true;
            this.NKWiekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKWiekLabel.Location = new System.Drawing.Point(20, 123);
            this.NKWiekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NKWiekLabel.Name = "NKWiekLabel";
            this.NKWiekLabel.Size = new System.Drawing.Size(44, 20);
            this.NKWiekLabel.TabIndex = 2;
            this.NKWiekLabel.Text = "Wiek";
            // 
            // NKImieText
            // 
            this.NKImieText.Location = new System.Drawing.Point(151, 17);
            this.NKImieText.Margin = new System.Windows.Forms.Padding(2);
            this.NKImieText.Name = "NKImieText";
            this.NKImieText.Size = new System.Drawing.Size(146, 20);
            this.NKImieText.TabIndex = 6;
            // 
            // NKNazwiskoText
            // 
            this.NKNazwiskoText.Location = new System.Drawing.Point(151, 71);
            this.NKNazwiskoText.Margin = new System.Windows.Forms.Padding(2);
            this.NKNazwiskoText.Name = "NKNazwiskoText";
            this.NKNazwiskoText.Size = new System.Drawing.Size(146, 20);
            this.NKNazwiskoText.TabIndex = 7;
            // 
            // NKOk
            // 
            this.NKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NKOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKOk.Location = new System.Drawing.Point(301, 233);
            this.NKOk.Margin = new System.Windows.Forms.Padding(2);
            this.NKOk.Name = "NKOk";
            this.NKOk.Size = new System.Drawing.Size(52, 37);
            this.NKOk.TabIndex = 5;
            this.NKOk.Text = "OK";
            this.NKOk.UseVisualStyleBackColor = false;
            this.NKOk.Click += new System.EventHandler(this.insertNewKlient);
            // 
            // NKCheckBox
            // 
            this.NKCheckBox.AutoSize = true;
            this.NKCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKCheckBox.Location = new System.Drawing.Point(20, 233);
            this.NKCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.NKCheckBox.Name = "NKCheckBox";
            this.NKCheckBox.Size = new System.Drawing.Size(115, 24);
            this.NKCheckBox.TabIndex = 4;
            this.NKCheckBox.Text = "Nowy karnet";
            this.NKCheckBox.UseVisualStyleBackColor = true;
            this.NKCheckBox.Visible = false;
            this.NKCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NKWiekNum
            // 
            this.NKWiekNum.Location = new System.Drawing.Point(152, 126);
            this.NKWiekNum.Name = "NKWiekNum";
            this.NKWiekNum.Size = new System.Drawing.Size(120, 20);
            this.NKWiekNum.TabIndex = 8;
            // 
            // klienciTableAdapter1
            // 
            this.klienciTableAdapter1.ClearBeforeFill = true;
            // 
            // NewKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewKlient";
            this.Text = "Dodaj Klienta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NKWiekNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NKImieLabel;
        private System.Windows.Forms.Label NKNazwiskoLabel;
        private System.Windows.Forms.Label NKWiekLabel;
        private System.Windows.Forms.CheckBox NKCheckBox;
        private System.Windows.Forms.Button NKOk;
        private System.Windows.Forms.TextBox NKImieText;
        private System.Windows.Forms.TextBox NKNazwiskoText;
        private System.Windows.Forms.NumericUpDown NKWiekNum;
        private StrzelnicaDSTableAdapters.KLIENCITableAdapter klienciTableAdapter1;
    }
}