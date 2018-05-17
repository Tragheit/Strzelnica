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
            this.EKRodzaj = new System.Windows.Forms.Label();
            this.EKDataWazLabel = new System.Windows.Forms.Label();
            this.EKOk = new System.Windows.Forms.Button();
            this.EKRodzajGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKRodzajGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.56108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.EKRodzaj, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EKDataWazLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EKOk, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.EKRodzajGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.74261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.03375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EKRodzaj
            // 
            this.EKRodzaj.AutoSize = true;
            this.EKRodzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKRodzaj.Location = new System.Drawing.Point(27, 11);
            this.EKRodzaj.Name = "EKRodzaj";
            this.EKRodzaj.Size = new System.Drawing.Size(59, 20);
            this.EKRodzaj.TabIndex = 0;
            this.EKRodzaj.Text = "Rodzaj";
            // 
            // EKDataWazLabel
            // 
            this.EKDataWazLabel.AutoSize = true;
            this.EKDataWazLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKDataWazLabel.Location = new System.Drawing.Point(27, 159);
            this.EKDataWazLabel.Name = "EKDataWazLabel";
            this.EKDataWazLabel.Size = new System.Drawing.Size(117, 20);
            this.EKDataWazLabel.TabIndex = 1;
            this.EKDataWazLabel.Text = "Data Ważności";
            // 
            // EKOk
            // 
            this.EKOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EKOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EKOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EKOk.Location = new System.Drawing.Point(367, 188);
            this.EKOk.Name = "EKOk";
            this.EKOk.Size = new System.Drawing.Size(88, 32);
            this.EKOk.TabIndex = 2;
            this.EKOk.Text = "OK";
            this.EKOk.UseVisualStyleBackColor = false;
            // 
            // EKRodzajGrid
            // 
            this.EKRodzajGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EKRodzajGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EKRodzajGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EKRodzajGrid.Location = new System.Drawing.Point(27, 37);
            this.EKRodzajGrid.Name = "EKRodzajGrid";
            this.EKRodzajGrid.Size = new System.Drawing.Size(301, 119);
            this.EKRodzajGrid.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // EdytKarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytKarnet";
            this.Text = "Edytuj Karnet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EKRodzajGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EKRodzaj;
        private System.Windows.Forms.Label EKDataWazLabel;
        private System.Windows.Forms.Button EKOk;
        private System.Windows.Forms.DataGridView EKRodzajGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}