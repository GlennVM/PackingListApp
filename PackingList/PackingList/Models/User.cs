using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public List<Trip> Trips { get; set; }
        [DataMember]
        public List<Item> ItemDictionary { get; set; }
    }
}
