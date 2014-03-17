using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Entity.SystemManagementAndTools;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.SystemManagementAndTools
{
    public class CommonMethod 
    {
        public void GridViewCheck(DevExpress.XtraGrid.Views.Grid.GridView gridView,string p, int id)
        {
            if (p == "user")
            {
                List<Users> listRelated = new List<Users>();
                listRelated = WcfServiceLocator.Create<IUsersManage>().FindRelatedUsersForUserGroup(id); //找出和指定用户组关联的用户
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var check = listRelated.Exists(delegate(Users user)
                    {
                        if (user.id == (int)gridView.GetRowCellValue(i, "id")) return true;
                        return false;
                    });
                    gridView.SetRowCellValue(i, "isChecked", check);
                }

            }
            if (p == "role")
            {
                List<Users> listRelated = new List<Users>();
                listRelated = WcfServiceLocator.Create<IRoleManage>().findRelatedUser(id); //找出和指定角色关联的用户
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var check = listRelated.Exists(delegate(Users user)
                    {
                        if (user.id == (int)gridView.GetRowCellValue(i, "id")) return true;
                        return false;
                    });
                    gridView.SetRowCellValue(i, "isChecked", check);
                }
            
            }
            if (p =="rolewithgroup")
            {
                List<Group> listRelated = new List<Group>();
                listRelated = WcfServiceLocator.Create<IRoleManage>().findRelatedGroup(id); //找出和指定角色关联的用户
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var check = listRelated.Exists(delegate(Group group)
                    {
                        if (group.Id == (int)gridView.GetRowCellValue(i, "Id")) return true;
                        return false;
                    });
                    gridView.SetRowCellValue(i, "isChecked", check);
                }
            }

         }

     }
}

