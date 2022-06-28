namespace Sorter
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.comSorts = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblIter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(331, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SORTERS";
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBack.Location = new System.Drawing.Point(23, 73);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(741, 347);
            this.pnlBack.TabIndex = 1;
            // 
            // comSorts
            // 
            this.comSorts.FormattingEnabled = true;
            this.comSorts.Items.AddRange(new object[] {
            "Bubble Sort",
            "Bogo Sort",
            "Selection Sort"});
            this.comSorts.Location = new System.Drawing.Point(791, 73);
            this.comSorts.Name = "comSorts";
            this.comSorts.Size = new System.Drawing.Size(181, 28);
            this.comSorts.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(791, 327);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(181, 48);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Create New Array";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(791, 381);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(181, 48);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort\r\n";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(866, 295);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(106, 26);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(791, 295);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(866, 263);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(106, 26);
            this.nudMax.TabIndex = 7;
            this.nudMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(818, 265);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(42, 20);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Max:";
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Location = new System.Drawing.Point(787, 24);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(84, 20);
            this.lblIter.TabIndex = 9;
            this.lblIter.Text = "Iterations: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 461);
            this.Controls.Add(this.lblIter);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.comSorts);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Sorters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.ComboBox comSorts;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblIter;
    }
}

