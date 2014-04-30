using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDM_Entity.PartsMange
{
    public class ComboBoxData
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
