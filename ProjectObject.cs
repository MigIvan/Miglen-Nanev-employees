using System;
using System.Collections.Generic;

namespace WorkedTogether
{
    public class ProjectObject
    {
        private List<EmployeeObject> employees = new List<EmployeeObject>();

        public string projectID = "";

        public string Employe1
        {
            get 
            {
                string retString = "";
                if (employees.Count > 0)
                    retString = employees[0].EmpID;
                return retString;
            }
        }

        public string Employe2
        {
            get
            {
                string retString = "";
                if (employees.Count > 1)
                    retString = employees[1].EmpID;
                return retString;
            }
        }

        public int Period
        {
            get 
            {
                int retInt = 0;
                if (employees.Count == 1) 
                    retInt = employees[0].Period;                 
                if (employees.Count > 1)                                    
                    retInt += employees[1].Period;                
                return retInt;
            }
        }

        public ProjectObject(string line)
        {
            string[] fields = line.Split(Common.delimiterChars);
            projectID = fields[1];            
            employees.Add(new EmployeeObject(fields));
        }

        internal void Update(string line)
        {           
            string[] fields = line.Split(Common.delimiterChars);            
            employees.Add(new EmployeeObject(fields));
        }
    }
}