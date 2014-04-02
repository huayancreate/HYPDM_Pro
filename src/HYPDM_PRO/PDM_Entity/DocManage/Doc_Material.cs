using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.DocManage
{
    [DataContract]
    public class Doc_Material
    {
        public int? Id { get; set; }
        public int? Doc_Id { get; set; }
        public int? Material_Id { get; set; }
        public string Is_Delete { get; set; }
        public int? Create_User_Id { get; set; }
        public DateTime Create_Date { get; set; }
        public int? Modify_User_Id { get; set; }
        public DateTime Modify_Date { get; set; }
    }
}
