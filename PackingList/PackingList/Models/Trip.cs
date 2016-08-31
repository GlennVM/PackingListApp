using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class Trip : TripComponent
    {
        public int TripId { get; set; }

        public string Title { get; set; }

        public IList<Item> items { get; set; }
        public IList<Task> tasks { get; set; }

       // IList<TripComponent> items = new List<TripComponent>();
        
        public void Add(Item t)
        {
            items.Add(t);
        }

        public void Remove(Item t)
        {
            items.Remove(t);
        }

        public override TripComponent GetChild(int i)
        {
            return items[i];
        }

        public override IEnumerator<TripComponent> CreateIterator()
        {
            return items.GetEnumerator();
        }
    }
}
