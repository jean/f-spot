//
// PhotoList.cs
//
// Author:
//   Mike Gemünde <mike@gemuende.de>
//
// Copyright (C) 2010 Novell, Inc.
// Copyright (C) 2010 Mike Gemünde
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections.Generic;

namespace FSpot.Core
{
    public class PhotoList : IBrowsableCollection
    {
        protected List<IPhoto> list;
        private IPhoto[] cache;

        public PhotoList (IEnumerable<IPhoto> photos)
        {
            list = new List<IPhoto> (photos);
        }

        public PhotoList (params IPhoto[] photos) : this(photos)
        {
        }

        public int Count {
            get { return list.Count; }
        }

        public void Clear ()
        {
            list.Clear ();
            Reload ();
        }

        public int Capacity {
            set { list.Capacity = value; }
        }

        public void Add (IPhoto photo)
        {
            list.Add (photo);
            Reload ();
        }

        public void Add (IEnumerable<IPhoto> items)
        {
            list.AddRange (items);
            Reload ();
        }

        public int IndexOf (IPhoto item)
        {
            return list.IndexOf (item);
        }

        public bool Contains (IPhoto item)
        {
            return list.Contains (item);
        }

        public IPhoto this[int index] {
            get { return list[index]; }
            set {
                list[index] = value;
                MarkChanged (index, FullInvalidate.Instance);
            }
        }

        public void Sort (IComparer<IPhoto> compare)
        {
            list.Sort (compare);
            Reload ();
        }

        public void Reload ()
        {
            cache = null;
            if (Changed != null)
                Changed (this);
        }

        public void MarkChanged (int num, IBrowsableItemChanges changes)
        {
            MarkChanged (new BrowsableEventArgs (num, changes));
        }

        public void MarkChanged (BrowsableEventArgs args)
        {
            if (ItemsChanged != null)
                ItemsChanged (this, args);
        }

        public IPhoto[] Items {
            get {
                if (cache == null)
                    cache = list.ToArray ();
                
                return cache;
            }
            set {
                list.Clear ();
                Add (value);
            }
        }

        public event IBrowsableCollectionChangedHandler Changed;
        public event IBrowsableCollectionItemsChangedHandler ItemsChanged;
    }
}
