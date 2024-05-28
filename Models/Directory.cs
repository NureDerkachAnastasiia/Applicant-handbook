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
        //public List<Speciality> Specis { get; set; }
        public List<University> SavedUnis { get; set; }
        public List<Speciality> SavedSpecis { get; set; }
        public string Password { get; set; }
        
        public Directory()
        {
            Unis = new List<University>();
            //Specis = new List<Speciality>();
            LoadData();

        }

        //Завантаження даних у програму
        //
        public void LoadData()
        {
            string uniJson = File.ReadAllText("unis.txt");
            //string specJson = File.ReadAllText("specis.txt");
            string savedUniJson = File.ReadAllText("savedUnis.txt");
            string savedSpecJson = File.ReadAllText("savedSpec.txt");

            Unis = JsonSerializer.Deserialize<List<University>>(uniJson);
            //Specis = JsonSerializer.Deserialize<List<Speciality>>(specJson);
            SavedUnis = JsonSerializer.Deserialize<List<University>>(savedUniJson);
            SavedSpecis = JsonSerializer.Deserialize<List<Speciality>>(savedSpecJson);
            Password = File.ReadAllText("password.txt");

            

        }

        //Збереження оновлених даних про збережені спеціальності та університети
        //
        public void SaveData()
        {
            File.WriteAllText("savedUnis.txt", string.Empty);
            File.WriteAllText("savedSpec.txt", string.Empty);
            File.WriteAllText("password.txt", string.Empty);
            File.WriteAllText("unis.txt", string.Empty);

            string savedUniJson = JsonSerializer.Serialize(SavedUnis);
            string savedSpecJson = JsonSerializer.Serialize(SavedSpecis);
            string unisJson = JsonSerializer.Serialize(Unis);

            File.WriteAllText("savedUnis.txt", savedUniJson);
            File.WriteAllText("savedSpec.txt", savedSpecJson);
            File.WriteAllText("password.txt", Password);
            File.WriteAllText("unis.txt", unisJson);
        }

        //Збереження списку збережених університетів у файл
        //
        public void SaveUnisToPrint(string path)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    foreach(var uni in SavedUnis)
                    {
                        string s = uni.UniToPrint();
                        w.WriteLine(s);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Помилка під час збереження файлу: {ex.Message}", "Помилка");
            }
        }

        //Збереження списку збережених спеціальностей у файл
        //
        public void SaveSpecisToPrint(string path)
        {
            try
            {
                using(StreamWriter w = new StreamWriter(path))
                {
                    foreach(var spec in SavedSpecis)
                    {
                        string s = spec.SpecToPrint();
                        w.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час збереження файлу: {ex.Message}", "Помилка");
            }
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

            /*foreach(var s in Specis)
            {
                if(s.Name.Contains(name) && s.EducationForm.Contains(form) && s.Uni.Contains(uni) && s.Budget.Contains(budget))
                {
                    result.Add(s);
                }
            }*/
            foreach(var u in Unis)
            {
                foreach(var s in u.Specialities)
                {
                    if (s.Name.Contains(name) && s.EducationForm.Contains(form) && s.Uni.Contains(uni) && s.Budget.Contains(budget))
                    {
                        result.Add(s);
                    }
                }
            }
            return result;
        }

        public bool CheckPassword(string pass)
        {
            return pass == this.Password;
        }

        public void ChangePassword(string pass)
        {
            this.Password = pass;
        }

        public void RemoveAllSearchedUnis(List<University> unis)
        {
            Unis = Unis.Except(unis).ToList();
            SavedUnis = SavedUnis.Except(unis).ToList();
        }

        public void RemoveSearchedUni(University uni)
        {
            var list = new List<University>
            {
                uni
            };
            Unis = Unis.Except(list).ToList();
            SavedUnis = SavedUnis.Except(list).ToList();
        }

        public void RemoveAllSearchedSpecis(List<Speciality> specis)
        {
            foreach(var uni in Unis)
            {
                uni.Specialities = uni.Specialities.Except(specis).ToList();

            }
            foreach(var uni in SavedUnis)
            {
                uni.Specialities = uni.Specialities.Except(specis).ToList();
            }
            SavedSpecis = SavedSpecis.Except(specis).ToList();
        }

        public void RemoveSearchedSpec(Speciality spec)
        {
            var list = new List<Speciality> { spec };
            foreach(var uni in Unis)
            {
                uni.Specialities = uni.Specialities.Except(list).ToList();
            }
            foreach (var uni in SavedUnis)
            {
                uni.Specialities = uni.Specialities.Except(list).ToList();
            }
            SavedSpecis = SavedSpecis.Except(list).ToList();
        }

        public void EditUni(University uni)
        {
            foreach(var u in Unis)
            {
                if (uni.Equals(u))
                {
                    u.Name = uni.Name;
                    u.City = uni.City;
                    u.Head = uni.Head;
                    u.Id = uni.Id;
                    u.PhoneNum = uni.PhoneNum;
                    u.Adress = uni.Adress;
                    u.Email = uni.Email;
                    u.Specialities = uni.Specialities;
                    break;
                }
            }
            foreach (var u in SavedUnis)
            {
                if (uni.Equals(u))
                {
                    u.Name = uni.Name;
                    u.City = uni.City;
                    u.Head = uni.Head;
                    u.Id = uni.Id;
                    u.PhoneNum = uni.PhoneNum;
                    u.Adress = uni.Adress;
                    u.Email = uni.Email;
                    u.Specialities = uni.Specialities;
                    break;
                }
            }
        }

        public void AddSpecToUni(University uni, Speciality spec)
        {
            foreach(var u in Unis)
            {
                if (u.Equals(uni))
                {
                    u.Specialities.Add(spec);
                }
            }
        }

        public University FindUni(Speciality spec)
        {
            foreach(var uni in Unis)
            {
                foreach(var s in uni.Specialities)
                {
                    if (s.Equals(spec))
                    {
                        return uni;
                    }
                }
            }
            return null;
        }

        public bool CheckIdUni(string id)
        {
            foreach(var uni in Unis)
            {
                if(uni.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckSpec(string name, string uni, string eduForm)
        {
            foreach(var u in Unis)
            {
                foreach(var s in u.Specialities)
                {
                    if(s.Name == name && s.Uni == uni && s.EducationForm == eduForm)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
