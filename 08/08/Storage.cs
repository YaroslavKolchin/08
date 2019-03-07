https://github.com/YaroslavKolchin/08.gitusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public abstract class Storage
    {
        public Storage(double capacity)
        {
            this.capacity = capacity;
        }
        public double memory { get; set; }
        protected string name { get; set; }
        protected string model { get; set; }
        private double capacity { get; set; }
        public virtual double GetCapacity()
        {
            return capacity;
        }
        public abstract void CopyInfo();
        public virtual double GetFreeCapacity()
        {
            return capacity;
        }
        public virtual string PrintInfo()
        {
            return string.Format("{0}({1})-{2} GB", name, model, capacity);
        }

    }
}
