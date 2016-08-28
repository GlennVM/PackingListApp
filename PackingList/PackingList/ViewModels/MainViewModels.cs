using PackingList.Models;
using PackingList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.ViewModels
{
    public class MainViewModel
    {
        public List<TripComponent> TripComponent { get; set; }
        public List<TripComponent> ItemDictionary { get; set; }
        DummyService dm = new DummyService();

        public void laadReizen()
        {
            TripComponent = dm.retrieveTrips();
        }

        public void laadItemDictionary()
        {
            ItemDictionary = dm.retrieveItemDictionary();
        }

        public void addItemToDictionary(TripComponent item)
        {
            ItemDictionary.Add(item);
        }
    }
}
