using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }

                name = value;
            }
        }

        public void Order(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            return medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            return medicines.Sum(m => m.Price);
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return medicines.OrderByDescending(m => m.Price).First();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return medicines.OrderBy(m => m.Price).First();
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            medicines.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Pharmacy {name} has {medicines.Count} medicines and they are:")
                .AppendLine();

            sb.Append(medicines.Count < 1 ? "N/A" : string.Join(Environment.NewLine, medicines));

            return sb.ToString();
        }
    }
}
