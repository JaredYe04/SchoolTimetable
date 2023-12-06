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
using System.Runtime.InteropServices.ComTypes;

namespace 课程表
{
    public partial class 编辑课程 : Form
    {
        Lesson[] List = new Lesson[91];
        public 编辑课程(Lesson[] LessonList)
        {
            for (int i = 0; i < 91; i++)
            {
                this.List[i] = LessonList[i];
            }
            InitializeComponent();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            saveDText.FileName = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Date.Month.ToString()+"月"+ DateTime.Now.Date.Day.ToString() + "日保存的课程表";
            if(saveDText.ShowDialog() == DialogResult.OK)
            {
                Autos.SaveFile(saveDText.FileName,List,listBox1.Items.Count);
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
                //before
                nWeekEnd.Value = List[listBox1.SelectedIndex].weekE;
                nWeekStart.Value = List[listBox1.SelectedIndex].weekS;  
                //2.23
                tTips.ForeColor=tName.ForeColor= dColor.Color = List[listBox1.SelectedIndex].Color;
                button2.BackColor = dColor.Color;
                button5.Enabled = false;
            }

        }
        void SaveChange(bool Replace)
        {
            List[listBox1.SelectedIndex].Name = tName.Text;
            List[listBox1.SelectedIndex].Tips = Replace ? tTips.Text.Replace('\n', '#') : tTips.Text;
            List[listBox1.SelectedIndex].Weekday = listBox2.Text;
            List[listBox1.SelectedIndex].h1 = nH1.Value;
            List[listBox1.SelectedIndex].h2 = nH2.Value;
            List[listBox1.SelectedIndex].m1 = nM1.Value;
            List[listBox1.SelectedIndex].m2 = nM2.Value;
            List[listBox1.SelectedIndex].id = nID.Value;

            List[listBox1.SelectedIndex].weekE = nWeekEnd.Value;
            List[listBox1.SelectedIndex].weekS = nWeekStart.Value;
            //2.23
            List[listBox1.SelectedIndex].Color = dColor.Color;
            Initialize();
            button5.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                SaveChange(true);
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

            decimal h1, m1, h2, m2;
            Autos.AutoTimetable(nID.Value, out h1, out m1, out h2, out m2);
            nH1.Value = h1;
            nH2.Value=h2;
            nM1.Value = m1;
            nM2.Value = m2;
            var color = Autos.AutoColor(nID.Value, tName.Text,checkRandom.Checked);

            tName.ForeColor = color;
            tTips.ForeColor = color;
            button2.ForeColor = color;
            button2.BackColor = color;

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

        
        private void button3_Click(object sender, EventArgs e)
        {
            if(openDText.ShowDialog()==DialogResult.OK)
            {
                Autos.ImportFile(openDText.FileName,List);
                Initialize();
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
            List[listBox1.Items.Count - 1].weekE = nWeekEnd.Value;
            List[listBox1.Items.Count - 1].weekS = nWeekStart.Value;


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
            Autos.AutoTimetable(Id, out tmp.H1, out tmp.M1, out tmp.H2, out tmp.M2);


            return tmp;
        }

        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        int indexName = 1, indexTeacher = 7, indexTime = 9, indexWeek = 8, indexAddress = 10;
        bool Match(string Raw,string Target)
        {
            return Raw.IndexOf(Target) != -1;
        }
        void LocateIndex(DataRow Columns)
        {
            for(int i=0;i<Columns.Table.Columns.Count;i++)
            {
                if (Match(Columns[i].ToString(), "名称"))
                {
                    indexName = i;
                }
                if (Match(Columns[i].ToString(), "师"))
                {
                    indexTeacher = i;
                }
                if (Match(Columns[i].ToString(), "时间"))
                {
                    indexTime = i;
                }
                if (Match(Columns[i].ToString(), "周"))
                {
                    indexWeek = i;
                }
                if (Match(Columns[i].ToString(), "地"))
                {
                    indexAddress = i;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {


            if(ImportExcel.ShowDialog()==DialogResult.OK)
            {

                DataSet ds = new DataSet();
                System.Data.DataTable dt = GetDataFromExcel(ImportExcel.FileName);
                ds.Tables.Add(dt);
//                MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());//1-课程名 7-老师 8-周次 9-时间 10-地址
                int i = 1;
                Lesson[] ImportList = new Lesson[91];
                for (int o = 0; o < 91; o++)
                {
                    ImportList[o] = new Lesson();
                }//初始化
                DataRow dataRow = null;
                Lesson TempLesson = new Lesson();///////不包含第几节课与星期几，需后面加
                Lesson PreviousLesson = new Lesson();///////不包含第几节课与星期几，需后面加
                LocateIndex(ds.Tables[0].Rows[0]);
                int offset = 0;
                while (ds.Tables[0].Rows.Count>i)
                {
                    dataRow = ds.Tables[0].Rows[i];

                    if (dataRow[1].ToString()=="")
                    {
                        TempLesson.Name = PreviousLesson.Name;
                        TempLesson.Tips = PreviousLesson.Tips;
                        TempLesson.weekS= PreviousLesson.weekS;
                        TempLesson.weekE= PreviousLesson.weekE;
                        ////连课，复制属性

                    }
                    else
                    {
                        TempLesson.Name = dataRow[indexName].ToString();
                        TempLesson.Tips = dataRow[indexTeacher].ToString() + " " + dataRow[indexAddress].ToString()+"#"+ dataRow[indexWeek].ToString();
                        decimal S, E;
                        Autos.AutoWeekRegex(out S, out E, dataRow[indexWeek].ToString());
                        TempLesson.weekS= S;
                        TempLesson.weekE= E;

                        PreviousLesson =new Lesson(TempLesson);
                    }
                    if(dataRow[indexTime].ToString()!="")
                    TempLesson.Weekday = dataRow[indexTime].ToString().Substring(0, 2);
                    //MessageBox.Show(TempLesson.Name);//DEBUG

                    //MessageBox.Show(TempLesson.Tips);//DEBUG

                    //转换时间
                    string[] Times = dataRow[indexTime].ToString().Split('.');////周几1,2,3节blabla
                    for (int j=0; j < Times.Length; j++)///////重复课
                    {
                        if(dataRow[indexTime].ToString() != "")
                        if(IsNumeric(Times[j].ToString().Substring(0,1)))
                        {
                            ImportList[offset].Weekday = Times[0];
                            ImportList[offset].SetTime(GetTime(Convert.ToInt16(Times[j].ToString().Replace("节",""))));
                            ImportList[offset].id = Convert.ToInt16(Times[j].ToString().Replace("节", ""));


                                ImportList[offset].Color = Autos.AutoColor(TempLesson.id, TempLesson.Name, checkRandom.Checked);
                                ImportList[offset].weekE = TempLesson.weekE;
                                ImportList[offset].weekS = TempLesson.weekS;

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

        readonly string[] TemplateStrings = { "课程名称", "学分", "任课教师", "上课周次", "上课时间", "上课地点" },
                            TemplateContent = { "微积分上", "3", "小明", "1-16周", "周二.1.2节", "松1001" };

        private void button10_Click(object sender, EventArgs e)
        {
            
            foreach(var Lesson in List)
            {
                Lesson.Color = Autos.AutoColor(Lesson.id, Lesson.Name, true);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (saveTemplateSheet.ShowDialog(this) != DialogResult.OK)return;
            Excel.Application app = new Excel.Application();
            object oMissiong = Missing.Value;
            try
            {
                app.Application.Workbooks.Add(true);
                app.Application.Sheets.Add();
                int i = 1;
                foreach(string str in TemplateStrings)
                {
                    app.Application.Cells[1, i++] = str;
                }
                i = 1;
                foreach (string str in TemplateContent)
                {
                    app.Application.Cells[2, i++] = str;
                }
                app.Application.Sheets[1].SaveAs(saveTemplateSheet.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("导出成功！请根据模板示例复制已选课程信息。\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception E)
            {
                MessageBox.Show("发生错误！\n" + E.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                app.Workbooks.Close();
                app.Quit();
                Marshal.ReleaseComObject(app);
                app = null;
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

        private void nWeekEnd_ValueChanged(object sender, EventArgs e)
        {
            nWeekStart.Value = nWeekEnd.Value < nWeekStart.Value ? nWeekEnd.Value : nWeekStart.Value;
            button5.Enabled = true;
        }

        private void nWeekStart_ValueChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }
    }
}
