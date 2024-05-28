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

        //Визначення, чи дорівнює об'єкт заданій спеціальності
        //
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Speciality other = (Speciality)obj;
            return Name == other.Name && Uni == other.Uni && EducationForm == other.EducationForm;
        }

        public override int GetHashCode()
        {
            int hashName = Name == null ? 0 : Name.GetHashCode();
            int hashUni = Uni == null ? 0 : Uni.GetHashCode();
            int hashEducationForm = EducationForm == null ? 0 : EducationForm.GetHashCode();

            return hashName ^ hashUni ^ hashEducationForm;
        }

        //Створення з екземпляра класу Speciality рядка, що підходить для збереження у файл списку збережених спеціальностей
        //
        public string SpecToPrint()
        {
            string result = $"Назва спеціальності: {this.Name}\nНазва ЗВО: {this.Uni}\nФорма навчання: {this.EducationForm}\nМожливість вступу на бюджет: {this.Budget}\nВартість на рік за контрактом: {this.Amount.ToString()}\nПрохідний бал на бюджет у 2023 році: {this.BudgetGrade}\nПрохідний бал на контракт у 2023 році: {this.ContractGrade.ToString()}\n\n";
            return result;
        }
    }
}
