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
                LessonR = new Lesson(
                    listBox1.Text, nID.Value,
                    tName.Text, tTips.Text.Replace('\n', '#'),
                    nH1.Value, nH2.Value, nM1.Value, nM2.Value,
                    nWeekStart.Value,nWeekEnd.Value, dColor.Color);
                    
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
            decimal h1, m1, h2, m2;
            Autos.AutoTimetable(Id, out h1, out m1, out h2, out m2);
            nH1.Value= h1;
            nM1.Value= m1;
            nH2.Value= h2;
            nM2.Value= m2;

            if(!ColorChanged)
            {
                var ColorGeneral = Autos.AutoColor(Id, tName.Text,false);
                tName.ForeColor = ColorGeneral;
                tTips.ForeColor = ColorGeneral;
                button2.ForeColor = ColorGeneral;
                button2.BackColor = ColorGeneral;

                dColor.Color = tName.ForeColor;
            }

        }

        private void nWeekEnd_ValueChanged(object sender, EventArgs e)
        {
            nWeekStart.Value = nWeekEnd.Value < nWeekStart.Value ? nWeekEnd.Value : nWeekStart.Value;
        }
    }
}
