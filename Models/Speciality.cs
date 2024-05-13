using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Speciality
    {
        public string Name { get; set; }
        public string Uni { get; set; }
        public string BudgetGrade { get; set; }
        public int ContractGrade { get; set; }
        public string EducationForm { get; set; }
        public int Amount { get; set; }
        public string Budget { get; set; }

        public Speciality()
        {

        }

        public Speciality(string name, string form, string uni)
        {
            Name = name;
            Uni = uni;
            EducationForm = form;
        }
        
    }
}
