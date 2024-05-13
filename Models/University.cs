using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class University
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Head { get; set; }
        public string Id { get; set; }
        public string PhoneNum { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public List<Speciality> Specialities { get; set; }
        
        public University()
        {

        }

        public University(string name, string city, List<Speciality> specis)
        {
            Name = name;
            City = city;
            Specialities = specis;
        }

        public University(string name, string city)
        {
            Name = name;
            City = city;
        }
    }
}
