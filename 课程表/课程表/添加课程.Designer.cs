namespace 课程表
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tTips = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nH1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.nH2 = new System.Windows.Forms.NumericUpDown();
            this.nM1 = new System.Windows.Forms.NumericUpDown();
            this.nM2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nID = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dColor = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nWeekEnd = new System.Windows.Forms.NumericUpDown();
            this.nWeekStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekStart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tName.Location = new System.Drawing.Point(93, 37);
            this.tName.MaxLength = 10;
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(178, 35);
            this.tName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(98, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "备注：";
            // 
            // tTips
            // 
            this.tTips.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tTips.Location = new System.Drawing.Point(103, 199);
            this.tTips.MaxLength = 22;
            this.tTips.Multiline = true;
            this.tTips.Name = "tTips";
            this.tTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tTips.Size = new System.Drawing.Size(230, 71);
            this.tTips.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(190, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "-";
            // 
            // nH1
            // 
            this.nH1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nH1.Location = new System.Drawing.Point(79, 102);
            this.nH1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nH1.Name = "nH1";
            this.nH1.Size = new System.Drawing.Size(36, 26);
            this.nH1.TabIndex = 6;
            this.nH1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "完成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nH2
            // 
            this.nH2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nH2.Location = new System.Drawing.Point(212, 102);
            this.nH2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nH2.Name = "nH2";
            this.nH2.Size = new System.Drawing.Size(36, 26);
            this.nH2.TabIndex = 10;
            this.nH2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nM1
            // 
            this.nM1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nM1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nM1.Location = new System.Drawing.Point(144, 102);
            this.nM1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM1.Name = "nM1";
            this.nM1.Size = new System.Drawing.Size(44, 26);
            this.nM1.TabIndex = 11;
            this.nM1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nM2
            // 
            this.nM2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nM2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nM2.Location = new System.Drawing.Point(268, 102);
            this.nM2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM2.Name = "nM2";
            this.nM2.Size = new System.Drawing.Size(46, 26);
            this.nM2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(121, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(254, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(231, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "第        节";
            // 
            // nID
            // 
            this.nID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nID.Location = new System.Drawing.Point(268, 159);
            this.nID.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nID.Name = "nID";
            this.nID.Size = new System.Drawing.Size(36, 33);
            this.nID.TabIndex = 17;
            this.nID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nID.ValueChanged += new System.EventHandler(this.nID_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "周一",
            "周二",
            "周三",
            "周四",
            "周五",
            "周六",
            "周日"});
            this.listBox1.Location = new System.Drawing.Point(12, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(69, 116);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(288, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(12, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "连课";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nWeekEnd
            // 
            this.nWeekEnd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nWeekEnd.Location = new System.Drawing.Point(268, 286);
            this.nWeekEnd.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nWeekEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWeekEnd.Name = "nWeekEnd";
            this.nWeekEnd.Size = new System.Drawing.Size(36, 26);
            this.nWeekEnd.TabIndex = 22;
            this.nWeekEnd.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nWeekEnd.ValueChanged += new System.EventHandler(this.nWeekEnd_ValueChanged);
            // 
            // nWeekStart
            // 
            this.nWeekStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nWeekStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nWeekStart.Location = new System.Drawing.Point(167, 286);
            this.nWeekStart.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nWeekStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWeekStart.Name = "nWeekStart";
            this.nWeekStart.Size = new System.Drawing.Size(44, 26);
            this.nWeekStart.TabIndex = 23;
            this.nWeekStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(227, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(98, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "周次：";
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 396);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nWeekEnd);
            this.Controls.Add(this.nWeekStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nH2);
            this.Controls.Add(this.nH1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nM2);
            this.Controls.Add(this.nM1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tTips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTips;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nH1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nH2;
        private System.Windows.Forms.NumericUpDown nM1;
        private System.Windows.Forms.NumericUpDown nM2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nID;
        private System.Windows.Forms.ListBox listBox1;
        public Lesson LessonR;
        public bool Done;
        private System.Windows.Forms.ColorDialog dColor;
        private System.Windows.Forms.Button button2;
        public decimal Id;
        public int WeekdayIndex;
        public decimal h, m;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nWeekEnd;
        private System.Windows.Forms.NumericUpDown nWeekStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}