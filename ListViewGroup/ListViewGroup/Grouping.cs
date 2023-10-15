using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewGroup
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(K key, List<T> items)
        {
            Key = key;
            foreach (var item in items)
            {
                Add(item);
            }
        }
    }
}