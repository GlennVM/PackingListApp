using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class TripIterator : IEnumerator<TripComponent>
    {
        private Stack<IEnumerator<TripComponent>> stack = new Stack<IEnumerator<TripComponent>>();

        public TripIterator(IEnumerator<TripComponent> it)
        {
            stack.Push(it);
        }

        public TripComponent Current
        {
            get
            {
                IEnumerator<TripComponent> it = stack.Peek();
                TripComponent component = it.Current;

                if (component is Trip)
                    stack.Push(component.CreateIterator());

                return component;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (stack.Count == 0) return false;

            IEnumerator<TripComponent> it = stack.Peek();

            if (!it.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }
            else
                return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
