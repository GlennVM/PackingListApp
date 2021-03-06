﻿using Newtonsoft.Json;
using PackingList.Models;
using PackingList.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

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

                string suburl = "api/user/" + selectedUser.UserId;
                // New code:
                HttpResponseMessage response = await client.GetAsync(suburl);
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

        public async void laadReizen(int id)
        {
            //TripComponent = dm.retrieveTrips();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3398/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string suburl = "api/user/" + id;
                // New code:
                HttpResponseMessage response = await client.GetAsync(suburl);
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


        //public async void laadItemDictionary()
        //{
        //    saveChanges();
        //}

        public void addItemToDictionary(Item item)
        {
            ItemDictionary.Add(item);
            saveChanges();
        }

        public void addTrip(Trip trip)
        {
            TripComponent.Add(trip);
            saveChanges();
        }

        public async void saveChanges()
        {
            selectedUser.Trips = TripComponent;
            selectedUser.ItemDictionary = ItemDictionary;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3398/");
                var itemAsJson = JsonConvert.SerializeObject(selectedUser);
                var content = new StringContent(itemAsJson);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                string subUrl = "api/user/" + selectedUser.UserId;
                // New code:
                HttpResponseMessage response = await client.PutAsync(subUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    laadReizen();
                    //var jsonAsString = await response.Content.ReadAsStringAsync();
                    //User output = JsonConvert.DeserializeObject<User>(jsonAsString);
                    //selectedUser = output;
                    //TripComponent = selectedUser.Trips;
                    //ItemDictionary = selectedUser.ItemDictionary;
                }
            }
        }

        public async void register(User user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3398/");
                var itemAsJson = JsonConvert.SerializeObject(user);
                var content = new StringContent(itemAsJson);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                string subUrl = "api/user";
                // New code:
                HttpResponseMessage response = await client.PostAsync(subUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonAsString = await response.Content.ReadAsStringAsync();
                    User output = JsonConvert.DeserializeObject<User>(jsonAsString);
                    laadReizen(output.UserId);
                }
            }
        }

        public async void login(User user, Grid mySplit, UserControl ucLogin)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3398/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string suburl = "api/user/0/?name=" + user.Name + "&pass=" + user.Password;
                // New code:
                HttpResponseMessage response = await client.GetAsync(suburl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonAsString = await response.Content.ReadAsStringAsync();
                    User output = JsonConvert.DeserializeObject<User>(jsonAsString);
                    laadReizen(output.UserId);
                    mySplit.Children.Remove(ucLogin);
                } else
                {
                    var dialog = new MessageDialog("Wrong Login/Password combination");
                    await dialog.ShowAsync();
                }
            }
        }
    }
}
