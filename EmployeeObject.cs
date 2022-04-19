using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkedTogether
{
    public class EmployeeObject
    {
        public string EmpID = "";
        
        public DateTime DateFrom = DateTime.Today;
        
        public DateTime DateTo = DateTime.Today;

        public int Period
        {
            get { return ((int)(DateTo - DateFrom).TotalDays); }
        }

        public EmployeeObject(string[] fields)
        {
            EmpID = fields[0];
            DateFrom = Common.checkDate(fields[2]);
            DateTo = Common.checkDate(fields[3]);
        }
    }
}
