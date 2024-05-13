using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CourseWork
{
    internal class Directory
    {
        public List<University> Unis { get; set; }
        public List<Speciality> Specis { get; set; }
        
        public Directory()
        {
            Unis = new List<University>();
            Specis = new List<Speciality>();
            LoadData();

        }

        public void LoadData()
        {
            string uniJson = File.ReadAllText("unis.txt");
            string specJson = File.ReadAllText("specis.txt");

            Unis = JsonSerializer.Deserialize<List<University>>(uniJson);
            Specis = JsonSerializer.Deserialize<List<Speciality>>(specJson);
        }

        //Пошук у списку університетів
        //
        public List<University> SearchUnis (string name, string city)
        {
            var result = new List<University>();

            foreach(var u in Unis)
            {
                if(u.Name.Contains(name) && u.City.Contains(city))
                {
                    result.Add(u);
                }
            }
            return result;
        }

        //Пошук у списку спеціальностей
        //
        public List<Speciality> SearchSpecis (string name, string form, string uni, string budget)
        {
            var result = new List<Speciality>();

            foreach(var s in Specis)
            {
                if(s.Name.Contains(name) && s.EducationForm.Contains(form) && s.Uni.Contains(uni) && s.Budget.Contains(budget))
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
