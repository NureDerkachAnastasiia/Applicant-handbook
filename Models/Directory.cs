using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CourseWork
{
    public class Directory
    {
        public List<University> Unis { get; set; }
        public List<Speciality> Specis { get; set; }
        public List<University> SavedUnis { get; set; }
        public List<Speciality> SavedSpecis { get; set; }
        
        public Directory()
        {
            Unis = new List<University>();
            Specis = new List<Speciality>();
            LoadData();

        }

        //Завантаження даних у програму
        //
        public void LoadData()
        {
            string uniJson = File.ReadAllText("unis.txt");
            string specJson = File.ReadAllText("specis.txt");
            string savedUniJson = File.ReadAllText("savedUnis.txt");
            string savedSpecJson = File.ReadAllText("savedSpec.txt");

            Unis = JsonSerializer.Deserialize<List<University>>(uniJson);
            Specis = JsonSerializer.Deserialize<List<Speciality>>(specJson);
            SavedUnis = JsonSerializer.Deserialize<List<University>>(savedUniJson);
            SavedSpecis = JsonSerializer.Deserialize<List<Speciality>>(savedSpecJson);
        }

        //Збереження оновлених даних про збережені спеціальності та університети
        //
        public void SaveData()
        {
            File.WriteAllText("savedUnis.txt", string.Empty);
            File.WriteAllText("savedSpec.txt", string.Empty);

            string savedUniJson = JsonSerializer.Serialize(SavedUnis);
            string savedSpecJson = JsonSerializer.Serialize(SavedSpecis);

            File.WriteAllText("savedUnis.txt", savedUniJson);
            File.WriteAllText("savedSpec.txt", savedSpecJson);
        }
        
        //Додавання елемента до списку збережених університетів
        //
        public void AddToSavedUnis(University uni)
        {
            SavedUnis.Add(uni);
        }

        //Додавання елемента до списку збережених спеціальностей
        //
        public void AddToSavedSpecis(Speciality spec)
        {
            SavedSpecis.Add(spec);
        }

        //Видалення усіх університетів зі списку збережених
        //
        public void RemoveAllSavedUnis()
        {
            SavedUnis.Clear();
        }

        //Видалення усіх спеціальностей зі списку збережених
        //
        public void RemoveAllSavedSpecis()
        {
            SavedSpecis.Clear();
        }

        //Видалення конкретної спеціальності зі списку збережених
        //
        public void RemoveSpeciality(Speciality spec)
        {
            if (SavedSpecis.Contains(spec))
            {
                SavedSpecis.Remove(spec);
            }
        }

        //Видалення конкретного університету зі списку збережених
        //
        public void RemoveUniversity(University uni)
        {
            if (SavedUnis.Contains(uni))
            {
                SavedUnis.Remove(uni);
            }
        }

        //Визначення, чи міститься університет у списку збережених
        //
        public bool ContainsUni(University uni)
        {
            if(SavedUnis == null)
            {
                return false;
            }
            foreach(var u in SavedUnis)
            {
                if (u.Equals(uni))
                {
                    return true;
                }
            }
            return false;
        }

        //Визначення, чи міститься спеціальность у списку збережених
        //
        public bool ContainsSpec(Speciality spec)
        {
            if(SavedSpecis == null)
            {
                return false;
            }
            foreach(var s in SavedSpecis)
            {
                if (s.Equals(spec))
                {
                    return true;
                }
            }
            return false;
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
