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
            return this;
        }

        public AutaManager RemoveVehicle(int id)
        {
            return this;
        }

        public AutaManager UpdateVehicle(KomisModel komisModel)
        {
            return this;
        }

        public AutaManager ChangeDesc(int id, string newDesc)
        {
            return this;
        }

        public AutaManager GetVehicle(int id)
        {
            return null;
        }

        public List<KomisModel> GetVehicles()
        {
            return null;
        }
    }
}
