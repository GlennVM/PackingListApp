using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class Trip
    {
        public string Title { get; set; }
        public List<Item> items { get; set; }
    }
}
