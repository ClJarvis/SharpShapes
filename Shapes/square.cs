﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class square : Quaddrilaterial
    {
        public override float Area()
        {
            return (Side1 * Side2);
        }
    }
}