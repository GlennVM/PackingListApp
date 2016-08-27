﻿using PackingList.Models;
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
            items.Add(new Item() {Name = "Item 1", Checked = true});
            items.Add(new Item() { Name = "Item 2", Checked = false });
            items.Add(new Item() { Name = "Item 3", Checked = true });
            items.Add(new Item() { Name = "Hemd", Checked = true });
            items.Add(new Item() { Name = "Broek", Checked = false });
            items.Add(new Item() { Name = "Haardroger", Checked = true });
            items.Add(new Item() { Name = "Broek", Checked = true });
            items.Add(new Item() { Name = "Shirt", Checked = false });
            items.Add(new Item() { Name = "Hemd", Checked = true });
            items.Add(new Item() { Name = "Hemd", Checked = true });
            items.Add(new Item() { Name = "Broek", Checked = false });
            items.Add(new Item() { Name = "Haardroger", Checked = true });
            items.Add(new Item() { Name = "Broek", Checked = true });
            items.Add(new Item() { Name = "Shirt", Checked = false });
            items.Add(new Item() { Name = "Hemd", Checked = true });

            List<TripComponent> items2 = new List<TripComponent>();
            items2.Add(new Item() { Name = "Broek", Checked = true });
            items2.Add(new Item() { Name = "Shirt", Checked = false });
            items2.Add(new Item() { Name = "Hemd", Checked = true });

            List<TripComponent> items3 = new List<TripComponent>();
            items3.Add(new Item() { Name = "Hemd", Checked = true });
            items3.Add(new Item() { Name = "Broek", Checked = false });
            items3.Add(new Item() { Name = "Haardroger", Checked = true });

            trips = new List<TripComponent>();
            trips.Add(new Trip() { Title = "Demenarken", items = items});
            trips.Add(new Trip() { Title = "Italië", items = items2 });
            trips.Add(new Trip() { Title = "Duitsland", items = items3 });

            itemDictionary = new List<TripComponent>();

            itemDictionary.Add(new Item() { Name = "Hemd", Checked = false });
            itemDictionary.Add(new Item() { Name = "Broek", Checked = false });
            itemDictionary.Add(new Item() { Name = "T-Shirt", Checked = false });
            itemDictionary.Add(new Item() { Name = "Schoenen", Checked = false });
            itemDictionary.Add(new Item() { Name = "Tandenborstel", Checked = false });
            itemDictionary.Add(new Item() { Name = "Kam", Checked = false });
            itemDictionary.Add(new Item() { Name = "Gel", Checked = false });
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
