using PackingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Services
{
    public class DummyService
    {
        List<TripComponent> trips;
        List<TripComponent> itemDictionary; 
        public DummyService()
        {
            List<TripComponent> items = new List<TripComponent>();
            items.Add(new Item() { Name = "Broek", Checked = true, Amount = 6, Category = "Clothing"});
            items.Add(new Item() { Name = "Shirt", Checked = false, Amount = 5, Category = "Clothing" });
            items.Add(new Item() { Name = "Hemd", Checked = true, Amount = 1, Category = "Clothing" });

            List<TripComponent> items2 = new List<TripComponent>();
            items2.Add(new Item() { Name = "Broek", Checked = true, Amount = 2, Category = "Clothing" });
            items2.Add(new Item() { Name = "Shirt", Checked = false, Amount = 2, Category = "Clothing" });
            items2.Add(new Item() { Name = "Hemd", Checked = true, Amount = 2, Category = "Clothing" });

            List<TripComponent> items3 = new List<TripComponent>();
            items3.Add(new Item() { Name = "Hemd", Checked = true, Amount = 2, Category = "Clothing" });
            items3.Add(new Item() { Name = "Broek", Checked = false, Amount = 2, Category = "Clothing" });
            items3.Add(new Item() { Name = "Haardroger", Checked = true, Amount = 2, Category = "Clothing" });

            trips = new List<TripComponent>();
            trips.Add(new Trip() { Title = "Demenarken", items = items});
            trips.Add(new Trip() { Title = "Italië", items = items2 });
            trips.Add(new Trip() { Title = "Duitsland", items = items3 });

            itemDictionary = new List<TripComponent>();

            itemDictionary.Add(new Item() { Name = "Hemd", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Broek", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "T-Shirt", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Schoenen", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Tandenborstel", Checked = false, Category = "Bathroom" });
            itemDictionary.Add(new Item() { Name = "Kam", Checked = false, Category = "Bathroom" });
            itemDictionary.Add(new Item() { Name = "Gel", Checked = false, Category = "Bathroom" });
        }

        public List<TripComponent> retrieveTrips()
        {
            return trips;
        }

        public List<TripComponent> retrieveItemDictionary()
        {
            return itemDictionary;
        }
    }
}
