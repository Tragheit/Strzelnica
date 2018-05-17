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
            this.ESOk = new System.Windows.Forms.Button();
            this.ESCenaNum = new System.Windows.Forms.NumericUpDown();
            this.ESCenaLabel = new System.Windows.Forms.Label();
            this.ESOdleNum = new System.Windows.Forms.NumericUpDown();
            this.ESOdleglabel = new System.Windows.Forms.Label();
            this.ESKuloLabel = new System.Windows.Forms.Label();
            this.ESKuloGrid = new System.Windows.Forms.DataGridView();
            this.ESStanLabel = new System.Windows.Forms.Label();
            this.ESStanNum = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESCenaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESOdleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESKuloGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESStanNum)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.ESOk, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.ESCenaNum, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.ESCenaLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ESOdleNum, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ESOdleglabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ESKuloLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ESKuloGrid, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ESStanLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ESStanNum, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.24164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.78344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ESOk
            // 
            this.ESOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ESOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ESOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESOk.Location = new System.Drawing.Point(557, 334);
            this.ESOk.Name = "ESOk";
            this.ESOk.Size = new System.Drawing.Size(99, 28);
            this.ESOk.TabIndex = 6;
            this.ESOk.Text = "OK";
            this.ESOk.UseVisualStyleBackColor = false;
            this.ESOk.Click += new System.EventHandler(this.editStanowisko);
            // 
            // ESCenaNum
            // 
            this.ESCenaNum.Location = new System.Drawing.Point(280, 334);
            this.ESCenaNum.Name = "ESCenaNum";
            this.ESCenaNum.Size = new System.Drawing.Size(163, 20);
            this.ESCenaNum.TabIndex = 5;
            // 
            // ESCenaLabel
            // 
            this.ESCenaLabel.AutoSize = true;
            this.ESCenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESCenaLabel.Location = new System.Drawing.Point(280, 292);
            this.ESCenaLabel.Name = "ESCenaLabel";
            this.ESCenaLabel.Size = new System.Drawing.Size(47, 20);
            this.ESCenaLabel.TabIndex = 2;
            this.ESCenaLabel.Text = "Cena";
            // 
            // ESOdleNum
            // 
            this.ESOdleNum.Location = new System.Drawing.Point(37, 334);
            this.ESOdleNum.Name = "ESOdleNum";
            this.ESOdleNum.Size = new System.Drawing.Size(163, 20);
            this.ESOdleNum.TabIndex = 4;
            // 
            // ESOdleglabel
            // 
            this.ESOdleglabel.AutoSize = true;
            this.ESOdleglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESOdleglabel.Location = new System.Drawing.Point(37, 292);
            this.ESOdleglabel.Name = "ESOdleglabel";
            this.ESOdleglabel.Size = new System.Drawing.Size(152, 20);
            this.ESOdleglabel.TabIndex = 1;
            this.ESOdleglabel.Text = "Odległość od Tarczy";
            // 
            // ESKuloLabel
            // 
            this.ESKuloLabel.AutoSize = true;
            this.ESKuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESKuloLabel.Location = new System.Drawing.Point(37, 99);
            this.ESKuloLabel.Name = "ESKuloLabel";
            this.ESKuloLabel.Size = new System.Drawing.Size(80, 20);
            this.ESKuloLabel.TabIndex = 0;
            this.ESKuloLabel.Text = "Kulochwyt";
            // 
            // ESKuloGrid
            // 
            this.ESKuloGrid.AllowUserToAddRows = false;
            this.ESKuloGrid.AllowUserToDeleteRows = false;
            this.ESKuloGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ESKuloGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.ESKuloGrid, 2);
            this.ESKuloGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ESKuloGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ESKuloGrid.Location = new System.Drawing.Point(37, 135);
            this.ESKuloGrid.Name = "ESKuloGrid";
            this.ESKuloGrid.ReadOnly = true;
            this.ESKuloGrid.Size = new System.Drawing.Size(492, 154);
            this.ESKuloGrid.TabIndex = 3;
            // 
            // ESStanLabel
            // 
            this.ESStanLabel.AutoSize = true;
            this.ESStanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ESStanLabel.Location = new System.Drawing.Point(37, 16);
            this.ESStanLabel.Name = "ESStanLabel";
            this.ESStanLabel.Size = new System.Drawing.Size(91, 20);
            this.ESStanLabel.TabIndex = 7;
            this.ESStanLabel.Text = "Stanowisko";
            // 
            // ESStanNum
            // 
            this.ESStanNum.Location = new System.Drawing.Point(37, 52);
            this.ESStanNum.Name = "ESStanNum";
            this.ESStanNum.Size = new System.Drawing.Size(163, 20);
            this.ESStanNum.TabIndex = 8;
            // 
            // EdytStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EdytStanowisko";
            this.Text = "Edytuj Stanowisko";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESCenaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESOdleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESKuloGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESStanNum)).EndInit();
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
        private System.Windows.Forms.Label ESStanLabel;
        private System.Windows.Forms.NumericUpDown ESStanNum;
    }
}