using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class AdvertisingController
    {
        private AdvertisingManagment advertisingManagment;

        public AdvertisingController()
        {
            advertisingManagment = new AdvertisingManagment();
        }

        public Advertising AddAdvertising(Advertising Advertising)
        {
            Advertising addedAdvertising = null;

            if (Advertising == null)
                return null;

            if (Advertising.Path.Length > 40)
                return null;

            addedAdvertising = advertisingManagment.AddAdvertising(Advertising);
            advertisingManagment.AdvertisingChangeSave();
            return addedAdvertising;
        }
        public void UpdateAdvertising(Advertising Advertising, Advertising yeniAdvertising)
        {
            if (Advertising != null && yeniAdvertising != null)
            {
                advertisingManagment.UpdateAdvertising(Advertising);
                advertisingManagment.ChangeAdvertising(Advertising, yeniAdvertising);
                advertisingManagment.AdvertisingChangeSave();
            }
        }
        public void DeleteAdvertising(Advertising Advertising)
        {
            if (Advertising != null)
            {
                advertisingManagment.DeleteAdvertising(Advertising);
                advertisingManagment.AdvertisingChangeSave();
            }
        }
        public List<Advertising> GetAdvertisings()
        {
            return advertisingManagment.GetAdvertising();
        }
        public Advertising GetAdvertisingById(int AdvertisingId)
        {
            if (AdvertisingId == 0)
            {
                return null;
            }
            else
            {
                return advertisingManagment.GetAdvertisingById(AdvertisingId);
            }
        }

    }
}
