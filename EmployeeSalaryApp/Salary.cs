﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public double Basic { set; get; }
        public double Medical { set; get; }
        public double Conveyance { set; get; }
        public int Increment { set; get; }
        public double Total { set; get; }



        public void SetIncrement(double incermentPersent)
        {
            double incrementOfBasic;
            incrementOfBasic= Basic*incermentPersent/100;
            Basic += incrementOfBasic;
            Increment++;

        }

        public double GetMedical()
        {
            return  Basic*Medical/100;
        }

        public double GetConveyance()
        {
            return  Basic * Conveyance / 100;
        }

        public double GetTotal()
        {
            return Basic + GetMedical() + GetConveyance();
        }
    }
}
