﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}
