using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace View_Winform.Test
{
    /// <summary>
    ///  /// <summary>
    ///  反射操作打开子窗体
    /// </summary>
    /// </summary>
    public class ReflectionHelper
    {
        /// <summary>
        /// 打开新的子窗体
        /// </summary>
        /// <param name="strName">窗体的类名</param>
        /// <param name="AssemblyName">窗体所在类库的名称</param>
        /// <param name="MdiParentForm">父窗体</param>
        public static void CreateForm(string strName, string AssemblyName, Form MdiParentForm)
        {
            int Index = strName.LastIndexOf(".");
            string FormName = strName.Substring(23);
            if (!ShowChildForm(FormName, MdiParentForm))
            {
                string path = AssemblyName;//项目的Assembly选项名称
                string name = strName; //类的名字
                Form doc = (Form)Assembly.Load(path).CreateInstance(name);
                doc.WindowState = FormWindowState.Maximized;
                doc.TopLevel = false;
                doc.Parent = MdiParentForm;
                doc.Show();
            }
        }

        /// <summary>
        /// 防止子窗体再度打开
        /// </summary>
        /// <param name="p_ChildrenFormText"></param>
        /// <param name="MdiParentForm"></param>
        /// <returns></returns>
        public static bool ShowChildForm(string p_ChildrenFormText, Form MdiParentForm)
        {
            int i;
            //依次检测当前窗体的子窗体
            for (i = 0; i < MdiParentForm.MdiChildren.Length; i++)
            {
                //判断当前子窗体的Text属性值是否与传入的字符串值相同
                if (MdiParentForm.MdiChildren[i].Name == p_ChildrenFormText)
                {
                    //如果值相同则表示此子窗体为想要调用的子窗体，激活此子窗体并返回true值
                    MdiParentForm.MdiChildren[i].Activate();
                    return true;
                }
            }
            //如果没有相同的值则表示要调用的子窗体还没有被打开，返回false值
            return false;
        }
    }
}
