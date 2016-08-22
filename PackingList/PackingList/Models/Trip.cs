using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class Trip : TripComponent
    {
        public string Title { get; set; }

        public IList<TripComponent> items { get; set; }

       // IList<TripComponent> items = new List<TripComponent>();
        
        public override void Add(TripComponent t)
        {
            items.Add(t);
        }

        public override void Remove(TripComponent t)
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
