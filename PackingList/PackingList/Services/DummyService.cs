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
        public DummyService()
        {
            List<TripComponent> items = new List<TripComponent>();
            items.Add(new Item() {Name = "Item 1", Checked = true});
            items.Add(new Item() { Name = "Item 2", Checked = false });
            items.Add(new Item() { Name = "Item 3", Checked = true });

            trips = new List<TripComponent>();
            trips.Add(new Trip() { Title = "Demenarken", items = items});
            trips.Add(new Trip() { Title = "Italië", items = items });
            trips.Add(new Trip() { Title = "Duitsland", items = items });
        }

        public List<TripComponent> retrieveTrips()
        {
            return trips;
        }
    }
}
