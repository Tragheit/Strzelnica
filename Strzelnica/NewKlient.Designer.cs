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
            this.NKCheckBox = new System.Windows.Forms.CheckBox();
            this.NKOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NKOk, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.NKCheckBox, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NKImieLabel
            // 
            this.NKImieLabel.AutoSize = true;
            this.NKImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKImieLabel.Location = new System.Drawing.Point(28, 18);
            this.NKImieLabel.Name = "NKImieLabel";
            this.NKImieLabel.Size = new System.Drawing.Size(48, 25);
            this.NKImieLabel.TabIndex = 0;
            this.NKImieLabel.Text = "Imię";
            // 
            // NKNazwiskoLabel
            // 
            this.NKNazwiskoLabel.AutoSize = true;
            this.NKNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKNazwiskoLabel.Location = new System.Drawing.Point(28, 85);
            this.NKNazwiskoLabel.Name = "NKNazwiskoLabel";
            this.NKNazwiskoLabel.Size = new System.Drawing.Size(96, 25);
            this.NKNazwiskoLabel.TabIndex = 1;
            this.NKNazwiskoLabel.Text = "Nazwisko";
            // 
            // NKWiekLabel
            // 
            this.NKWiekLabel.AutoSize = true;
            this.NKWiekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKWiekLabel.Location = new System.Drawing.Point(28, 152);
            this.NKWiekLabel.Name = "NKWiekLabel";
            this.NKWiekLabel.Size = new System.Drawing.Size(57, 25);
            this.NKWiekLabel.TabIndex = 2;
            this.NKWiekLabel.Text = "Wiek";
            this.NKWiekLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // NKCheckBox
            // 
            this.NKCheckBox.AutoSize = true;
            this.NKCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NKCheckBox.Location = new System.Drawing.Point(28, 289);
            this.NKCheckBox.Name = "NKCheckBox";
            this.NKCheckBox.Size = new System.Drawing.Size(142, 29);
            this.NKCheckBox.TabIndex = 4;
            this.NKCheckBox.Text = "Nowy karnet";
            this.NKCheckBox.UseVisualStyleBackColor = true;
            this.NKCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NKOk
            // 
            this.NKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NKOk.Location = new System.Drawing.Point(403, 289);
            this.NKOk.Name = "NKOk";
            this.NKOk.Size = new System.Drawing.Size(69, 45);
            this.NKOk.TabIndex = 5;
            this.NKOk.Text = "OK";
            this.NKOk.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 22);
            this.textBox3.TabIndex = 8;
            // 
            // NewKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewKlient";
            this.Text = "Dodaj Klienta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NKImieLabel;
        private System.Windows.Forms.Label NKNazwiskoLabel;
        private System.Windows.Forms.Label NKWiekLabel;
        private System.Windows.Forms.CheckBox NKCheckBox;
        private System.Windows.Forms.Button NKOk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}