using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using PDM_Entity.MyTaskBox;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.MyTaskBox
{
    public partial class BulletinBoardSystem : DevExpress.XtraEditors.XtraForm
    {
        IMyTaskBoxService myTaskBoxService;
        public BulletinBoardSystem()
        {
            InitializeComponent();
        }

        private void BulletinBoardSystem_Load(object sender, EventArgs e)
        {
            myTaskBoxService = WcfExtension.WcfServiceLocator.Create<IMyTaskBoxService>();
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
            gcBulletins.DataSource = myTaskBoxService.GetBulletinAll();
            gcQuestions.DataSource = myTaskBoxService.GetQuestionAll();
        }

        private void gcBulletins_Click(object sender, EventArgs e)
        {
            var bulletin = myTaskBoxService.GetBulletinByID(1);
            BulletinStyle(bulletin);
        }
        /// <summary>
        /// 公告栏公告样式
        /// </summary>
        /// <param name="bulletin"></param>
        private void BulletinStyle(Bulletin bulletin)
        {
            rtbBulletin.Clear();
            rtbBulletin.SelectionIndent = 10;
            rtbBulletin.SelectionRightIndent = 10;
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.SelectionFont = new Font("宋体", 11, FontStyle.Bold);
            rtbBulletin.SelectionAlignment = HorizontalAlignment.Center;
            rtbBulletin.AppendText(bulletin.Title);
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.SelectionColor = Color.Gray;
            rtbBulletin.SelectionAlignment = HorizontalAlignment.Left;
            rtbBulletin.SelectionFont = new Font("宋体", 8, FontStyle.Regular);
            rtbBulletin.AppendText("部门: " + bulletin.Department);
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.SelectionColor = Color.Gray;
            rtbBulletin.SelectionFont = new Font("宋体", 8, FontStyle.Regular);
            rtbBulletin.AppendText("时间: " + bulletin.PublishTime);
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.AppendText(Environment.NewLine);
            rtbBulletin.AppendText("    ");
            rtbBulletin.AppendText(bulletin.Body);
        }

        private void gcQuestions_Click(object sender, EventArgs e)
        {
            var question = myTaskBoxService.GetQuestionByID(1);
            QuestionStyle(question);
        }
        /// <summary>
        /// 问题与回复显示样式
        /// </summary>
        /// <param name="question"></param>
        private void QuestionStyle(Question question)
        {
            rtbQuestion.Clear();
            rtbQuestion.SelectionIndent = 10;
            rtbQuestion.SelectionRightIndent = 10;
            rtbQuestion.SelectionColor = Color.Blue;
            rtbQuestion.AppendText(question.Creator + "(" + question.Email + ") " + question.CreateTime);
            rtbQuestion.AppendText(Environment.NewLine);
            rtbQuestion.SelectionFont = new Font("宋体", 10, FontStyle.Bold);
            rtbQuestion.AppendText(question.Title);
            rtbQuestion.AppendText(Environment.NewLine);
            rtbQuestion.AppendText(question.Body);
            rtbQuestion.AppendText(Environment.NewLine);
            if (question.replies == null) return;
            foreach (Reply reply in question.replies)
            {
                rtbQuestion.SelectionColor = Color.Blue;
                rtbQuestion.AppendText(reply.Creator + "(" + reply.Email + ") " + reply.CreateTime);
                rtbQuestion.AppendText(Environment.NewLine);
                rtbQuestion.AppendText("  "+reply.Body);
                rtbQuestion.AppendText(Environment.NewLine);
            }
            rtbQuestion.ScrollToCaret();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridHitInfo ghi = (sender as GridView).CalcHitInfo(e.Location);
                var name = this.Name;
                pmBulletin.ShowPopup(barManager1, new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }
        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridHitInfo ghi = (sender as GridView).CalcHitInfo(e.Location);
                var name = this.Name;
                pmQuestion.ShowPopup(barManager1, new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }
    }
}