namespace Strzelnica
{
    partial class EdytTrener
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
            this.ETOk = new System.Windows.Forms.Button();
            this.ETNazwiskoText = new System.Windows.Forms.TextBox();
            this.ETNazwiskoLabel = new System.Windows.Forms.Label();
            this.ETImieText = new System.Windows.Forms.TextBox();
            this.ETImieLabel = new System.Windows.Forms.Label();
            this.ETWybraKlie = new System.Windows.Forms.Label();
            this.ETWybNum = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETWybNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.83138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.728337F));
            this.tableLayoutPanel1.Controls.Add(this.ETOk, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.ETNazwiskoText, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ETNazwiskoLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ETImieText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ETImieLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ETWybraKlie, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ETWybNum, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.98507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.15638F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.34568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ETOk
            // 
            this.ETOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ETOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ETOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETOk.Location = new System.Drawing.Point(369, 249);
            this.ETOk.Name = "ETOk";
            this.ETOk.Size = new System.Drawing.Size(90, 42);
            this.ETOk.TabIndex = 4;
            this.ETOk.Text = "OK";
            this.ETOk.UseVisualStyleBackColor = false;
            this.ETOk.Click += new System.EventHandler(this.editTrener);
            // 
            // ETNazwiskoText
            // 
            this.ETNazwiskoText.Location = new System.Drawing.Point(32, 246);
            this.ETNazwiskoText.Name = "ETNazwiskoText";
            this.ETNazwiskoText.Size = new System.Drawing.Size(148, 20);
            this.ETNazwiskoText.TabIndex = 3;
            // 
            // ETNazwiskoLabel
            // 
            this.ETNazwiskoLabel.AutoSize = true;
            this.ETNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETNazwiskoLabel.Location = new System.Drawing.Point(32, 213);
            this.ETNazwiskoLabel.Name = "ETNazwiskoLabel";
            this.ETNazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.ETNazwiskoLabel.TabIndex = 1;
            this.ETNazwiskoLabel.Text = "Nazwisko";
            // 
            // ETImieText
            // 
            this.ETImieText.Location = new System.Drawing.Point(32, 133);
            this.ETImieText.Name = "ETImieText";
            this.ETImieText.Size = new System.Drawing.Size(148, 20);
            this.ETImieText.TabIndex = 2;
            // 
            // ETImieLabel
            // 
            this.ETImieLabel.AutoSize = true;
            this.ETImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETImieLabel.Location = new System.Drawing.Point(32, 104);
            this.ETImieLabel.Name = "ETImieLabel";
            this.ETImieLabel.Size = new System.Drawing.Size(39, 20);
            this.ETImieLabel.TabIndex = 0;
            this.ETImieLabel.Text = "Imię";
            // 
            // ETWybraKlie
            // 
            this.ETWybraKlie.AutoSize = true;
            this.ETWybraKlie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETWybraKlie.Location = new System.Drawing.Point(32, 12);
            this.ETWybraKlie.Name = "ETWybraKlie";
            this.ETWybraKlie.Size = new System.Drawing.Size(55, 20);
            this.ETWybraKlie.TabIndex = 5;
            this.ETWybraKlie.Text = "Trener";
            // 
            // ETWybNum
            // 
            this.ETWybNum.Location = new System.Drawing.Point(32, 39);
            this.ETWybNum.Name = "ETWybNum";
            this.ETWybNum.Size = new System.Drawing.Size(120, 20);
            this.ETWybNum.TabIndex = 6;
            // 
            // EdytTrener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytTrener";
            this.Text = "Edytuj Trenera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ETWybNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ETImieLabel;
        private System.Windows.Forms.Label ETNazwiskoLabel;
        private System.Windows.Forms.TextBox ETImieText;
        private System.Windows.Forms.TextBox ETNazwiskoText;
        private System.Windows.Forms.Button ETOk;
        private System.Windows.Forms.Label ETWybraKlie;
        private System.Windows.Forms.NumericUpDown ETWybNum;
    }
}