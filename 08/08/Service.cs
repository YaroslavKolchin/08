using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Storage
{
    public class ServiceStorage
    {
        public List<Storage> storages = new List<Storage>();
        public double getSumCapacity()
        {
            double sum = 0;
            for (int i = 0; i < storages.Count; i++)
                sum = storages[i].GetCapacity();

            return sum;
        }

        public TimeSpan getTimeCopying(Flash flash, double memory)
        {
            TimeSpan timeSpan;
            if (flash.GetFreeCapacity() < memory)
                timeSpan = new TimeSpan(0, 0, 0);
            else
            {
                double tmp = memory / flash.speed;
                timeSpan = TimeSpan.FromMinutes(tmp);
            }
            return timeSpan;
        }
        public void getCountStorages(double v)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                string info = string.Format("{0}) {1} Count: {2}", i + 1, storages[i].PrintInfo(), v / storages[i].GetCapacity());
                Console.WriteLine(info);
            }
        }
        public void T(Flash flash, double memory)
        {
            if (memory > flash.GetFreeCapacity())
                throw new Exception("недостаточно места ");
            else
            {
                for (int i = 0; i < getTimeCopying(flash, memory).Minutes; i++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("копирование закончено ");
            }
        }
    }
}
