namespace Strzelnica
{
    partial class NewTrainer
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
            this.NTImieLabel = new System.Windows.Forms.Label();
            this.NTNazwiskoLabel = new System.Windows.Forms.Label();
            this.NTImieText = new System.Windows.Forms.TextBox();
            this.NTNazwiskoText = new System.Windows.Forms.TextBox();
            this.NTOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.69912F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.Controls.Add(this.NTImieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NTNazwiskoLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NTImieText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NTNazwiskoText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NTOk, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.88845F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.31873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.968128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NTImieLabel
            // 
            this.NTImieLabel.AutoSize = true;
            this.NTImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NTImieLabel.Location = new System.Drawing.Point(27, 37);
            this.NTImieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NTImieLabel.Name = "NTImieLabel";
            this.NTImieLabel.Size = new System.Drawing.Size(39, 20);
            this.NTImieLabel.TabIndex = 0;
            this.NTImieLabel.Text = "Imię";
            // 
            // NTNazwiskoLabel
            // 
            this.NTNazwiskoLabel.AutoSize = true;
            this.NTNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NTNazwiskoLabel.Location = new System.Drawing.Point(27, 111);
            this.NTNazwiskoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NTNazwiskoLabel.Name = "NTNazwiskoLabel";
            this.NTNazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.NTNazwiskoLabel.TabIndex = 1;
            this.NTNazwiskoLabel.Text = "Nazwisko";
            // 
            // NTImieText
            // 
            this.NTImieText.Location = new System.Drawing.Point(140, 39);
            this.NTImieText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NTImieText.Name = "NTImieText";
            this.NTImieText.Size = new System.Drawing.Size(189, 20);
            this.NTImieText.TabIndex = 2;
            // 
            // NTNazwiskoText
            // 
            this.NTNazwiskoText.Location = new System.Drawing.Point(140, 113);
            this.NTNazwiskoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NTNazwiskoText.Name = "NTNazwiskoText";
            this.NTNazwiskoText.Size = new System.Drawing.Size(189, 20);
            this.NTNazwiskoText.TabIndex = 3;
            // 
            // NTOk
            // 
            this.NTOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NTOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NTOk.Location = new System.Drawing.Point(333, 182);
            this.NTOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NTOk.Name = "NTOk";
            this.NTOk.Size = new System.Drawing.Size(91, 44);
            this.NTOk.TabIndex = 4;
            this.NTOk.Text = "OK";
            this.NTOk.UseVisualStyleBackColor = false;
            // 
            // NewTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewTrainer";
            this.Text = "Dodaj Trenera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NTImieLabel;
        private System.Windows.Forms.Label NTNazwiskoLabel;
        private System.Windows.Forms.TextBox NTImieText;
        private System.Windows.Forms.TextBox NTNazwiskoText;
        private System.Windows.Forms.Button NTOk;
    }
}