using System;
using System.Collections.Generic;
using System.Text;

namespace EnumStructPract
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancie Vacancy { get; set; }
        public int Wage { get; set; }
        private int[] Date;
        public int[] DateOfReceipt
        {
            get
            {
                if (Date == null)
                {
                    Date = new int[3];
                }
                return Date;
            }
            set
            {
                if (Date == null)
                {
                    Date = new int[3];
                }
                Date = value;
            }
        }
    }
}
