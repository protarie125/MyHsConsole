using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsConsole.Game.Numeric
{
    class OmcInt
    {
        public int Original { get; set; }
        public int Maximum { get; set; }
        public int Current { get; set; }

        public OmcInt(int original)
        {
            Original = original;
            Maximum = original;
            Current = original;
        }
    }
}
