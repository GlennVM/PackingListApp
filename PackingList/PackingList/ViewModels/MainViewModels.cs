using Newtonsoft.Json;
using PackingList.Models;
using PackingList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Newtonsoft.Json;

namespace PackingList.ViewModels
{
    public class MainViewModel
    {
        public User selectedUser;
        public List<Trip> TripComponent { get; set; }
        public List<Item> ItemDictionary { get; set; }
        DummyService dm = new DummyService();

        public async void laadReizen()
        {
            //TripComponent = dm.retrieveTrips();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3398/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/user/2");
                if (response.IsSuccessStatusCode)
                {
                    var jsonAsString = await response.Content.ReadAsStringAsync();
                    User output = JsonConvert.DeserializeObject<User>(jsonAsString);
                    selectedUser = output;
                    TripComponent = selectedUser.Trips;
                    ItemDictionary = selectedUser.ItemDictionary;
                }
            }

            
        }
        

        public void laadItemDictionary()
        {
            ItemDictionary = dm.retrieveItemDictionary();
        }

        public void addItemToDictionary(Item item)
        {
            ItemDictionary.Add(item);
        }

        public void addTrip(Trip trip)
        {
            TripComponent.Add(trip);
        }
    }
}
