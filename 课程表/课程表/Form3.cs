using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace 课程表
{
    public partial class Form3 : Form
    {
        Lesson[] List = new Lesson[91];
        public Form3(Lesson[] LessonList)
        {
            for (int i = 0; i < 91; i++)
            {
                this.List[i] = LessonList[i];
            }
            InitializeComponent();
        }
        
        void SaveFile(string Filename)
        {
            String Content = "";
            Content += Convert.ToString(DateOffset) + Environment.NewLine;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Content += List[i].Name;
                Content += "|";
                Content += List[i].Weekday;
                Content += "|";
                Content += List[i].Tips;
                Content += "|";
                Content += List[i].Color.ToArgb();
                Content += "|";
                Content += List[i].id;
                Content += "|";
                Content += Convert.ToString(List[i].h1) + "$";
                Content += Convert.ToString(List[i].m1) + "$";
                Content += Convert.ToString(List[i].h2) + "$";
                Content += Convert.ToString(List[i].m2);
                Content += Environment.NewLine;
            }
            StreamWriter streamWriter = new StreamWriter(Filename);
            streamWriter.WriteLine(Content);
            streamWriter.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sD.FileName = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Date.Month.ToString()+"月"+ DateTime.Now.Date.Day.ToString() + "日保存的课程表";
            if(sD.ShowDialog() == DialogResult.OK)
            {
                SaveFile(sD.FileName);
            }
        }
        void Initialize()
        {
            Save = false;
            listBox1.Items.Clear();
            String Content = "";
            
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].Using)
                {

                    Content += List[i].Name + "|";

                    Content += Convert.ToString(List[i].h1) + ":";
                    if (List[i].m1 == 0) Content += "0";
                    Content += Convert.ToString(List[i].m1) + " - " +
                    Convert.ToString(List[i].h2) + ":";
                    if (List[i].m2 == 0) Content += "0";
                    Content += Convert.ToString(List[i].m2) + "|";
                    Content += List[i].Weekday;
                    listBox1.Items.Add(Content);
                    Content = "";
                }
            }
            button5.Enabled = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i=0; i < List.Length;i++)
            {
                this.LessonList[i] = List[i];
            }
            Save = true;
            this.Close();
        }
        String ConvertNumWeek(int Num)
        {
            switch (Num)
            {
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(button5.Enabled)
            {
                MessageBox.Show("更改未保存！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if(this.listBox1.SelectedIndex>=0)
            {
                tName.Text = List[listBox1.SelectedIndex].Name;
                tTips.Text = List[listBox1.SelectedIndex].Tips;
                listBox2.SelectedItems.Clear();
                listBox2.SetSelected(ConvertWeekNum(List[listBox1.SelectedIndex].Weekday) - 1, true);
                nH1.Value = List[listBox1.SelectedIndex].h1;
                nH2.Value = List[listBox1.SelectedIndex].h2;
                nM1.Value = List[listBox1.SelectedIndex].m1;
                nM2.Value = List[listBox1.SelectedIndex].m2;
                nID.Value = List[listBox1.SelectedIndex].id;
                tTips.ForeColor=tName.ForeColor= dColor.Color = List[listBox1.SelectedIndex].Color;
                button2.BackColor = dColor.Color;
                button5.Enabled = false;
            }

        }
        void SaveChange()
        {
            List[listBox1.SelectedIndex].Name = tName.Text;
            List[listBox1.SelectedIndex].Tips = tTips.Text;
            List[listBox1.SelectedIndex].Weekday = listBox2.Text;
            List[listBox1.SelectedIndex].h1 = nH1.Value;
            List[listBox1.SelectedIndex].h2 = nH2.Value;
            List[listBox1.SelectedIndex].m1 = nM1.Value;
            List[listBox1.SelectedIndex].m2 = nM2.Value;
            List[listBox1.SelectedIndex].id = nID.Value;
            List[listBox1.SelectedIndex].Color = dColor.Color;
            Initialize();
            button5.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==-1)
            {
                List[listBox1.Items.Count].Name = tName.Text;
                List[listBox1.Items.Count].Tips = tTips.Text.Replace('\n', '#');
                List[listBox1.Items.Count].Weekday = listBox2.Text;
                List[listBox1.Items.Count].h1 = nH1.Value;
                List[listBox1.Items.Count].h2 = nH2.Value;
                List[listBox1.Items.Count].m1 = nM1.Value;
                List[listBox1.Items.Count].m2 = nM2.Value;
                List[listBox1.Items.Count].id = nID.Value;
                List[listBox1.Items.Count].Color = dColor.Color;
                List[listBox1.Items.Count].Using = true;
                Initialize();
                button5.Enabled = false;
            }
            else
            {
                SaveChange();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dColor.ShowDialog();
            tName.ForeColor = dColor.Color;
            tTips.ForeColor = dColor.Color;
            button2.ForeColor = dColor.Color;
            button2.BackColor = dColor.Color;
            button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(listBox1.SelectedIndex!=-1)
            {
                List[listBox1.SelectedIndex] = new Lesson();
                for (int i = listBox1.SelectedIndex; i < 48; i++)
                {
                    List[i] = List[i + 1];
                }
                int SIndex = listBox1.SelectedIndex;
                listBox1.Items.Remove(SIndex);
                if (listBox1.Items.Count >= 1)

                    Initialize();
                if (SIndex >= 1)
                {
                    listBox1.SetSelected(SIndex - 1, true);
                }
            }
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void nH1_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void nM1_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void nH2_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void nM2_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void nID_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;

            switch (nID.Value)
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

            if (nID.Value <= 4)
            {
                tName.ForeColor = System.Drawing.Color.Black;
                tTips.ForeColor = System.Drawing.Color.Black;
                button2.ForeColor = System.Drawing.Color.Black;
                button2.BackColor = System.Drawing.Color.Black;
            }
            else if (nID.Value <= 9)
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

        private void tTips_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
                for (int i = 0; i < List.Length; i++)
                {
                    this.LessonList[i] = List[i];
                }
                Save = true;
        }

        void ImportFile(String FileName)
        {
                Lesson[] ReadLessons= new Lesson[91];
                for (int i = 0; i < ReadLessons.Length; i++)
                {
                    ReadLessons[i] = new Lesson();
                }
                StreamReader streamReader = new StreamReader(oD.FileName);
                string Line="";

                // 从文件读取并显示行，直到文件的末尾 
                int Num = 0;
                while ((Line = streamReader.ReadLine()) != null)
                {
                    if(Line.Length > 5)//防止空行
                    {
                        String[] Array = Line.Split('|');
                        ReadLessons[Num].Name = Array[0];
                        ReadLessons[Num].Weekday = Array[1];
                        ReadLessons[Num].Tips = Array[2].Replace('#', '\n');
                        ReadLessons[Num].Color = Color.FromArgb(Convert.ToInt32(Array[3]));
                        ReadLessons[Num].id = Convert.ToDecimal(Array[4]);
                        String[] Time = Array[5].Split('$');
                        ReadLessons[Num].h1 = Convert.ToInt32(Time[0]);
                        ReadLessons[Num].m1 = Convert.ToInt32(Time[1]);
                        ReadLessons[Num].h2 = Convert.ToInt32(Time[2]);
                        ReadLessons[Num].m2 = Convert.ToInt32(Time[3]);
                        ReadLessons[Num].Using = true;
                        Num++;
                    }

                }
                for (int i=0;i<91;i++)
                {
                    List[i] = ReadLessons[i];
                    
                }
                streamReader.Close();
                streamReader.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(oD.ShowDialog()==DialogResult.OK)
            {
                ImportFile(oD.FileName);
                Initialize();
                //Content += List[i].Name;
                //Content += "|";
                //Content += List[i].Weekday;
                //Content += "|";
                //Content += List[i].Tips;
                //Content += "|";
                //Content += List[i].Color.ToArgb();
                //Content += "|";
                //Content += Convert.ToString(List[i].h1) + "$";
                //Content += Convert.ToString(List[i].m1) + "$";
                //Content += Convert.ToString(List[i].h2) + "$";
                //Content += Convert.ToString(List[i].m2);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox1.Text);
            List[listBox1.Items.Count - 1 ].Name = tName.Text;
            List[listBox1.Items.Count - 1].Tips = tTips.Text;
            List[listBox1.Items.Count - 1].id = nID.Value;
            List[listBox1.Items.Count - 1].Weekday = listBox2.Text;
            List[listBox1.Items.Count - 1].h1 = nH1.Value;
            List[listBox1.Items.Count - 1].h2 = nH2.Value;
            List[listBox1.Items.Count - 1].m1 = nM1.Value;
            List[listBox1.Items.Count - 1].m2 = nM2.Value;
            List[listBox1.Items.Count - 1].Color = dColor.Color;
            List[listBox1.Items.Count - 1].Using = true;//Using一定要加！！
            listBox1.SetSelected(listBox1.Items.Count-1, true);
        }

        //public static DataSet ToDataTable(string filePath)
        //{
        //    string connStr = "";
        //    string fileType = System.IO.Path.GetExtension(filePath);////////后缀名
        //    if (string.IsNullOrEmpty(fileType)) return null;

        //    if (fileType == ".xls")
        //        connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
        //    else
        //        connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
        //    string sql_F = "Select * FROM [{0}]";

        //    OleDbConnection conn = null;
        //    OleDbDataAdapter da = null;
        //    System.Data.DataTable dtSheetName = null;

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        // 初始化连接，并打开
        //        conn = new OleDbConnection(connStr);
        //        conn.Open();

        //        // 获取数据源的表定义元数据                        
        //        string SheetName = "";
        //        dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

        //        // 初始化适配器
        //        da = new OleDbDataAdapter();
        //        for (int i = 0; i < dtSheetName.Rows.Count; i++)
        //        {
        //            SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];

        //            if (SheetName.Contains("$") && !SheetName.Replace("'", "").EndsWith("$"))
        //            {
        //                continue;
        //            }

        //            da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
        //            DataSet dsItem = new DataSet();
        //            da.Fill(dsItem, "Sheet1");/////tablename

        //            ds.Tables.Add(dsItem.Tables[0].Copy());
        //        }
        //    }
        //    finally
        //    {
        //        // 关闭连接
        //        if (conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //            da.Dispose();
        //            conn.Dispose();
        //        }
        //    }
        //    return ds;
        //}

        System.Data.DataTable GetDataFromExcel(string FileName,bool hasTitle = false)
        {
            var excelFilePath = FileName;

            Excel.Application app = new Excel.Application();
            Sheets sheets;
            object oMissiong = Missing.Value;
            Workbook workbook = null;
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                if (app == null) return null;
                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;

                //将数据读入到DataTable中
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);//读取第一张表  
                if (worksheet == null) return null;

                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                //生成列头
                for (int i = 0; i < iColCount; i++)
                {
                    var name = "column" + i;
                    if (hasTitle)
                    {
                        var txt = ((Excel.Range)worksheet.Cells[1, i + 1]).Text.ToString();
                        if (!string.IsNullOrWhiteSpace(txt)) name = txt;
                    }
                    while (dt.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
                    dt.Columns.Add(new DataColumn(name, typeof(string)));
                }
                //生成行数据
                Range range;
                int rowIdx = hasTitle ? 2 : 1;
                for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dt.NewRow();
                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                        range = (Range)worksheet.Cells[iRow, iCol];
                        dr[iCol - 1] = (range.Value2 == null) ? "" : range.Text.ToString();
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch { return null; }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                Marshal.ReleaseComObject(app);
                app = null;
            }
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

        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if(ImportExcel.ShowDialog()==DialogResult.OK)
            {

                DataSet ds = new DataSet();
                System.Data.DataTable dt = GetDataFromExcel(ImportExcel.FileName);
                ds.Tables.Add(dt);
//                MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());//1-课程名 7-老师 8-周次 9-时间 10-地址
                int i = 0;
                Lesson[] ImportList = new Lesson[91];
                for (int o = 0; o < 91; o++)
                {
                    ImportList[o] = new Lesson();
                }//初始化
                DataRow dataRow = null;
                Lesson TempLesson = new Lesson();///////不包含第几节课与星期几，需后面加
                Lesson PreviousLesson = new Lesson();///////不包含第几节课与星期几，需后面加
                int offset = 0;
                while (ds.Tables[0].Rows.Count>i)
                {
                    dataRow = ds.Tables[0].Rows[i];

                    if (dataRow[1].ToString()=="")
                    {
                        TempLesson.Name = PreviousLesson.Name;
                        TempLesson.Tips = PreviousLesson.Tips;
                    }
                    else
                    {
                        TempLesson.Name = dataRow[1].ToString();
                        TempLesson.Tips = dataRow[7].ToString() + " " + dataRow[10].ToString()+"#"+ dataRow[8].ToString();
                        PreviousLesson =new Lesson(TempLesson);
                    }
                    if(dataRow[9].ToString()!="")
                    TempLesson.Weekday = dataRow[9].ToString().Substring(0, 2);
                    //MessageBox.Show(TempLesson.Name);//DEBUG

                    //MessageBox.Show(TempLesson.Tips);//DEBUG

                    //转换时间
                    string[] Times = dataRow[9].ToString().Split('.');////周几1,2,3节blabla
                    for (int j=0; j < Times.Length; j++)///////重复课
                    {
                        if(dataRow[9].ToString() != "")
                        if(IsNumeric(Times[j].ToString().Substring(0,1)))
                        {
                            ImportList[offset].Weekday = Times[0];
                            ImportList[offset].SetTime(GetTime(Convert.ToInt16(Times[j].ToString().Replace("节",""))));
                            ImportList[offset].id = Convert.ToInt16(Times[j].ToString().Replace("节", ""));

                            if (ImportList[offset].id <= 4)
                            {
                                ImportList[offset].Color = System.Drawing.Color.Black;
                            }
                            else if (ImportList[offset].id <= 9)
                            {
                                ImportList[offset].Color = System.Drawing.Color.Brown;
                            }
                            else
                            {
                                ImportList[offset].Color = System.Drawing.Color.DarkBlue;
                            }
                            ImportList[offset].Name = TempLesson.Name;
                            ImportList[offset].Tips = TempLesson.Tips;
                            ImportList[offset].Weekday = TempLesson.Weekday;
                            ImportList[offset].Using = true;
          //                  ImportList[offset].ShowDebugInfo();//////debug
                            offset ++;
                        }
                        
                    }
                    
                    //周次模块下次做

                    //ImportList[i].Using = true;
                    i++;
                }

                for(int j=0;j<91;j++)
                {
                    List[j] = new Lesson(ImportList[j]);
                }
                Initialize();

            }
        }


        
        private void ImportExcel_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdjustDate adjustDate = new AdjustDate();
            adjustDate.DateOffset = DateOffset;
            adjustDate.ShowDialog();
            DateOffset =adjustDate.DateOffset;
        }
    }
}
