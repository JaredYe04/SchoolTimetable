using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Xml.Linq;
using System.Windows;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;

namespace 课程表
{
    public static class Autos
    {

        public static void ImportFile(String FileName,Lesson[] List)
        {
            try
            {
                Lesson[] ReadLessons = new Lesson[91];
                for (int i = 0; i < ReadLessons.Length; i++)
                {
                    ReadLessons[i] = new Lesson();
                }
                StreamReader streamReader = new StreamReader(FileName);
                string Line = "";

                // 从文件读取并显示行，直到文件的末尾 
                int Num = 0;

                while ((Line = streamReader.ReadLine()) != null)
                {
                    if (Line.Length > 5)//防止空行
                    {
                        String[] Array = Line.Split('|');
                        ReadLessons[Num].Name = Array[0];
                        ReadLessons[Num].Weekday = Array[1];
                        ReadLessons[Num].Tips = Array[2].Replace('#', '\n');
                        ReadLessons[Num].Color = System.Drawing.Color.FromArgb(Convert.ToInt32(Array[3]));
                        ReadLessons[Num].id = Convert.ToDecimal(Array[4]);
                        String[] Time = Array[5].Split('$');
                        ReadLessons[Num].h1 = Convert.ToInt32(Time[0]);
                        ReadLessons[Num].m1 = Convert.ToInt32(Time[1]);
                        ReadLessons[Num].h2 = Convert.ToInt32(Time[2]);
                        ReadLessons[Num].m2 = Convert.ToInt32(Time[3]);

                        ReadLessons[Num].weekS = Convert.ToInt32(Time[4]);
                        ReadLessons[Num].weekE = Convert.ToInt32(Time[5]);


                        ReadLessons[Num].Using = true;
                        Num++;
                    }

                }
                for (int i = 0; i < 91; i++)
                {
                    List[i] = ReadLessons[i];

                }
                streamReader.Close();
                streamReader.Dispose();
            }
            catch
            {
                MessageBox.Show("文件读取出了点小问题...", "提示");
            }
        }
        public static int DateOffset = 0;
        public static void SaveFile(string Filename, Lesson[] List,int Count)//Form1也要改
        {
            String Content = "";
            Content += Convert.ToString(DateOffset) + Environment.NewLine;
            for (int i = 0; i < Count; i++)
            {
                Content += List[i].Name;
                Content += "|";
                Content += List[i].Weekday;
                Content += "|";
                Content += List[i].Tips.Replace('\n', '#');
                Content += "|";
                Content += List[i].Color.ToArgb();
                Content += "|";
                Content += List[i].id;
                Content += "|";
                Content += Convert.ToString(List[i].h1) + "$";
                Content += Convert.ToString(List[i].m1) + "$";
                Content += Convert.ToString(List[i].h2) + "$";
                Content += Convert.ToString(List[i].m2) + "$";
                Content += Convert.ToString(List[i].weekS) + "$";
                Content += Convert.ToString(List[i].weekE);
                Content += Environment.NewLine;
            }
            StreamWriter streamWriter = new StreamWriter(Filename);
            streamWriter.WriteLine(Content);
            streamWriter.Close();
        }
        public static void AutoImportFile( Lesson[] Lessons,out int Amount,string FileName = "C:\\ProgramData\\课程表.txt")
        {
            try
            {
                Amount = 0;
                Lesson[] ReadLessons = new Lesson[91];
                for (int i = 0; i < ReadLessons.Length; i++)
                {
                    ReadLessons[i] = new Lesson();
                }
                StreamReader streamReader = new StreamReader(FileName);
                string Line;
                Line = streamReader.ReadLine();
                if (Line != null) DateOffset = Convert.ToInt32(Line);
                // 从文件读取并显示行，直到文件的末尾 
                int Num = 0;
                while ((Line = streamReader.ReadLine()) != null)
                {
                    if (Line.Length > 5)//防止空行
                    {
                        String[] Array = Line.Split('|');
                        ReadLessons[Num].Name = Array[0];
                        ReadLessons[Num].Weekday = Array[1];
                        ReadLessons[Num].Tips = Array[2];
                        ReadLessons[Num].Color = System.Drawing.Color.FromArgb(Convert.ToInt32(Array[3]));
                        ReadLessons[Num].id = Convert.ToDecimal(Array[4]);
                        String[] Time = Array[5].Split('$');
                        ReadLessons[Num].h1 = Convert.ToInt32(Time[0]);
                        ReadLessons[Num].m1 = Convert.ToInt32(Time[1]);
                        ReadLessons[Num].h2 = Convert.ToInt32(Time[2]);
                        ReadLessons[Num].m2 = Convert.ToInt32(Time[3]);
                        ReadLessons[Num].weekS = Convert.ToInt32(Time[4]);
                        ReadLessons[Num].weekE = Convert.ToInt32(Time[5]);


                        ReadLessons[Num].Using = true;
                        Num++;
                        Amount++;
                    }

                }
                for (int i = 0; i < 91; i++)
                {
                    Lessons[i] = ReadLessons[i];

                }
                streamReader.Close();
                streamReader.Dispose();
            }
            catch
            {
                MessageBox.Show("出了点小问题...", "提示");
                Amount = 0;
            }
            finally { }

        }

        public static string DefaultFile = "C:\\ProgramData\\课程表.txt";
        public static void AutoWeekRegex(out decimal WeekStart, out decimal WeekEnd, string RawString)
        {
            string pattern = @"\d+";
            var num= Regex.Matches(RawString, pattern);
            try
            {
                WeekStart = Convert.ToDecimal(num[0].Value);
                WeekEnd = Convert.ToDecimal(num[1].Value);
            }
            catch { WeekEnd = WeekStart = 1; }

        }
        //private static bool Match(string Input, string[] List)
        //{
        //    foreach(var item in List)
        //    {
        //        if (-1 != Input.IndexOf(item)) return true;
        //    }
        //    return false;
        //}
        static int[] ColorArray = { 0x1C3C56 ,0x4C7AE6,0x22596E,
                                    0x2579D8,0xFF8F35,0x372E43,
                                    0xBB323D,0x609351,0xD25735,
                                    0x423D37,0xF78B31,0x9D3627};
        public static System.Drawing.Color AutoColor(decimal id,string name,bool random)
        {
            var res = new System.Drawing.Color();

            if (random)
            {
                Random random1= new Random(name.GetHashCode());

                res = System.Drawing.Color.FromArgb(
                    ColorArray[random1.Next() % ColorArray.Length]
                    );
                res = System.Drawing.Color.FromArgb(255, res);
            }
            else
            {
                if (id <= 4)
                {
                    res = System.Drawing.Color.Black;
                }
                else if (id <= 9)
                {
                    res = System.Drawing.Color.Brown;
                }
                else
                {
                    res = System.Drawing.Color.DarkBlue;
                }
            }

            return res;
        }
        public static void AutoTimetable(decimal Id, out decimal H1, out decimal M1, out decimal H2, out decimal M2)
        {
            switch (Id)
            {
                case 1:
                    H1 = 8;
                    M1 = 15;
                    H2 = 9;
                    M2 = 0;
                    break;
                case 2:
                    H1 = 9;
                    M1 = 0;
                    H2 = 9;
                    M2 = 45;
                    break;
                case 3:
                    H1 = 10;
                    M1 = 5;
                    H2 = 10;
                    M2 = 50;
                    break;
                case 4:
                    H1 = 10;
                    M1 = 50;
                    H2 = 11;
                    M2 = 35;
                    break;
                case 5:
                    H1 = 13;
                    M1 = 0;
                    H2 = 13;
                    M2 = 45;
                    break;
                case 6:
                    H1 = 13;
                    M1 = 45;
                    H2 = 14;
                    M2 = 30;
                    break;
                case 7:
                    H1 = 14;
                    M1 = 50;
                    H2 = 15;
                    M2 = 35;
                    break;
                case 8:
                    H1 = 15;
                    M1 = 35;
                    H2 = 16;
                    M2 = 20;
                    break;
                case 9:
                    H1 = 16;
                    M1 = 20;
                    H2 = 17;
                    M2 = 5;
                    break;
                case 10:
                    H1 = 18;
                    M1 = 0;
                    H2 = 18;
                    M2 = 45;
                    break;
                case 11:
                    H1 = 18;
                    M1 = 45;
                    H2 = 19;
                    M2 = 30;
                    break;
                case 12:
                    H1 = 19;
                    M1 = 50;
                    H2 = 20;
                    M2 = 35;
                    break;
                case 13:
                    H1 = 20;
                    M1 = 35;
                    H2 = 21;
                    M2 = 20;
                    break;
                default:
                    H1 = 0;
                    M1 = 0;
                    H2 = 0;
                    M2 = 0;
                    break;
            }
        }
    }
    public class Time
    {
        public decimal H1 = 0, H2 = 0, M1 = 0, M2 = 0;

        public Time()
        {

        }
        public Time(decimal h1, decimal h2, decimal m1, decimal m2)
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
        public decimal weekS = 1, weekE = 16;
        public bool Using=false;
        public System.Drawing.Color Color = System.Drawing.Color.Black;
        public Lesson(string weekday, decimal id, string name, string tips,
            decimal h1, decimal h2, decimal m1, decimal m2, decimal weekS,
            decimal weekE, System.Drawing.Color color)
        {
            Weekday = weekday;
            this.id = id;
            Name = name;
            Tips = tips;
            this.h1 = h1;
            this.h2 = h2;
            this.m1 = m1;
            this.m2 = m2;
            this.weekS = weekS;
            this.weekE = weekE;
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
            weekE = FromLesson.weekE;
            weekS = FromLesson.weekS;
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
