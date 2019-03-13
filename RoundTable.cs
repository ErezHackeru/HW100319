using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW100319
{
    class RoundTable<T> : IEnumerable<T>
    {
        private List<T> entities = new List<T>();

        public void Add(T t)
        {
            entities.Add(t);
        }

        public void RemoveAt(int x)
        {
            if (x < entities.Count)
                entities.RemoveAt(x);
            else
                entities.RemoveAt(GetNumbetToRemove(x) - 1);
        }

        private int GetNumbetToRemove(int x)
        {
            if (x < entities.Count)
                return x;
            else
                x = GetNumbetToRemove(x - entities.Count);
            
            return x;
        }

        public void Clear()
        {
            entities.Clear();
        }

        public void InsertAt(int x, T t)
        {
            if (x < entities.Count)
                entities.Insert(x, t);
            else
                entities.Insert(GetNumbetToRemove(x), t);
        }
        public void Sort(T t)
        {            
            //CompareToDefault(t);
        }
        static int CompareToDefault<S>(S value) where S : IComparable<S>
        {
            return value.CompareTo(default(S));
        }

        public List<T> GetRounded(int x)
        {
            List<T> AskedFromEntities = new List<T>();
            int k = 0;
            for (int i = 0; i < x; i++)
            {
                if (k>=entities.Count)
                    k= x - entities.Count;
                AskedFromEntities.Add(entities[k]);
                k++;
            }
            return AskedFromEntities;
        }

        public T this[int index]
        {
            get
            {
                if (index<entities.Count)
                    return entities[index];
                else
                    index = GetNumbetToRemove(index - entities.Count);

                return entities[index];
            }
        }

        public string this[string Name]
        {
            get
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].ToString() == Name)
                        return entities[i].ToString();
                }
                return null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public override string ToString()
        {
            string AllT = string.Empty;
            foreach (T item in entities)
            {
                AllT += item.ToString() + "\n";
            }
            return AllT;
        }
    }
}
