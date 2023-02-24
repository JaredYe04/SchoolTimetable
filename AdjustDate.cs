using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程表
{
    public partial class AdjustDate : Form
    {
        public AdjustDate()
        {
            InitializeComponent();
        }

        private void AdjustDate_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateOffset;
            GregorianCalendar gregorianCalendar = new GregorianCalendar();
            int weekOfYear = gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) + DateOffset;
            label1.Text= "当前是校历第"+weekOfYear+"周";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DateOffset = (int)numericUpDown1.Value;
            GregorianCalendar gregorianCalendar = new GregorianCalendar();
            int weekOfYear = gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) + DateOffset;
            label1.Text = "当前是校历第" + weekOfYear + "周";
        }
    }
}
