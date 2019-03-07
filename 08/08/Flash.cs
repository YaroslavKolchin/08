using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public enum USBType
    {
        USB20, USB30
    }
    public class Flash : Storage
    {
        public Flash(double capacity, string name, string model, int speed, USBType uSBType) : base(capacity)
        {
            this.speed = speed;
            this.USBType = uSBType;
            this.name = name;
            this.model = model;
            this.memory = capacity;
        }
        public USBType USBType { get; set; }
        public int speed { get; set; }
        public override void CopyInfo()
        {

        }
    }
}
