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
            this.ETImieLabel = new System.Windows.Forms.Label();
            this.ETNazwiskoLabel = new System.Windows.Forms.Label();
            this.ETImieText = new System.Windows.Forms.TextBox();
            this.ETNazwiskoText = new System.Windows.Forms.TextBox();
            this.ETOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.83138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.728337F));
            this.tableLayoutPanel1.Controls.Add(this.ETImieLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ETNazwiskoLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ETImieText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ETNazwiskoText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ETOk, 2, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ETImieLabel
            // 
            this.ETImieLabel.AutoSize = true;
            this.ETImieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETImieLabel.Location = new System.Drawing.Point(28, 11);
            this.ETImieLabel.Name = "ETImieLabel";
            this.ETImieLabel.Size = new System.Drawing.Size(39, 20);
            this.ETImieLabel.TabIndex = 0;
            this.ETImieLabel.Text = "Imię";
            // 
            // ETNazwiskoLabel
            // 
            this.ETNazwiskoLabel.AutoSize = true;
            this.ETNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETNazwiskoLabel.Location = new System.Drawing.Point(28, 113);
            this.ETNazwiskoLabel.Name = "ETNazwiskoLabel";
            this.ETNazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.ETNazwiskoLabel.TabIndex = 1;
            this.ETNazwiskoLabel.Text = "Nazwisko";
            // 
            // ETImieText
            // 
            this.ETImieText.Location = new System.Drawing.Point(28, 36);
            this.ETImieText.Name = "ETImieText";
            this.ETImieText.Size = new System.Drawing.Size(148, 20);
            this.ETImieText.TabIndex = 2;
            // 
            // ETNazwiskoText
            // 
            this.ETNazwiskoText.Location = new System.Drawing.Point(28, 138);
            this.ETNazwiskoText.Name = "ETNazwiskoText";
            this.ETNazwiskoText.Size = new System.Drawing.Size(148, 20);
            this.ETNazwiskoText.TabIndex = 3;
            // 
            // ETOk
            // 
            this.ETOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ETOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ETOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ETOk.Location = new System.Drawing.Point(306, 178);
            this.ETOk.Name = "ETOk";
            this.ETOk.Size = new System.Drawing.Size(84, 34);
            this.ETOk.TabIndex = 4;
            this.ETOk.Text = "OK";
            this.ETOk.UseVisualStyleBackColor = false;
            // 
            // EdytTrener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytTrener";
            this.Text = "Edytuj Trenera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ETImieLabel;
        private System.Windows.Forms.Label ETNazwiskoLabel;
        private System.Windows.Forms.TextBox ETImieText;
        private System.Windows.Forms.TextBox ETNazwiskoText;
        private System.Windows.Forms.Button ETOk;
    }
}