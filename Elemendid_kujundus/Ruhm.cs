using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Elemendid_kujundus
{
    public class Ruhm<K,T> : ObservableCollection<T>
    {
        public K Nimetus { get; private set; }
        public Ruhm(K nimetus, IEnumerable<T> items)
        {
            Nimetus = nimetus;
            foreach (T item in items)
                Items.Add(item);
        }
    }
}
