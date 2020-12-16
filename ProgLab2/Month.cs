using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab2
{
    class Month
    {
        public string Name { get; set; }
        public string Season { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
