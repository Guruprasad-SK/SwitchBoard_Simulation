using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardWithAppliance
{
    public class Fan:Switch
    {
        public Fan(int id):base(id,false,"Fan") 
        {

        }
    }
}
