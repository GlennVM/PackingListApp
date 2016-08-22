using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public abstract class TripComponent
    {
        public string Name { get; protected set; }

        public virtual void Add(TripComponent t)
        {
            throw new TripException();
        }

        public virtual void Remove(TripComponent t)
        {
            throw new TripException();
        }

        public virtual TripComponent GetChild(int i)
        {
            throw new TripException();
        }

        public virtual IEnumerator<TripComponent> CreateIterator()
        {
            throw new TripException();
        }
    }
}
