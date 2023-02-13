using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Xml.Linq;
using System.Windows;

namespace 课程表
{
    public class Time
    {
        public int H1 = 0, H2 = 0, M1 = 0, M2 = 0;

        public Time()
        {

        }
        public Time(int h1, int h2, int m1, int m2)
        {
            H1 = h1;
            H2 = h2;
            M1 = m1;
            M2 = m2;
        }
    }


    public class Lesson
    {
        public string Weekday = "周一";
        public decimal id =1;
        public string Name = "";
        public string Tips = "";
        public decimal h1, h2, m1, m2 = 0;
        public bool Using=false;
        public System.Drawing.Color Color = System.Drawing.Color.Black;
        public Lesson(string weekday, decimal id, string name, string tips, decimal h1, decimal h2, decimal m1, decimal m2, System.Drawing.Color color)
        {
            Weekday = weekday;
            this.id = id;
            Name = name;
            Tips = tips;
            this.h1 = h1;
            this.h2 = h2;
            this.m1 = m1;
            this.m2 = m2;
            Using = true;
            Color = color;
        }
        public Lesson(Lesson FromLesson)
        {
            Weekday = FromLesson.Weekday;
            id = FromLesson.id;
            Name = FromLesson.Name;
            Tips = FromLesson.Tips;
            h1 = FromLesson.h1;
            h2 = FromLesson.h2;
            m1 = FromLesson.m1;
            m2 = FromLesson.m2;
            Using = FromLesson.Using;
            Color = FromLesson.Color;
        }
        public void SetTime(Time FromTime)
        {
            h1 = FromTime.H1;
            h2 = FromTime.H2;
            m1 = FromTime.M1;
            m2 = FromTime.M2;
        }

        public void ShowDebugInfo()
        {
            MessageBox.Show(Name + " " + Tips + Weekday + Convert.ToString(id));
        }

        public Lesson()
        {

        }
    }
}
