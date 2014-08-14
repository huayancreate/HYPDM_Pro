using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.ProjectManage.ProjectCalendarBuild
{
    public partial class ProjectCalendar : DevExpress.XtraEditors.XtraForm
    {
        public ProjectBo project { get; set; }
        private PanelControl NumberBox; //日历边框
        private LabelControl Number;//日历数字
        private LabelControl Sign;//日历"休"或"班"字符
        private List<WorkDateBo> specialdate;
        private List<WorkTimeBo> worktimes;
        private WeekBo week;
        public ProjectCalendar()
        {
            InitializeComponent();
        }
        private void ProjectCalendar_Load(object sender, EventArgs e)
        {
            ProjectCalendarBo calendarSetting = WcfServiceLocator.Create<IProjectCalendarService>().getProjectCalendarByProjectId(1);
            worktimes = calendarSetting.TimeSlot;
            specialdate = calendarSetting.DateState;
            week = calendarSetting.Week;
            gcWorkTime.DataSource = worktimes;
            if (project != null)
            {

                btnProjectName.Properties.ReadOnly = false;
                txtStartTime.Enabled = false;
                btnProjectName.Text = project.Name;
                txtStartTime.Text = project.StartTime;
                DateTime starttime = Convert.ToDateTime(project.StartTime);
                cmbYear.Text = starttime.Year + "年";
                cmbMonth.Text = starttime.Month + "月";
            }
            SetCalendar();
            lblSunday.ForeColor = Color.FromArgb(255, 70, 50);
            lblSaturday.ForeColor = Color.FromArgb(255, 70, 50);
            chkSunday.Checked = week.Sunday;
            chkMonday.Checked = week.Monday;
            chkTuesday.Checked = week.Tuesday;
            chkWednesday.Checked = week.Wednesday;
            chkThursday.Checked = week.Thursday;
            chkFriday.Checked = week.Friday;
            chkSaturday.Checked = week.Saturday;
        }
        /// <summary>
        /// 应用到这个项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            ProjectCalendarBo projectcalendar = new ProjectCalendarBo();
            projectcalendar.Week = week;
            projectcalendar.TimeSlot = worktimes;
            bool isSuccess = WcfServiceLocator.Create<IProjectCalendarService>().saveProjectCalendarByProjectId(projectcalendar, project.Id);
        }
        /// <summary>
        /// 选择年和月出发时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearAndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCalendar();
        }
        /// <summary>
        /// 初始化日历
        /// </summary>
        private void SetCalendar()
        {
            pc0.Controls.Clear();//清除日历数据
            int year = Convert.ToInt32(cmbYear.Text.Replace("年", ""));//年
            int month = Convert.ToInt32(cmbMonth.Text.Replace("月", ""));//月
            int day = 1;//日期中的天
            int cnum = 0;//日历中的格子,共42个
            int days = DateTime.DaysInMonth(year, month);//每月的天数
            DayOfWeek dayweek = new DateTime(year, month, day).DayOfWeek;//每月一号是星期几

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    PanelControl date = new PanelControl();//日期边框
                    date.Tag = true;
                    date.Name = "c" + x + y;
                    date.Location = new Point(x * 50, y * 50);
                    date.Size = new Size(50, 50);
                    date.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                    LabelControl sign = new LabelControl();//日期上的休字
                    sign.Name = "r" + x + y; ;
                    sign.Location = new Point(3, 3);
                    sign.Tag = true;
                    sign.Font = new Font("Tahoma", 7.5f);
                    LabelControl number = new LabelControl();//日期数字
                    number.Name = "s" + x + y;
                    number.Tag = true;
                    number.Location = new Point(11, 11);
                    number.Font = new Font("微软雅黑", 18);
                    if (cnum >= (int)dayweek && cnum - (int)dayweek < days)//每月一号开始到月末连续填充数据
                    {
                        number.Text = string.Format("{0:00}", day++);
                        date.MouseClick += new MouseEventHandler(date_MouseClick);
                        date.MouseEnter += new EventHandler(date_MouseEnter);
                        date.MouseLeave += new EventHandler(date_MouseLeave);
                        sign.MouseClick += new MouseEventHandler(date_MouseClick);
                        sign.MouseEnter += new EventHandler(date_MouseEnter);
                        sign.MouseLeave += new EventHandler(date_MouseLeave);
                        number.MouseClick += new MouseEventHandler(date_MouseClick);
                        number.MouseEnter += new EventHandler(date_MouseEnter);
                        number.MouseLeave += new EventHandler(date_MouseLeave);
                    }
                    else
                    {
                        date.Visible = false;
                    }
                    if (x == 0 || x == 6)//判断是否是周末
                    {
                        Rest(date, number, sign);
                    }
                    //设置调动的上班休息时间
                    foreach (WorkDateBo workdate in specialdate)
                    {
                        DateTime dt = Convert.ToDateTime(workdate.Time);
                        if (dt.Year == year && dt.Month == month && dt.Day == day - 1)
                        {
                            if (workdate.State.Equals("休")) Rest(date, number, sign);
                            if (workdate.State.Equals("班")) Work(date, number, sign);
                        }
                    }
                    date.Controls.Add(sign);
                    date.Controls.Add(number);
                    pc0.Controls.Add(date);
                    cnum++;
                }
            }
        }

        /// <summary>
        /// 单击返回今天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            cmbYear.Text = DateTime.Now.Year + "年";
            cmbMonth.Text = DateTime.Now.Month + "月";
        }
        /// <summary>
        /// 右键日期弹出菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control control = (Control)sender;
                if ((bool)(control.Tag))
                {
                    biWork.Enabled = false;
                    biWeekend.Enabled = true;
                }
                else
                {
                    biWork.Enabled = true;
                    biWeekend.Enabled = false;
                }

                if (control.Name.Contains("s"))//Symbol 数字
                {
                    string r = control.Name.Replace("s", "r");
                    NumberBox = control.Parent as PanelControl;
                    Number = control as LabelControl;
                    Sign = control.Parent.Controls.Find(r, true)[0] as LabelControl;
                }
                else if (control.Name.Contains("c"))//Calendar 外边框
                {
                    string r = control.Name.Replace("c", "r");
                    string s = control.Name.Replace("c", "s");
                    NumberBox = control as PanelControl;
                    Number = control.Parent.Controls.Find(s, true)[0] as LabelControl;
                    Sign = control.Parent.Controls.Find(r, true)[0] as LabelControl;
                }
                else if (control.Name.Contains("r"))//Rest 休息字符
                {
                    string s = control.Name.Replace("r", "s");
                    NumberBox = control.Parent as PanelControl;
                    Number = control.Parent.Controls.Find(s, true)[0] as LabelControl;
                    Sign = control as LabelControl;
                }
                pmWorkTime.ShowPopup(bmMessage, Control.MousePosition);
            }
        }
        /// <summary>
        /// 鼠标进入日历是效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_MouseEnter(object sender, EventArgs e)
        {
            PanelControl pc = null;
            Control control = (Control)sender;
            if (control.Name.Contains("s"))//Symbol 数字
            {
                pc = control.Parent as PanelControl;
            }
            else if (control.Name.Contains("c"))//Calendar 外边框
            {
                pc = control as PanelControl;
            }
            else if (control.Name.Contains("r"))//Rest 休息字符
            {
                pc = control.Parent as PanelControl;
            }
            pc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }
        /// <summary>
        /// 鼠标离开效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_MouseLeave(object sender, EventArgs e)
        {
            PanelControl pc = null;
            Control control = (Control)sender;
            if (control.Name.Contains("s"))//Symbol 数字
            {
                pc = control.Parent as PanelControl;
            }
            else if (control.Name.Contains("c"))//Calendar 外边框
            {
                pc = control as PanelControl;
            }
            else if (control.Name.Contains("r"))//Rest 休息字符
            {
                pc = control.Parent as PanelControl;
            }
            pc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }
        /// <summary>
        /// 设置默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_Click(object sender, EventArgs e)
        {
            ProjectCalendarBo projectcalendar = new ProjectCalendarBo();
            projectcalendar.Week = week;
            projectcalendar.TimeSlot = worktimes;
            projectcalendar.DateState = specialdate;
            bool isSuccess = WcfServiceLocator.Create<IProjectCalendarService>().setProjectCalendarToDefault(projectcalendar);
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void biWork_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Work(NumberBox, Number, Sign);
            string date = cmbYear.Text.Replace("年", "") + "-" + cmbMonth.Text.Replace("月", "") + "-" + Number.Text;
            setWorkDate(new WorkDateBo(date, "班"));
        }

        private void biWeekend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Rest(NumberBox, Number, Sign);
            string date = cmbYear.Text.Replace("年", "") + "-" + cmbMonth.Text.Replace("月", "") + "-" + Number.Text;
            setWorkDate(new WorkDateBo(date, "休"));
        }
        /// <summary>
        /// 设置日历元素为休息状态
        /// </summary>
        /// <param name="box"></param>
        /// <param name="num"></param>
        /// <param name="str"></param>
        private void Rest(PanelControl box, LabelControl num, LabelControl str)
        {
            box.BackColor = Color.FromArgb(255, 240, 240);
            box.Tag = false;
            num.ForeColor = Color.FromArgb(255, 70, 50);
            num.Tag = false;
            str.ForeColor = Color.FromArgb(255, 255, 255);
            str.BackColor = Color.FromArgb(255, 70, 50);
            str.Text = "休";
            str.Tag = false;
        }
        /// <summary>
        /// 设置日历为工作状态
        /// </summary>
        /// <param name="box"></param>
        /// <param name="num"></param>
        /// <param name="str"></param>
        private void Work(PanelControl box, LabelControl num, LabelControl str)
        {
            box.BackColor = this.BackColor;
            box.Tag = true;
            num.ForeColor = this.ForeColor;
            num.Tag = true;
            str.ForeColor = this.ForeColor;
            str.BackColor = this.BackColor;
            str.Text = "";
            str.Tag = true;
        }
        /// <summary>
        /// 保存上班周
        /// </summary>
        private void setWeek()
        {
            week.Sunday = chkSunday.Checked;
            week.Monday = chkMonday.Checked;
            week.Tuesday = chkTuesday.Checked;
            week.Wednesday = chkWednesday.Checked;
            week.Thursday = chkThursday.Checked;
            week.Friday = chkFriday.Checked;
            week.Saturday = chkSaturday.Checked;
        }
        /// <summary>
        /// 设置工作时间
        /// </summary>
        private void setWorkTime()
        {
            worktimes = (List<WorkTimeBo>)gvWorkTime.DataSource;
        }
        /// <summary>
        /// 设置工作日期
        /// </summary>
        private void setWorkDate(WorkDateBo workdate)
        {
            for (int i = 0; i < specialdate.Count - 1; i++)
            {
                if (specialdate[i].Time.Equals(workdate.Time))
                    specialdate.RemoveAt(i--);
            }
            specialdate.Add(workdate);
        }
        /// <summary>
        /// 确定保存全部设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            ProjectCalendarBo projectcalendar = new ProjectCalendarBo();
            projectcalendar.Week = week;
            projectcalendar.TimeSlot = worktimes;
            projectcalendar.DateState = specialdate;
            bool isSuccess = WcfServiceLocator.Create<IProjectCalendarService>().saveAllProjectCalendarByProjectId(projectcalendar, project.Id);
        }
    }
}