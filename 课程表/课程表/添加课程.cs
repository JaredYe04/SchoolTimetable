using System;
using System.Windows.Forms;

namespace 课程表
{
    public partial class Form2 : Form
    {
        public Form2(decimal Id,int WeekdayIndex,int H,int M)
        {
            this.Id = Id;
            this.WeekdayIndex=WeekdayIndex;
            this.h = H;
            this.m = M;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tName.Text!="")
            {
                LessonR = new Lesson(listBox1.Text, nID.Value, tName.Text, tTips.Text.Replace('\n', '#'), nH1.Value, nH2.Value, nM1.Value, nM2.Value, dColor.Color);
                    
                if (Id < 13)
                {
                    Id++;
                    if (checkBox1.Checked) Id++;
                }
                else
                {
                    Id = 1;
                    WeekdayIndex++;
                    if (WeekdayIndex == 8) WeekdayIndex = 1;
                }
                h = nH1.Value;
                m = nM1.Value;

                Done = true;

            }
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            nID.Value = Id;
            //nH1.Value = h;
            //nM1.Value = m;
            //nH2.Value = h+1;
            //nM2.Value = m;
            Done = false;
            listBox1.SetSelected(WeekdayIndex-1, true);

        }
        bool ColorChanged = false;
        private void button2_Click(object sender, EventArgs e)
        {
            dColor.ShowDialog();
            tName.ForeColor = dColor.Color;
            tTips.ForeColor = dColor.Color;
            button2.ForeColor = dColor.Color;
            button2.BackColor = dColor.Color;
            ColorChanged = true;
        }


        private void nID_ValueChanged(object sender, EventArgs e)
        {
            Id = nID.Value;

            /////按照作息表修改
            ///
            switch(nID.Value)
            {
                case 1:
                    nH1.Value = 8;
                    nM1.Value = 15;
                    nH2.Value = 9;
                    nM2.Value = 0;
                    break;
                case 2:
                    nH1.Value = 9;
                    nM1.Value = 0;
                    nH2.Value = 9;
                    nM2.Value = 45;
                    break;
                case 3:
                    nH1.Value = 10;
                    nM1.Value = 5;
                    nH2.Value = 10;
                    nM2.Value = 50;
                    break;
                case 4:
                    nH1.Value = 10;
                    nM1.Value = 50;
                    nH2.Value = 11;
                    nM2.Value = 35;
                    break;
                case 5:
                    nH1.Value = 13;
                    nM1.Value = 0;
                    nH2.Value = 13;
                    nM2.Value = 45;
                    break;
                case 6:
                    nH1.Value = 13;
                    nM1.Value = 45;
                    nH2.Value = 14;
                    nM2.Value = 30;
                    break;
                case 7:
                    nH1.Value = 14;
                    nM1.Value = 50;
                    nH2.Value = 15;
                    nM2.Value = 35;
                    break;
                case 8:
                    nH1.Value = 15;
                    nM1.Value = 35;
                    nH2.Value = 16;
                    nM2.Value = 20;
                    break;
                case 9:
                    nH1.Value = 16;
                    nM1.Value = 20;
                    nH2.Value = 17;
                    nM2.Value = 5;
                    break;
                case 10:
                    nH1.Value = 18;
                    nM1.Value = 0;
                    nH2.Value = 18;
                    nM2.Value = 45;
                    break;
                case 11:
                    nH1.Value = 18;
                    nM1.Value = 45;
                    nH2.Value = 19;
                    nM2.Value = 30;
                    break;
                case 12:
                    nH1.Value = 19;
                    nM1.Value = 50;
                    nH2.Value = 20;
                    nM2.Value = 35;
                    break;
                case 13:
                    nH1.Value = 20;
                    nM1.Value = 35;
                    nH2.Value = 21;
                    nM2.Value = 20;
                    break;

            }
            if(!ColorChanged)
            {
                if (Id <= 4)
                {
                    tName.ForeColor = System.Drawing.Color.Black;
                    tTips.ForeColor = System.Drawing.Color.Black;
                    button2.ForeColor = System.Drawing.Color.Black;
                    button2.BackColor = System.Drawing.Color.Black;
                }
                else if (Id <= 9)
                {
                    tName.ForeColor = System.Drawing.Color.Brown;
                    tTips.ForeColor = System.Drawing.Color.Brown;
                    button2.ForeColor = System.Drawing.Color.Brown;
                    button2.BackColor = System.Drawing.Color.Brown;
                }
                else
                {
                    tName.ForeColor = System.Drawing.Color.DarkBlue;
                    tTips.ForeColor = System.Drawing.Color.DarkBlue;
                    button2.ForeColor = System.Drawing.Color.DarkBlue;
                    button2.BackColor = System.Drawing.Color.DarkBlue;
                }
                dColor.Color = tName.ForeColor;
            }

        }
    }
}
