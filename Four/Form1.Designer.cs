namespace Four
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
            this.Next = new System.Windows.Forms.Button();
            this.pLettering = new System.Windows.Forms.Label();
            this.pNum = new System.Windows.Forms.Label();
            this.pCount = new System.Windows.Forms.Label();
            this.cCount = new System.Windows.Forms.Label();
            this.cLettering = new System.Windows.Forms.Label();
            this.cNum = new System.Windows.Forms.NumericUpDown();
            this.p2Count = new System.Windows.Forms.Label();
            this.p2Num = new System.Windows.Forms.Label();
            this.p2Lettering = new System.Windows.Forms.Label();
            this.p3Count = new System.Windows.Forms.Label();
            this.p3Num = new System.Windows.Forms.Label();
            this.p3Lettering = new System.Windows.Forms.Label();
            this.p4Count = new System.Windows.Forms.Label();
            this.p4Num = new System.Windows.Forms.Label();
            this.p4Lettering = new System.Windows.Forms.Label();
            this.p5Count = new System.Windows.Forms.Label();
            this.p5Num = new System.Windows.Forms.Label();
            this.p5Lettering = new System.Windows.Forms.Label();
            this.p6Count = new System.Windows.Forms.Label();
            this.p6Num = new System.Windows.Forms.Label();
            this.p6Lettering = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(393, 414);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(86, 31);
            this.Next.TabIndex = 0;
            this.Next.Text = "Calculate";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // pLettering
            // 
            this.pLettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLettering.Location = new System.Drawing.Point(145, 94);
            this.pLettering.Name = "pLettering";
            this.pLettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pLettering.Size = new System.Drawing.Size(212, 39);
            this.pLettering.TabIndex = 1;
            this.pLettering.Text = "label1";
            this.pLettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNum
            // 
            this.pNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pNum.Location = new System.Drawing.Point(12, 94);
            this.pNum.Name = "pNum";
            this.pNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pNum.Size = new System.Drawing.Size(127, 39);
            this.pNum.TabIndex = 2;
            this.pNum.Text = "label1";
            this.pNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCount
            // 
            this.pCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCount.Location = new System.Drawing.Point(363, 94);
            this.pCount.Name = "pCount";
            this.pCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pCount.Size = new System.Drawing.Size(116, 39);
            this.pCount.TabIndex = 3;
            this.pCount.Text = "label1";
            this.pCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCount
            // 
            this.cCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cCount.Location = new System.Drawing.Point(363, 34);
            this.cCount.Name = "cCount";
            this.cCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cCount.Size = new System.Drawing.Size(116, 39);
            this.cCount.TabIndex = 6;
            this.cCount.Text = "label1";
            this.cCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cLettering
            // 
            this.cLettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cLettering.Location = new System.Drawing.Point(145, 34);
            this.cLettering.Name = "cLettering";
            this.cLettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cLettering.Size = new System.Drawing.Size(212, 39);
            this.cLettering.TabIndex = 4;
            this.cLettering.Text = "label1";
            this.cLettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cNum
            // 
            this.cNum.BackColor = System.Drawing.Color.Lavender;
            this.cNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNum.Location = new System.Drawing.Point(12, 40);
            this.cNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cNum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.cNum.Name = "cNum";
            this.cNum.Size = new System.Drawing.Size(127, 26);
            this.cNum.TabIndex = 7;
            this.cNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cNum.ValueChanged += new System.EventHandler(this.cNum_ValueChanged);
            // 
            // p2Count
            // 
            this.p2Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Count.Location = new System.Drawing.Point(363, 153);
            this.p2Count.Name = "p2Count";
            this.p2Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2Count.Size = new System.Drawing.Size(116, 39);
            this.p2Count.TabIndex = 11;
            this.p2Count.Text = "label1";
            this.p2Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Num
            // 
            this.p2Num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Num.Location = new System.Drawing.Point(12, 153);
            this.p2Num.Name = "p2Num";
            this.p2Num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2Num.Size = new System.Drawing.Size(127, 39);
            this.p2Num.TabIndex = 10;
            this.p2Num.Text = "label1";
            this.p2Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Lettering
            // 
            this.p2Lettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Lettering.Location = new System.Drawing.Point(145, 153);
            this.p2Lettering.Name = "p2Lettering";
            this.p2Lettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2Lettering.Size = new System.Drawing.Size(212, 39);
            this.p2Lettering.TabIndex = 9;
            this.p2Lettering.Text = "label1";
            this.p2Lettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3Count
            // 
            this.p3Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3Count.Location = new System.Drawing.Point(363, 213);
            this.p3Count.Name = "p3Count";
            this.p3Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p3Count.Size = new System.Drawing.Size(116, 39);
            this.p3Count.TabIndex = 14;
            this.p3Count.Text = "label1";
            this.p3Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3Num
            // 
            this.p3Num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3Num.Location = new System.Drawing.Point(12, 213);
            this.p3Num.Name = "p3Num";
            this.p3Num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p3Num.Size = new System.Drawing.Size(127, 39);
            this.p3Num.TabIndex = 13;
            this.p3Num.Text = "label1";
            this.p3Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3Lettering
            // 
            this.p3Lettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3Lettering.Location = new System.Drawing.Point(145, 213);
            this.p3Lettering.Name = "p3Lettering";
            this.p3Lettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p3Lettering.Size = new System.Drawing.Size(212, 39);
            this.p3Lettering.TabIndex = 12;
            this.p3Lettering.Text = "label1";
            this.p3Lettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4Count
            // 
            this.p4Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4Count.Location = new System.Drawing.Point(363, 268);
            this.p4Count.Name = "p4Count";
            this.p4Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p4Count.Size = new System.Drawing.Size(116, 39);
            this.p4Count.TabIndex = 17;
            this.p4Count.Text = "label1";
            this.p4Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4Num
            // 
            this.p4Num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4Num.Location = new System.Drawing.Point(12, 268);
            this.p4Num.Name = "p4Num";
            this.p4Num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p4Num.Size = new System.Drawing.Size(127, 39);
            this.p4Num.TabIndex = 16;
            this.p4Num.Text = "label1";
            this.p4Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4Lettering
            // 
            this.p4Lettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4Lettering.Location = new System.Drawing.Point(145, 268);
            this.p4Lettering.Name = "p4Lettering";
            this.p4Lettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p4Lettering.Size = new System.Drawing.Size(212, 39);
            this.p4Lettering.TabIndex = 15;
            this.p4Lettering.Text = "label1";
            this.p4Lettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5Count
            // 
            this.p5Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p5Count.Location = new System.Drawing.Point(363, 317);
            this.p5Count.Name = "p5Count";
            this.p5Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p5Count.Size = new System.Drawing.Size(116, 39);
            this.p5Count.TabIndex = 20;
            this.p5Count.Text = "label1";
            this.p5Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5Num
            // 
            this.p5Num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p5Num.Location = new System.Drawing.Point(12, 317);
            this.p5Num.Name = "p5Num";
            this.p5Num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p5Num.Size = new System.Drawing.Size(127, 39);
            this.p5Num.TabIndex = 19;
            this.p5Num.Text = "label1";
            this.p5Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5Lettering
            // 
            this.p5Lettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p5Lettering.Location = new System.Drawing.Point(145, 317);
            this.p5Lettering.Name = "p5Lettering";
            this.p5Lettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p5Lettering.Size = new System.Drawing.Size(212, 39);
            this.p5Lettering.TabIndex = 18;
            this.p5Lettering.Text = "label1";
            this.p5Lettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p6Count
            // 
            this.p6Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p6Count.Location = new System.Drawing.Point(363, 363);
            this.p6Count.Name = "p6Count";
            this.p6Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p6Count.Size = new System.Drawing.Size(116, 39);
            this.p6Count.TabIndex = 24;
            this.p6Count.Text = "label1";
            this.p6Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p6Num
            // 
            this.p6Num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p6Num.Location = new System.Drawing.Point(12, 363);
            this.p6Num.Name = "p6Num";
            this.p6Num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p6Num.Size = new System.Drawing.Size(127, 39);
            this.p6Num.TabIndex = 23;
            this.p6Num.Text = "label1";
            this.p6Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p6Lettering
            // 
            this.p6Lettering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p6Lettering.Location = new System.Drawing.Point(145, 363);
            this.p6Lettering.Name = "p6Lettering";
            this.p6Lettering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p6Lettering.Size = new System.Drawing.Size(212, 39);
            this.p6Lettering.TabIndex = 22;
            this.p6Lettering.Text = "label1";
            this.p6Lettering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(491, 483);
            this.Controls.Add(this.p6Count);
            this.Controls.Add(this.p6Num);
            this.Controls.Add(this.p6Lettering);
            this.Controls.Add(this.p5Count);
            this.Controls.Add(this.p5Num);
            this.Controls.Add(this.p5Lettering);
            this.Controls.Add(this.p4Count);
            this.Controls.Add(this.p4Num);
            this.Controls.Add(this.p4Lettering);
            this.Controls.Add(this.p3Count);
            this.Controls.Add(this.p3Num);
            this.Controls.Add(this.p3Lettering);
            this.Controls.Add(this.p2Count);
            this.Controls.Add(this.p2Num);
            this.Controls.Add(this.p2Lettering);
            this.Controls.Add(this.cNum);
            this.Controls.Add(this.cCount);
            this.Controls.Add(this.cLettering);
            this.Controls.Add(this.pCount);
            this.Controls.Add(this.pNum);
            this.Controls.Add(this.pLettering);
            this.Controls.Add(this.Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "STF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label pLettering;
        private System.Windows.Forms.Label pNum;
        private System.Windows.Forms.Label pCount;
        private System.Windows.Forms.Label cCount;
        private System.Windows.Forms.Label cLettering;
        private System.Windows.Forms.NumericUpDown cNum;
        private System.Windows.Forms.Label p2Count;
        private System.Windows.Forms.Label p2Num;
        private System.Windows.Forms.Label p2Lettering;
        private System.Windows.Forms.Label p3Count;
        private System.Windows.Forms.Label p3Num;
        private System.Windows.Forms.Label p3Lettering;
        private System.Windows.Forms.Label p4Count;
        private System.Windows.Forms.Label p4Num;
        private System.Windows.Forms.Label p4Lettering;
        private System.Windows.Forms.Label p5Count;
        private System.Windows.Forms.Label p5Num;
        private System.Windows.Forms.Label p5Lettering;
        private System.Windows.Forms.Label p6Count;
        private System.Windows.Forms.Label p6Num;
        private System.Windows.Forms.Label p6Lettering;
    }
}

