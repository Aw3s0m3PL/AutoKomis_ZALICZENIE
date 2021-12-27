using AutoKomis_ZALICZENIE.Contexts;
using AutoKomis_ZALICZENIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKomis_ZALICZENIE.Logic
{
    public class AutaManager
    {
        public AutaManager AddVehicle(KomisModel komisModel)
        {
            using (var context = new KomisContext())
            {
                context.Add(komisModel);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    komisModel.ID = 0;
                    context.Add(komisModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public AutaManager RemoveVehicle(int id)
        {
            using (var context = new KomisContext())
            {
                var auto = context.Pojazdy.SingleOrDefault(x => x.ID == id);
                context.Remove(auto);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception)   
                {
                    context.Remove(auto);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public AutaManager UpdateVehicle(KomisModel komisModel)
        {
            using (var context = new KomisContext())
            {
                context.Update(komisModel);

                try
                { 
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    context.Update(komisModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public AutaManager ChangeDesc(int id, string newDesc)
        {
            using (var context = new KomisContext())
            {
                var carToEdit = context.Pojazdy.Single(x => x.ID == id);
                try
                {
                    carToEdit.Opis = newDesc;
                    if (String.IsNullOrEmpty(carToEdit.Opis))
                    {
                        carToEdit.Opis = "Brak opisu.";
                    }
                    this.UpdateVehicle(carToEdit);
                }
                catch
                {
                    this.UpdateVehicle(carToEdit);
                }
            }
            return this;
        }

        public KomisModel GetVehicle(int id)
        {
            using (var context = new KomisContext())
            {
                var vehicle = context.Pojazdy.SingleOrDefault(x => x.ID == id);
                return vehicle;
            }
        }

        public List<KomisModel> GetVehicles()
        {
            using (var context = new KomisContext())
            {
              var cars = context.Pojazdy.ToList<KomisModel>();
              return cars;
            }
        }

    }
}
