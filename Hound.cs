﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogShelter
{
    public class Hound : Dog
    {
        public override double Feed(double kg)
        {
            return (kg*10*2.5)/3;
        }
        public override string[] HealthCare(Dog dog)
        {
            string[] needs = new string[3] { "nail-cut", "", "ear-check-up" };
            needs[1] = dog.FurLength == 0 ? "brush" : "trim";
            return needs;
        }
    }
}
