using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class Material_Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Is_Last { get; set; }
        public string Child_Mark_Length { get; set; }
        public string Code_Start { get; set; }
        public string Code_Length { get; set; }
        public int Parent_Id { get; set; }
        public string Is_Delete { get; set; }
        public int Create_User_Id { get; set; }
        public DateTime Create_Date { get; set; }
        public int Modify_User_Id { get; set; }
        public DateTime Modify_Date { get; set; }

    }
}
