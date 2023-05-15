using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardWithAppliance
{
    public class Bulb:Switch
    {
        public Bulb(int id):base(id,false,"Bulb") { }
    }
}
