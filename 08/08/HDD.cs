using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class HDD : Storage
    {
        public HDD(double capacity) : base(capacity)
        {

        }
        public override void CopyInfo() { }
        public int speed { get; set; }
        public int SectionsCount { get; set; }
        public double sectionsVolue { get; set; }
        public USBType USBType { get; set; }
    }
}
