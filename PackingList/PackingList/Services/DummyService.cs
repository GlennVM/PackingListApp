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
        List<Trip> trips;
        List<Item> itemDictionary;
        List<User> users; 
        public DummyService()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Name = "Broek", Checked = true, Amount = 6, Category = "Clothing"});
            items.Add(new Item() { Name = "Shirt", Checked = false, Amount = 5, Category = "Clothing" });
            items.Add(new Item() { Name = "Hemd", Checked = true, Amount = 1, Category = "Clothing" });

            List<Item> items2 = new List<Item>();
            items2.Add(new Item() { Name = "Broek", Checked = true, Amount = 2, Category = "Clothing" });
            items2.Add(new Item() { Name = "Shirt", Checked = false, Amount = 2, Category = "Clothing" });
            items2.Add(new Item() { Name = "Hemd", Checked = true, Amount = 2, Category = "Clothing" });

            List<Item> items3 = new List<Item>();
            items3.Add(new Item() { Name = "Hemd", Checked = true, Amount = 2, Category = "Clothing" });
            items3.Add(new Item() { Name = "Broek", Checked = false, Amount = 2, Category = "Clothing" });
            items3.Add(new Item() { Name = "Haardroger", Checked = true, Amount = 2, Category = "Clothing" });

            List<Models.Task> tasks = new List<Models.Task>();
            tasks.Add(new Models.Task() { Name = "Reistoelating gaan halen", Checked = false});
            tasks.Add(new Models.Task() { Name = "Stadhuis", Checked = false });

            List<Models.Task> tasks2 = new List<Models.Task>();
            tasks2.Add(new Models.Task() { Name = "Reistoelating gaan halen", Checked = false });
            tasks2.Add(new Models.Task() { Name = "Tickets afprinten", Checked = false });

            List<Models.Task> tasks3 = new List<Models.Task>();
            tasks3.Add(new Models.Task() { Name = "Paspoort gaan halen", Checked = false });
            tasks3.Add(new Models.Task() { Name = "Boekjes gaan halen", Checked = false });

            trips = new List<Trip>();
            trips.Add(new Trip() { Title = "Demenarken", items = items, tasks = tasks});
            trips.Add(new Trip() { Title = "Italië", items = items2, tasks = tasks2 });
            trips.Add(new Trip() { Title = "Duitsland", items = items3, tasks = tasks3 });

            itemDictionary = new List<Item>();

            itemDictionary.Add(new Item() { Name = "Hemd", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Broek", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "T-Shirt", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Schoenen", Checked = false, Category = "Clothing" });
            itemDictionary.Add(new Item() { Name = "Tandenborstel", Checked = false, Category = "Bathroom" });
            itemDictionary.Add(new Item() { Name = "Kam", Checked = false, Category = "Bathroom" });
            itemDictionary.Add(new Item() { Name = "Gel", Checked = false, Category = "Bathroom" });

            users = new List<User>();

            users.Add(new User() { Name = "DeanD", Password = "test123", EmailAddress = "dean.delanoye@uwp.be" });
        }

        public List<Trip> retrieveTrips()
        {
            return trips;
        }

        public List<Item> retrieveItemDictionary()
        {
            return itemDictionary;
        }

        public List<User> retrieveUsers()
        {
            return users;
        }
    }
}
