using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
namespace 课程表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public static Time GetTime(int Id)
        {
            Time tmp = new Time();
            switch (Id)
            {
                case 1:
                    tmp.H1 = 8;
                    tmp.M1 = 15;
                    tmp.H2 = 9;
                    tmp.M2 = 0;
                    break;
                case 2:
                    tmp.H1 = 9;
                    tmp.M1 = 0;
                    tmp.H2 = 9;
                    tmp.M2 = 45;
                    break;
                case 3:
                    tmp.H1 = 10;
                    tmp.M1 = 5;
                    tmp.H2 = 10;
                    tmp.M2 = 50;
                    break;
                case 4:
                    tmp.H1 = 10;
                    tmp.M1 = 50;
                    tmp.H2 = 11;
                    tmp.M2 = 35;
                    break;
                case 5:
                    tmp.H1 = 13;
                    tmp.M1 = 0;
                    tmp.H2 = 13;
                    tmp.M2 = 45;
                    break;
                case 6:
                    tmp.H1 = 13;
                    tmp.M1 = 45;
                    tmp.H2 = 14;
                    tmp.M2 = 30;
                    break;
                case 7:
                    tmp.H1 = 14;
                    tmp.M1 = 50;
                    tmp.H2 = 15;
                    tmp.M2 = 35;
                    break;
                case 8:
                    tmp.H1 = 15;
                    tmp.M1 = 35;
                    tmp.H2 = 16;
                    tmp.M2 = 20;
                    break;
                case 9:
                    tmp.H1 = 16;
                    tmp.M1 = 20;
                    tmp.H2 = 17;
                    tmp.M2 = 5;
                    break;
                case 10:
                    tmp.H1 = 18;
                    tmp.M1 = 0;
                    tmp.H2 = 18;
                    tmp.M2 = 45;
                    break;
                case 11:
                    tmp.H1 = 18;
                    tmp.M1 = 45;
                    tmp.H2 = 19;
                    tmp.M2 = 30;
                    break;
                case 12:
                    tmp.H1 = 19;
                    tmp.M1 = 50;
                    tmp.H2 = 20;
                    tmp.M2 = 35;
                    break;
                case 13:
                    tmp.H1 = 20;
                    tmp.M1 = 35;
                    tmp.H2 = 21;
                    tmp.M2 = 20;
                    break;

            }



            return tmp;
        }
        void AutoSaveFile()
        {

            Autos.SaveFile(Autos.DefaultFile, Lessons, Amount);
        }

        String ConvertNumWeek(int Num)
        {
            switch (Num)
            {
                case 0:
                    GregorianCalendar gregorianCalendar = new GregorianCalendar();
                    //获取指定日期是周数 CalendarWeekRule指定 第一周开始于该年的第一天，DayOfWeek指定每周第一天是星期几　
                    int weekOfYear = gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday)+Autos.DateOffset;
                    string end = DateTime.Now.AddDays(7-(int)DateTime.Now.DayOfWeek).ToShortDateString();
                    return "第"+weekOfYear+"周\n到"+end;
                case 1:
                    return "周一";
                case 2:
                    return "周二";
                case 3:
                    return "周三";
                case 4:
                    return "周四";
                case 5:
                    return "周五";
                case 6:
                    return "周六";
                case 7:
                    return "周日";
                    default:
                    return "";
            }
        }
        int ConvertWeekNum(String Week)
        {
            switch (Week)
            {
                case "周一":
                    return 1;
                case "周二":
                    return 2;
                case "周三":
                    return 3;
                case "周四":
                    return 4;
                case "周五":
                    return 5;
                case "周六":
                    return 6;
                case "周日":
                    return 7;
                default:
                    return 0;
            }
        }


        int TitleFontSize = 17;
        int LessonFontSize=17;
        int DisplayLength = 12;
        public void Render()
        {
            int YScale;
            int XScale;
            XScale =pImage.Width/8;
            YScale =pImage.Height/14;
            TitleFontSize = 9+(int)(XScale / 12);

            string GlobalFont = "微软雅黑";


            LessonFontSize =9+(int)(TitleFontSize/2);
            if(pImage.Height!=0)//////Win+D显示桌面时，控件会出现高度为0的BUG
            {

                Bitmap Img = new Bitmap(pImage.Width, pImage.Height);
                Graphics g = Graphics.FromImage(Img);//创建Graphics对象
                g.Clear(Color.White);
                Pen curPen = new Pen(Brushes.Black, 1);
                int Xoffset = 1;
                int Yoffset = -1;
                // g.DrawLine(curPen, 10, 0, 10, 30); //划线 ; 水平坐标形同 10,0,10,30;  y坐标不同
                int i = 0;
                for (int y = 0; y < pImage.Height; y += YScale)
                {
                    if(i==5)
                    {
                        g.DrawLine(curPen, 0, y-2, pImage.Width, y-2);
                    }//下午
                    if (i == 10)
                    {
                        g.DrawLine(curPen, 0, y - 2, pImage.Width, y - 2);
                    }//晚上
                    if (i == 13)
                    {
                        g.DrawLine(curPen, 0, pImage.Height - 1, pImage.Width, pImage.Height - 1);
                    }
                    if(i<=13)g.DrawLine(curPen, 0, y, pImage.Width, y);
                    if (i != 0&& i <= 13)
                    {
                        string str = "第" + Convert.ToString(i) + "节";
                        decimal h1,m1,h2,m2;
                        Autos.AutoTimetable(i, out h1, out m1, out h2, out m2);
                        str += Environment.NewLine;
                        str += h1.ToString() + ":" + m1.ToString() + " - " + h2.ToString() + ":" + m2.ToString();
                        g.DrawString(str, new Font(GlobalFont, TitleFontSize*3/5, FontStyle.Regular), Brushes.Black, new Point(2, y + Yoffset));
                    }
                        
                    i++;

                }
                int o = 0;
                //MessageBox.Show("DrawLinesModuleOK");
                g.DrawLine(curPen, 0, 0, 0, pImage.Height);
                for (int x = 0; x < pImage.Width; x += XScale)
                {
                    if(o==0)
                    {
                        //g.DrawLine(curPen, pImage.Width - 1, 0, pImage.Width - 1, pImage.Height);
                        g.DrawString(ConvertNumWeek(o), new Font(GlobalFont, TitleFontSize*2/3 - 3, FontStyle.Regular), Brushes.Black, new Point(Xoffset + x, 10));
                    }
                    else if (pImage.Width - x < 40)
                    {
                        g.DrawLine(curPen, pImage.Width - 1, 0, pImage.Width - 1, pImage.Height);
                        g.DrawString(ConvertNumWeek(o), new Font(GlobalFont, TitleFontSize - 5, FontStyle.Regular), Brushes.Black, new Point(Xoffset + x, 20));
                    }
                    else
                    {
                        g.DrawLine(curPen, x, 0, x, pImage.Height);
                        g.DrawString(ConvertNumWeek(o), new Font(GlobalFont, TitleFontSize - 5, FontStyle.Regular), Brushes.Black, new Point(Xoffset + x, 20));
                    }
                    if(o==7)
                    {
                        g.DrawLine(curPen, pImage.Width - 1, 0, pImage.Width - 1, pImage.Height);
                    }
                    o++;
                }
 //               MessageBox.Show("DrawLinesModule2OK");
                Point Position = new Point();



                GregorianCalendar gregorianCalendar = new GregorianCalendar();
                int weekOfYear = gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) + Autos.DateOffset;
                for (int j = 0; j < 91; j++)
                {
                    ///跳过不在范围内的课程

                    if (weekOfYear > Lessons[j].weekE || weekOfYear < Lessons[j].weekS) continue;
                    ///

                    if (Lessons[j].Using)
                    {
                        Position.X = Xoffset + (ConvertWeekNum(Lessons[j].Weekday)) * XScale;
                        Position.Y = Yoffset + (int)(Lessons[j].id) * YScale;


                        int TitleSize = (int)(LessonFontSize * 0.7);
                        if (Lessons[j].Name.Length <= 4)
                        {
                            
                        }
                        else if (Lessons[j].Name.Length <= 6)
                        {
                            TitleSize = TitleSize * 9 / 10;
                        }
                        else if (Lessons[j].Name.Length <= 8)
                        {
                            TitleSize = TitleSize * 85 / 100;
                        }
                        else
                        {
                            TitleSize = TitleSize * 8 / 10;
                        }



                        
                        g.DrawString(Lessons[j].Name.Length <= DisplayLength ? Lessons[j].Name : (Lessons[j].Name.Substring(0, DisplayLength) +"...")
                            
                            + "\r\n",
                            new Font(GlobalFont,TitleSize, FontStyle.Bold), new SolidBrush(Lessons[j].Color)
                            , Position);
                        Position.Y += TitleSize *7/5;

                        String Content =
                        Convert.ToString(Lessons[j].h1) + ":";
                        if (Lessons[j].m1 == 0) Content += "0";
                        Content += Convert.ToString(Lessons[j].m1) + " - " +
                        Convert.ToString(Lessons[j].h2) + ":";
                        if (Lessons[j].m2 == 0) Content += "0";
                        Content += Convert.ToString(Lessons[j].m2) + "\r\n";
                        g.DrawString(Content, new Font(GlobalFont, (int)(LessonFontSize * 0.4), FontStyle.Bold), new SolidBrush(Lessons[j].Color), Position);
                        Position.Y += LessonFontSize * 2 / 3;

                        String Tips = Lessons[j].Tips;
                        //int offset = 0;
                        //for (int h = 1; h < Tips.Length; h++)
                        //{
                        //    if (h % (XScale / (LessonFontSize / 4 * 3)) == 0)
                        //    {
                        //        Tips = Tips.Insert(h + offset, Environment.NewLine);
                        //        offset = 2;
                        //    }
                        //}
                        Tips=Tips.Replace('#', '\n');
                        g.DrawString(Tips, new Font(GlobalFont, (int)(LessonFontSize * 0.4), FontStyle.Underline), new SolidBrush(Lessons[j].Color), Position);

                    }

                }
                //MessageBox.Show("DrawLinesModule3OK");
                pImage.Image = Img;
            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = "课程表";
            if (!File.Exists(Autos.DefaultFile))
            {
                StreamWriter CreateFile = new StreamWriter(Autos.DefaultFile);
                CreateFile.Close();
                CreateFile.Dispose();
            }

            //创建课程表

            button1.SetBounds(6, button1.Location.Y, button1.Width, button1.Height);
            button2.SetBounds(groupBox1.Width / 3, button2.Location.Y, button2.Width, button2.Height);
            button3.SetBounds(groupBox1.Width / 3 * 2, button3.Location.Y, button3.Width, button3.Height);
            for (int i=0;i<91;i++)
            {
                Lessons[i] = new Lesson();
            }

            Autos.AutoImportFile(Lessons,out Amount);

            Render();
            ///以绘图形式呈现
        }
        Lesson[] Lessons =new Lesson[91];
        int Amount = 0;
        decimal Id = 1;
        int WeekdayIndex = 1;
        int H = 8, M = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 Test = new Form2(Id, WeekdayIndex,H,M);
            Test.ShowDialog();
            if(Test.Done)
            {
                if (Test.LessonR.Using)
                {
                    Lessons[Amount] = Test.LessonR;
                    Amount++;
                    H++;
                    //MessageBox.Show(Convert.ToString(Test.LessonR.h1));
                    if (Test.checkBox1.Checked && Test.LessonR.id < 13)
                    {
                        //修改信息
                        Lesson LessonDouble = new Lesson(Test.LessonR);
                        LessonDouble.id++;
                        Time TmpTime = new Time();
                        TmpTime = GetTime((int)LessonDouble.id);
                        LessonDouble.h1 = TmpTime.H1;
                        LessonDouble.h2 = TmpTime.H2;
                        LessonDouble.m1 = TmpTime.M1;
                        LessonDouble.m2 = TmpTime.M2;
                        WeekdayIndex++;
                        if (WeekdayIndex + 1 == 8) WeekdayIndex = 1;
                        Id++;
                        WeekdayIndex = Test.WeekdayIndex + 1;

                        //Add
                        Lessons[Amount] = LessonDouble;
                        Amount++;
                        H++;
                    }



                }


                Render();
            }
            Id = Test.Id;
            WeekdayIndex = Test.WeekdayIndex;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            编辑课程 form3 = new 编辑课程(Lessons);
            form3.DateOffset = Autos.DateOffset;
            form3.ShowDialog();
            if (form3.Save)
            {
                int i = 0;
                Amount = 0;
                for (; i < 91; i++)
                {
                    Lessons[i] = form3.LessonList[i];
                    if (Lessons[i].Using) Amount++;
                }
                Autos.DateOffset = form3.DateOffset;
                Render();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sD.FileName = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Date.Month.ToString() + "月" + DateTime.Now.Date.Day.ToString() + "日保存的课程表";
            if (sD.ShowDialog() == DialogResult.OK)
            {
                pImage.Image.Save(sD.FileName);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            groupBox1.SetBounds(12, this.Height - 106, this.Width - 40, 55);
            button1.SetBounds(6, button1.Location.Y, button1.Width, button1.Height);
            button2.SetBounds(groupBox1.Width / 3, button2.Location.Y, button2.Width, button2.Height);
            button3.SetBounds(groupBox1.Width / 3*2, button3.Location.Y, button3.Width, button3.Height);
            pImage.SetBounds(12, 12, this.Width - 40, this.Height - 130);
            Render();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoSaveFile();
        }

        private void pImage_DoubleClick(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void pImage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void sD_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
