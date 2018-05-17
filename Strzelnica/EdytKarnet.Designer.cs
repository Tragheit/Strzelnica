namespace Strzelnica
{
    partial class EdytKarnet
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
            this.EKOk = new System.Windows.Forms.Button();
            this.EKDataPick = new System.Windows.Forms.DateTimePicker();
            this.EKDataWazLabel = new System.Windows.Forms.Label();
            this.EKRodzajGrid = new System.Windows.Forms.DataGridView();
            this.EKRodzaj = new System.Windows.Forms.Label();
            this.EKWybNumLabel = new System.Windows.Forms.Label();
            this.EKWybNum = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKRodzajGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EKWybNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.56108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.EKOk, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.EKDataPick, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EKDataWazLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EKRodzajGrid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.EKRodzaj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EKWybNumLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EKWybNum, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58108F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.135593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EKOk
            // 
            this.EKOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EKOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKOk.Location = new System.Drawing.Point(469, 305);
            this.EKOk.Name = "EKOk";
            this.EKOk.Size = new System.Drawing.Size(88, 36);
            this.EKOk.TabIndex = 2;
            this.EKOk.Text = "OK";
            this.EKOk.UseVisualStyleBackColor = false;
            this.EKOk.Click += new System.EventHandler(this.editKarnet);
            // 
            // EKDataPick
            // 
            this.EKDataPick.Location = new System.Drawing.Point(32, 299);
            this.EKDataPick.Name = "EKDataPick";
            this.EKDataPick.Size = new System.Drawing.Size(255, 20);
            this.EKDataPick.TabIndex = 4;
            // 
            // EKDataWazLabel
            // 
            this.EKDataWazLabel.AutoSize = true;
            this.EKDataWazLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKDataWazLabel.Location = new System.Drawing.Point(32, 272);
            this.EKDataWazLabel.Name = "EKDataWazLabel";
            this.EKDataWazLabel.Size = new System.Drawing.Size(117, 20);
            this.EKDataWazLabel.TabIndex = 1;
            this.EKDataWazLabel.Text = "Data Ważności";
            // 
            // EKRodzajGrid
            // 
            this.EKRodzajGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EKRodzajGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EKRodzajGrid.Location = new System.Drawing.Point(32, 135);
            this.EKRodzajGrid.Name = "EKRodzajGrid";
            this.EKRodzajGrid.Size = new System.Drawing.Size(301, 119);
            this.EKRodzajGrid.TabIndex = 3;
            // 
            // EKRodzaj
            // 
            this.EKRodzaj.AutoSize = true;
            this.EKRodzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKRodzaj.Location = new System.Drawing.Point(32, 98);
            this.EKRodzaj.Name = "EKRodzaj";
            this.EKRodzaj.Size = new System.Drawing.Size(59, 20);
            this.EKRodzaj.TabIndex = 0;
            this.EKRodzaj.Text = "Rodzaj";
            // 
            // EKWybNumLabel
            // 
            this.EKWybNumLabel.AutoSize = true;
            this.EKWybNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKWybNumLabel.Location = new System.Drawing.Point(32, 14);
            this.EKWybNumLabel.Name = "EKWybNumLabel";
            this.EKWybNumLabel.Size = new System.Drawing.Size(56, 20);
            this.EKWybNumLabel.TabIndex = 5;
            this.EKWybNumLabel.Text = "Karnet";
            // 
            // EKWybNum
            // 
            this.EKWybNum.Location = new System.Drawing.Point(32, 46);
            this.EKWybNum.Name = "EKWybNum";
            this.EKWybNum.Size = new System.Drawing.Size(148, 20);
            this.EKWybNum.TabIndex = 6;
            // 
            // EdytKarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytKarnet";
            this.Text = "Edytuj Karnet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKRodzajGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EKWybNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EKRodzaj;
        private System.Windows.Forms.Label EKDataWazLabel;
        private System.Windows.Forms.Button EKOk;
        private System.Windows.Forms.DataGridView EKRodzajGrid;
        private System.Windows.Forms.DateTimePicker EKDataPick;
        private System.Windows.Forms.Label EKWybNumLabel;
        private System.Windows.Forms.NumericUpDown EKWybNum;
    }
}