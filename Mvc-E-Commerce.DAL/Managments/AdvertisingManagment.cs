using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class AdvertisingManagment
    {
        private Mvc_E_CommerceContext database;

        public AdvertisingManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Advertising AddAdvertising(Advertising Advertising)
        {
            return database.Set<Advertising>().Add(Advertising);
        }

        public void UpdateAdvertising(Advertising Advertising)
        {
            database.Entry(Advertising).State = EntityState.Modified;
        }

        public void DeleteAdvertising(Advertising Advertising)
        {
            database.Set<Advertising>().Remove(Advertising);
        }

        public void ChangeAdvertising(Advertising eskiAdvertising, Advertising yeniAdvertising)
        {
            database.Entry(eskiAdvertising).CurrentValues.SetValues(yeniAdvertising);
        }

        public List<Advertising> GetAdvertising()
        {
            return database.Set<Advertising>().ToList();
        }

        public Advertising GetAdvertisingById(int AdvertisingId)
        {
            return database.Set<Advertising>().FirstOrDefault(u => u.AdvertisingId == AdvertisingId);
        }

        public int AdvertisingChangeSave()
        {
            return database.SaveChanges();
        }

    }
}
