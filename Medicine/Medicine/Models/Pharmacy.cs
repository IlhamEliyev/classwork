using Medicine.Utlis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine.Models
{
    class Pharmacy
    {
        public int MedicineLimit { get; set; }
        public List<Medicine> Medicines { get; set; }
        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
        }
        public void AddMedicine(Medicine medicine)
        {
            if (Medicines.Exists(m => medicine.Name == m.Name)) throw new MedicineAlreadyExistsException("Bu derman artiq var");
            if (Medicines.Count >= MedicineLimit) throw new CapacityLimitException("Limiti asdiz");
            Medicines.Add(medicine);
        }

        public Medicine[] GetAllMedicines()
        {
            Medicine[] copy = new Medicine[Medicines.Count];
            Medicines.CopyTo(copy);
            foreach (var item in copy)
            {
                item.IsDeleted = false;
            }
            return copy;

        }
        public List<Medicine> FilterMedicinesByPrice(double minPrice, double maxPrice)
        {
            return Medicines.FindAll(m => m.Price >= minPrice && m.Price <= maxPrice);
        }
        public Medicine GetMedicineById(int? Id)
        {
            if ( Id == null)  throw new NullReferenceException("Id-nulldur");
            Medicine med = new Medicine();
            med = Medicines.Find(m => m.Id == Id);
            med.IsDeleted = false;
            return med;
        }
        public void DeleteMedicineById(int? Id)
        {
            if (Id == null) throw new NullReferenceException("Id-nulldur");
            Medicine newMed = Medicines.Find(element => element.Id == Id && element.IsDeleted == false);
            newMed.IsDeleted = true;
        }
    }
}
