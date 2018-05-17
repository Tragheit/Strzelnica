namespace Strzelnica
{
    partial class EdytStanowisko
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
            this.ESKuloLabel = new System.Windows.Forms.Label();
            this.ESOdleglabel = new System.Windows.Forms.Label();
            this.ESCenaLabel = new System.Windows.Forms.Label();
            this.ESKuloGrid = new System.Windows.Forms.DataGridView();
            this.ESOdleNum = new System.Windows.Forms.NumericUpDown();
            this.ESCenaNum = new System.Windows.Forms.NumericUpDown();
            this.ESOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESKuloGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESOdleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESCenaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.63793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.24713F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.ESKuloLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ESOdleglabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ESCenaLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ESKuloGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ESOdleNum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ESCenaNum, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ESOk, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ESKuloLabel
            // 
            this.ESKuloLabel.AutoSize = true;
            this.ESKuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESKuloLabel.Location = new System.Drawing.Point(37, 15);
            this.ESKuloLabel.Name = "ESKuloLabel";
            this.ESKuloLabel.Size = new System.Drawing.Size(80, 20);
            this.ESKuloLabel.TabIndex = 0;
            this.ESKuloLabel.Text = "Kulochwyt";
            // 
            // ESOdleglabel
            // 
            this.ESOdleglabel.AutoSize = true;
            this.ESOdleglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESOdleglabel.Location = new System.Drawing.Point(37, 201);
            this.ESOdleglabel.Name = "ESOdleglabel";
            this.ESOdleglabel.Size = new System.Drawing.Size(152, 20);
            this.ESOdleglabel.TabIndex = 1;
            this.ESOdleglabel.Text = "Odległość od Tarczy";
            // 
            // ESCenaLabel
            // 
            this.ESCenaLabel.AutoSize = true;
            this.ESCenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESCenaLabel.Location = new System.Drawing.Point(280, 201);
            this.ESCenaLabel.Name = "ESCenaLabel";
            this.ESCenaLabel.Size = new System.Drawing.Size(47, 20);
            this.ESCenaLabel.TabIndex = 2;
            this.ESCenaLabel.Text = "Cena";
            // 
            // ESKuloGrid
            // 
            this.ESKuloGrid.AllowUserToAddRows = false;
            this.ESKuloGrid.AllowUserToDeleteRows = false;
            this.ESKuloGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ESKuloGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.ESKuloGrid, 2);
            this.ESKuloGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ESKuloGrid.Location = new System.Drawing.Point(37, 49);
            this.ESKuloGrid.Name = "ESKuloGrid";
            this.ESKuloGrid.ReadOnly = true;
            this.ESKuloGrid.Size = new System.Drawing.Size(492, 149);
            this.ESKuloGrid.TabIndex = 3;
            // 
            // ESOdleNum
            // 
            this.ESOdleNum.Location = new System.Drawing.Point(37, 235);
            this.ESOdleNum.Name = "ESOdleNum";
            this.ESOdleNum.Size = new System.Drawing.Size(163, 20);
            this.ESOdleNum.TabIndex = 4;
            // 
            // ESCenaNum
            // 
            this.ESCenaNum.Location = new System.Drawing.Point(280, 235);
            this.ESCenaNum.Name = "ESCenaNum";
            this.ESCenaNum.Size = new System.Drawing.Size(163, 20);
            this.ESCenaNum.TabIndex = 5;
            // 
            // ESOk
            // 
            this.ESOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ESOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ESOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESOk.Location = new System.Drawing.Point(567, 256);
            this.ESOk.Name = "ESOk";
            this.ESOk.Size = new System.Drawing.Size(89, 35);
            this.ESOk.TabIndex = 6;
            this.ESOk.Text = "OK";
            this.ESOk.UseVisualStyleBackColor = false;
            // 
            // EdytStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytStanowisko";
            this.Text = "Edytuj Stanowisko";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESKuloGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESOdleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESCenaNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ESKuloLabel;
        private System.Windows.Forms.Label ESOdleglabel;
        private System.Windows.Forms.Label ESCenaLabel;
        private System.Windows.Forms.DataGridView ESKuloGrid;
        private System.Windows.Forms.NumericUpDown ESOdleNum;
        private System.Windows.Forms.NumericUpDown ESCenaNum;
        private System.Windows.Forms.Button ESOk;
    }
}