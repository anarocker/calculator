namespace CalculatorWindowsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btNum7 = new System.Windows.Forms.Button();
            this.btNum8 = new System.Windows.Forms.Button();
            this.btNum9 = new System.Windows.Forms.Button();
            this.btOperate4 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();
            this.btOperate3 = new System.Windows.Forms.Button();
            this.btNum6 = new System.Windows.Forms.Button();
            this.btNum5 = new System.Windows.Forms.Button();
            this.btNum4 = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.btOperate2 = new System.Windows.Forms.Button();
            this.btNum3 = new System.Windows.Forms.Button();
            this.btNum2 = new System.Windows.Forms.Button();
            this.btNum1 = new System.Windows.Forms.Button();
            this.btOperate1 = new System.Windows.Forms.Button();
            this.btNumDot = new System.Windows.Forms.Button();
            this.btNum0 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNum7
            // 
            this.btNum7.BackColor = System.Drawing.Color.White;
            this.btNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum7.ForeColor = System.Drawing.Color.Gray;
            this.btNum7.Location = new System.Drawing.Point(8, 126);
            this.btNum7.Name = "btNum7";
            this.btNum7.Size = new System.Drawing.Size(76, 77);
            this.btNum7.TabIndex = 1;
            this.btNum7.Text = "7";
            this.btNum7.UseVisualStyleBackColor = false;
            this.btNum7.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum8
            // 
            this.btNum8.BackColor = System.Drawing.Color.White;
            this.btNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum8.ForeColor = System.Drawing.Color.Gray;
            this.btNum8.Location = new System.Drawing.Point(90, 126);
            this.btNum8.Name = "btNum8";
            this.btNum8.Size = new System.Drawing.Size(76, 77);
            this.btNum8.TabIndex = 2;
            this.btNum8.Text = "8";
            this.btNum8.UseVisualStyleBackColor = false;
            this.btNum8.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum9
            // 
            this.btNum9.BackColor = System.Drawing.Color.White;
            this.btNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum9.ForeColor = System.Drawing.Color.Gray;
            this.btNum9.Location = new System.Drawing.Point(172, 126);
            this.btNum9.Name = "btNum9";
            this.btNum9.Size = new System.Drawing.Size(76, 77);
            this.btNum9.TabIndex = 3;
            this.btNum9.Text = "9";
            this.btNum9.UseVisualStyleBackColor = false;
            this.btNum9.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btOperate4
            // 
            this.btOperate4.BackColor = System.Drawing.Color.White;
            this.btOperate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btOperate4.ForeColor = System.Drawing.Color.Blue;
            this.btOperate4.Location = new System.Drawing.Point(254, 126);
            this.btOperate4.Name = "btOperate4";
            this.btOperate4.Size = new System.Drawing.Size(76, 77);
            this.btOperate4.TabIndex = 4;
            this.btOperate4.Text = "/";
            this.btOperate4.UseVisualStyleBackColor = false;
            this.btOperate4.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClear.ForeColor = System.Drawing.Color.Red;
            this.btClear.Location = new System.Drawing.Point(336, 126);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(76, 77);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btPercent
            // 
            this.btPercent.BackColor = System.Drawing.Color.White;
            this.btPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btPercent.ForeColor = System.Drawing.Color.Blue;
            this.btPercent.Location = new System.Drawing.Point(336, 209);
            this.btPercent.Name = "btPercent";
            this.btPercent.Size = new System.Drawing.Size(76, 77);
            this.btPercent.TabIndex = 10;
            this.btPercent.Text = "%";
            this.btPercent.UseVisualStyleBackColor = false;
            this.btPercent.Click += new System.EventHandler(this.btPercent_Click);
            // 
            // btOperate3
            // 
            this.btOperate3.BackColor = System.Drawing.Color.White;
            this.btOperate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btOperate3.ForeColor = System.Drawing.Color.Blue;
            this.btOperate3.Location = new System.Drawing.Point(254, 209);
            this.btOperate3.Name = "btOperate3";
            this.btOperate3.Size = new System.Drawing.Size(76, 77);
            this.btOperate3.TabIndex = 9;
            this.btOperate3.Text = "*";
            this.btOperate3.UseVisualStyleBackColor = false;
            this.btOperate3.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btNum6
            // 
            this.btNum6.BackColor = System.Drawing.Color.White;
            this.btNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum6.ForeColor = System.Drawing.Color.Gray;
            this.btNum6.Location = new System.Drawing.Point(172, 209);
            this.btNum6.Name = "btNum6";
            this.btNum6.Size = new System.Drawing.Size(76, 77);
            this.btNum6.TabIndex = 8;
            this.btNum6.Text = "6";
            this.btNum6.UseVisualStyleBackColor = false;
            this.btNum6.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum5
            // 
            this.btNum5.BackColor = System.Drawing.Color.White;
            this.btNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum5.ForeColor = System.Drawing.Color.Gray;
            this.btNum5.Location = new System.Drawing.Point(90, 209);
            this.btNum5.Name = "btNum5";
            this.btNum5.Size = new System.Drawing.Size(76, 77);
            this.btNum5.TabIndex = 7;
            this.btNum5.Text = "5";
            this.btNum5.UseVisualStyleBackColor = false;
            this.btNum5.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum4
            // 
            this.btNum4.BackColor = System.Drawing.Color.White;
            this.btNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum4.ForeColor = System.Drawing.Color.Gray;
            this.btNum4.Location = new System.Drawing.Point(8, 209);
            this.btNum4.Name = "btNum4";
            this.btNum4.Size = new System.Drawing.Size(76, 77);
            this.btNum4.TabIndex = 6;
            this.btNum4.Text = "4";
            this.btNum4.UseVisualStyleBackColor = false;
            this.btNum4.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btEqual
            // 
            this.btEqual.BackColor = System.Drawing.Color.White;
            this.btEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btEqual.ForeColor = System.Drawing.Color.LimeGreen;
            this.btEqual.Location = new System.Drawing.Point(336, 292);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(76, 160);
            this.btEqual.TabIndex = 15;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = false;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // btOperate2
            // 
            this.btOperate2.BackColor = System.Drawing.Color.White;
            this.btOperate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btOperate2.ForeColor = System.Drawing.Color.Blue;
            this.btOperate2.Location = new System.Drawing.Point(254, 292);
            this.btOperate2.Name = "btOperate2";
            this.btOperate2.Size = new System.Drawing.Size(76, 77);
            this.btOperate2.TabIndex = 14;
            this.btOperate2.Text = "-";
            this.btOperate2.UseVisualStyleBackColor = false;
            this.btOperate2.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btNum3
            // 
            this.btNum3.BackColor = System.Drawing.Color.White;
            this.btNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum3.ForeColor = System.Drawing.Color.Gray;
            this.btNum3.Location = new System.Drawing.Point(172, 292);
            this.btNum3.Name = "btNum3";
            this.btNum3.Size = new System.Drawing.Size(76, 77);
            this.btNum3.TabIndex = 13;
            this.btNum3.Text = "3";
            this.btNum3.UseVisualStyleBackColor = false;
            this.btNum3.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum2
            // 
            this.btNum2.BackColor = System.Drawing.Color.White;
            this.btNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum2.ForeColor = System.Drawing.Color.Gray;
            this.btNum2.Location = new System.Drawing.Point(90, 292);
            this.btNum2.Name = "btNum2";
            this.btNum2.Size = new System.Drawing.Size(76, 77);
            this.btNum2.TabIndex = 12;
            this.btNum2.Text = "2";
            this.btNum2.UseVisualStyleBackColor = false;
            this.btNum2.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum1
            // 
            this.btNum1.BackColor = System.Drawing.Color.White;
            this.btNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum1.ForeColor = System.Drawing.Color.Gray;
            this.btNum1.Location = new System.Drawing.Point(8, 292);
            this.btNum1.Name = "btNum1";
            this.btNum1.Size = new System.Drawing.Size(76, 77);
            this.btNum1.TabIndex = 11;
            this.btNum1.Text = "1";
            this.btNum1.UseVisualStyleBackColor = false;
            this.btNum1.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btOperate1
            // 
            this.btOperate1.BackColor = System.Drawing.Color.White;
            this.btOperate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btOperate1.ForeColor = System.Drawing.Color.Blue;
            this.btOperate1.Location = new System.Drawing.Point(254, 375);
            this.btOperate1.Name = "btOperate1";
            this.btOperate1.Size = new System.Drawing.Size(76, 77);
            this.btOperate1.TabIndex = 19;
            this.btOperate1.Text = "+";
            this.btOperate1.UseVisualStyleBackColor = false;
            this.btOperate1.Click += new System.EventHandler(this.btOperator_Click);
            // 
            // btNumDot
            // 
            this.btNumDot.BackColor = System.Drawing.Color.White;
            this.btNumDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNumDot.ForeColor = System.Drawing.Color.Gray;
            this.btNumDot.Location = new System.Drawing.Point(172, 375);
            this.btNumDot.Name = "btNumDot";
            this.btNumDot.Size = new System.Drawing.Size(76, 77);
            this.btNumDot.TabIndex = 18;
            this.btNumDot.Text = ".";
            this.btNumDot.UseVisualStyleBackColor = false;
            this.btNumDot.Click += new System.EventHandler(this.btNum_Click);
            // 
            // btNum0
            // 
            this.btNum0.BackColor = System.Drawing.Color.White;
            this.btNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btNum0.ForeColor = System.Drawing.Color.Gray;
            this.btNum0.Location = new System.Drawing.Point(8, 375);
            this.btNum0.Name = "btNum0";
            this.btNum0.Size = new System.Drawing.Size(158, 77);
            this.btNum0.TabIndex = 16;
            this.btNum0.Text = "0";
            this.btNum0.UseVisualStyleBackColor = false;
            this.btNum0.Click += new System.EventHandler(this.btNum_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbResult.ForeColor = System.Drawing.Color.White;
            this.tbResult.Location = new System.Drawing.Point(8, 71);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(403, 44);
            this.tbResult.TabIndex = 20;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("TH Sarabun New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbNum1.ForeColor = System.Drawing.Color.White;
            this.lbNum1.Location = new System.Drawing.Point(5, 25);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(49, 43);
            this.lbNum1.TabIndex = 21;
            this.lbNum1.Text = "......";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("TH Sarabun New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbNum2.ForeColor = System.Drawing.Color.White;
            this.lbNum2.Location = new System.Drawing.Point(46, 25);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(49, 43);
            this.lbNum2.TabIndex = 22;
            this.lbNum2.Text = "......";
            // 
            // tbHistory
            // 
            this.tbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHistory.ForeColor = System.Drawing.Color.White;
            this.tbHistory.Location = new System.Drawing.Point(434, 71);
            this.tbHistory.Multiline = true;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(276, 366);
            this.tbHistory.TabIndex = 23;
            this.tbHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 43);
            this.label1.TabIndex = 24;
            this.label1.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(735, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHistory);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btOperate1);
            this.Controls.Add(this.btNumDot);
            this.Controls.Add(this.btNum0);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btOperate2);
            this.Controls.Add(this.btNum3);
            this.Controls.Add(this.btNum2);
            this.Controls.Add(this.btNum1);
            this.Controls.Add(this.btPercent);
            this.Controls.Add(this.btOperate3);
            this.Controls.Add(this.btNum6);
            this.Controls.Add(this.btNum5);
            this.Controls.Add(this.btNum4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOperate4);
            this.Controls.Add(this.btNum9);
            this.Controls.Add(this.btNum8);
            this.Controls.Add(this.btNum7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btNum7;
        private System.Windows.Forms.Button btNum8;
        private System.Windows.Forms.Button btNum9;
        private System.Windows.Forms.Button btOperate4;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btPercent;
        private System.Windows.Forms.Button btOperate3;
        private System.Windows.Forms.Button btNum6;
        private System.Windows.Forms.Button btNum5;
        private System.Windows.Forms.Button btNum4;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btOperate2;
        private System.Windows.Forms.Button btNum3;
        private System.Windows.Forms.Button btNum2;
        private System.Windows.Forms.Button btNum1;
        private System.Windows.Forms.Button btOperate1;
        private System.Windows.Forms.Button btNumDot;
        private System.Windows.Forms.Button btNum0;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox tbHistory;
        private System.Windows.Forms.Label label1;
    }
}

