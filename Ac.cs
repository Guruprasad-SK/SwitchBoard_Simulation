﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardWithAppliance
{
    public class Ac:Switch
    {
        public Ac(int id) : base(id, false,"Ac") { }
    }
}
