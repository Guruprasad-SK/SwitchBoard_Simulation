using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwitchBoardWithAppliance
{
    public class Switch
    {
        public int Id { get; set; }
        public bool IsOn { get; set; }
        public string Name { get; set; }
     
        public Switch(int id, bool ison, string name)
        {
            this.Id = id;
            this.IsOn = ison;
            this.Name = name;
        }
        public override string ToString()
        {
            var data = string.Format("{0} {1} ", Id, Name);

            return data;
        }
    }
}

