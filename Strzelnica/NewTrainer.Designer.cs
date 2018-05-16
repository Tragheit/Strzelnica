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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.Controls.Add(this.NTImieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NTNazwiskoLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NTImieText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NTNazwiskoText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NTOk, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NTImieLabel
            // 
            this.NTImieLabel.AutoSize = true;
            this.NTImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NTImieLabel.Location = new System.Drawing.Point(47, 67);
            this.NTImieLabel.Name = "NTImieLabel";
            this.NTImieLabel.Size = new System.Drawing.Size(48, 25);
            this.NTImieLabel.TabIndex = 0;
            this.NTImieLabel.Text = "Imię";
            // 
            // NTNazwiskoLabel
            // 
            this.NTNazwiskoLabel.AutoSize = true;
            this.NTNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NTNazwiskoLabel.Location = new System.Drawing.Point(47, 202);
            this.NTNazwiskoLabel.Name = "NTNazwiskoLabel";
            this.NTNazwiskoLabel.Size = new System.Drawing.Size(96, 25);
            this.NTNazwiskoLabel.TabIndex = 1;
            this.NTNazwiskoLabel.Text = "Nazwisko";
            // 
            // NTImieText
            // 
            this.NTImieText.Location = new System.Drawing.Point(313, 70);
            this.NTImieText.Name = "NTImieText";
            this.NTImieText.Size = new System.Drawing.Size(190, 22);
            this.NTImieText.TabIndex = 2;
            // 
            // NTNazwiskoText
            // 
            this.NTNazwiskoText.Location = new System.Drawing.Point(313, 205);
            this.NTNazwiskoText.Name = "NTNazwiskoText";
            this.NTNazwiskoText.Size = new System.Drawing.Size(190, 22);
            this.NTNazwiskoText.TabIndex = 3;
            // 
            // NTOk
            // 
            this.NTOk.Location = new System.Drawing.Point(668, 340);
            this.NTOk.Name = "NTOk";
            this.NTOk.Size = new System.Drawing.Size(82, 54);
            this.NTOk.TabIndex = 4;
            this.NTOk.Text = "OK";
            this.NTOk.UseVisualStyleBackColor = true;
            // 
            // NewTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
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