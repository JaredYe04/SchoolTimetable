namespace 课程表
{
    partial class 编辑课程
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nH2 = new System.Windows.Forms.NumericUpDown();
            this.nH1 = new System.Windows.Forms.NumericUpDown();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.nID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nM2 = new System.Windows.Forms.NumericUpDown();
            this.nM1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tTips = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dColor = new System.Windows.Forms.ColorDialog();
            this.saveDText = new System.Windows.Forms.SaveFileDialog();
            this.openDText = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.bImportExcel = new System.Windows.Forms.Button();
            this.ImportExcel = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nWeekEnd = new System.Windows.Forms.NumericUpDown();
            this.nWeekStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.checkRandom = new System.Windows.Forms.CheckBox();
            this.saveTemplateSheet = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekStart)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 327);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(157, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(616, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nH2
            // 
            this.nH2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nH2.Location = new System.Drawing.Point(536, 73);
            this.nH2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nH2.Name = "nH2";
            this.nH2.Size = new System.Drawing.Size(36, 26);
            this.nH2.TabIndex = 27;
            this.nH2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nH2.ValueChanged += new System.EventHandler(this.nH2_ValueChanged);
            // 
            // nH1
            // 
            this.nH1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nH1.Location = new System.Drawing.Point(421, 73);
            this.nH1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nH1.Name = "nH1";
            this.nH1.Size = new System.Drawing.Size(36, 26);
            this.nH1.TabIndex = 26;
            this.nH1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nH1.ValueChanged += new System.EventHandler(this.nH1_ValueChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Items.AddRange(new object[] {
            "周一",
            "周二",
            "周三",
            "周四",
            "周五",
            "周六",
            "周日"});
            this.listBox2.Location = new System.Drawing.Point(340, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(69, 144);
            this.listBox2.TabIndex = 34;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // nID
            // 
            this.nID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nID.Location = new System.Drawing.Point(596, 109);
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
            this.nID.TabIndex = 33;
            this.nID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nID.ValueChanged += new System.EventHandler(this.nID_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(559, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "第        节";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(582, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(463, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = ":";
            // 
            // nM2
            // 
            this.nM2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nM2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nM2.Location = new System.Drawing.Point(605, 73);
            this.nM2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM2.Name = "nM2";
            this.nM2.Size = new System.Drawing.Size(46, 26);
            this.nM2.TabIndex = 29;
            this.nM2.ValueChanged += new System.EventHandler(this.nM2_ValueChanged);
            // 
            // nM1
            // 
            this.nM1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nM1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nM1.Location = new System.Drawing.Point(479, 73);
            this.nM1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nM1.Name = "nM1";
            this.nM1.Size = new System.Drawing.Size(44, 26);
            this.nM1.TabIndex = 28;
            this.nM1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nM1.ValueChanged += new System.EventHandler(this.nM1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(518, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "-";
            // 
            // tTips
            // 
            this.tTips.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tTips.Location = new System.Drawing.Point(431, 149);
            this.tTips.MaxLength = 22;
            this.tTips.Multiline = true;
            this.tTips.Name = "tTips";
            this.tTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tTips.Size = new System.Drawing.Size(230, 67);
            this.tTips.TabIndex = 24;
            this.tTips.TextChanged += new System.EventHandler(this.tTips_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(426, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "备注：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(340, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "时间：";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tName.Location = new System.Drawing.Point(421, 25);
            this.tName.MaxLength = 10;
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(178, 35);
            this.tName.TabIndex = 21;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "名称：";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(12, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 34);
            this.button3.TabIndex = 36;
            this.button3.Text = "导入";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(85, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 34);
            this.button4.TabIndex = 37;
            this.button4.Text = "导出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(513, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 36);
            this.button5.TabIndex = 38;
            this.button5.Text = "确认更改";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(345, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(316, 47);
            this.button6.TabIndex = 39;
            this.button6.Text = "保存并退出";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveDText
            // 
            this.saveDText.Filter = "文本文件|*.txt|所有文件|*.*";
            // 
            // openDText
            // 
            this.openDText.Filter = "文本文件|*.txt|所有文件|*.*";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(253, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 34);
            this.button7.TabIndex = 40;
            this.button7.Text = "复制";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bImportExcel
            // 
            this.bImportExcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bImportExcel.Location = new System.Drawing.Point(345, 310);
            this.bImportExcel.Name = "bImportExcel";
            this.bImportExcel.Size = new System.Drawing.Size(112, 34);
            this.bImportExcel.TabIndex = 41;
            this.bImportExcel.Text = "读取EXCEL表";
            this.bImportExcel.UseVisualStyleBackColor = true;
            this.bImportExcel.Click += new System.EventHandler(this.button8_Click);
            // 
            // ImportExcel
            // 
            this.ImportExcel.Filter = "XLSX文件|*xlsx|XLS文件|*xls";
            this.ImportExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportExcel_FileOk);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(345, 270);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(162, 34);
            this.button9.TabIndex = 42;
            this.button9.Text = "校准周次";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(426, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "周次：";
            // 
            // nWeekEnd
            // 
            this.nWeekEnd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nWeekEnd.Location = new System.Drawing.Point(587, 218);
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
            this.nWeekEnd.TabIndex = 44;
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
            this.nWeekStart.Location = new System.Drawing.Point(495, 218);
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
            this.nWeekStart.TabIndex = 45;
            this.nWeekStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWeekStart.ValueChanged += new System.EventHandler(this.nWeekStart_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(555, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "-";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(564, 310);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 34);
            this.button8.TabIndex = 47;
            this.button8.Text = "生成模板表格";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // checkRandom
            // 
            this.checkRandom.AutoSize = true;
            this.checkRandom.Checked = true;
            this.checkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRandom.Location = new System.Drawing.Point(479, 321);
            this.checkRandom.Name = "checkRandom";
            this.checkRandom.Size = new System.Drawing.Size(72, 16);
            this.checkRandom.TabIndex = 48;
            this.checkRandom.Text = "自动颜色";
            this.checkRandom.UseVisualStyleBackColor = true;
            // 
            // saveTemplateSheet
            // 
            this.saveTemplateSheet.Filter = "Excel表格|*.xlsx";
            // 
            // 编辑课程
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 403);
            this.Controls.Add(this.checkRandom);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nWeekEnd);
            this.Controls.Add(this.nWeekStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.bImportExcel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nH2);
            this.Controls.Add(this.nH1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.nID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nM2);
            this.Controls.Add(this.nM1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tTips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "编辑课程";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑课程";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeekStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nH2;
        private System.Windows.Forms.NumericUpDown nH1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.NumericUpDown nID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nM2;
        private System.Windows.Forms.NumericUpDown nM1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public Lesson[] LessonList=new Lesson[91];
        private System.Windows.Forms.ColorDialog dColor;
        public bool Save;
        public int DateOffset = 0;
        private System.Windows.Forms.SaveFileDialog saveDText;
        private System.Windows.Forms.OpenFileDialog openDText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button bImportExcel;
        private System.Windows.Forms.OpenFileDialog ImportExcel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nWeekEnd;
        private System.Windows.Forms.NumericUpDown nWeekStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkRandom;
        private System.Windows.Forms.SaveFileDialog saveTemplateSheet;
    }
}