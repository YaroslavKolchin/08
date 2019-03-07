using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public enum DVDType
    {
        oneSided, twoSided
    }
    class DVD : Storage
    {
        public DVD(double capacity) : base(capacity)
        {

        }
        public override void CopyInfo() { }
        public double speedRead { get; set; }
        public double speedWrite { get; set; }

    }
}
