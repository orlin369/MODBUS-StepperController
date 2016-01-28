using System;
using System.Collections.Generic;

namespace StepperControl.Commands
{
    [Serializable]
    public class MotionCommands : IList<MotionCommand>
    {
        private List<MotionCommand> storage = new List<MotionCommand>();

        public MotionCommands()
        {

        }

        #region Implementation of IList

        public int IndexOf(MotionCommand item)
        {
            return this.storage.IndexOf(item);
        }

        public void Insert(int index, MotionCommand item)
        {
            this.storage.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.storage.RemoveAt(index);
        }

        public MotionCommand this[int index]
        {
            get
            {
                return this.storage[index];
            }
            set
            {
                this.storage[index] = value;
            }
        }

        public void Add(MotionCommand item)
        {
            this.storage.Add(item);
        }

        public void Clear()
        {
            this.storage.Clear();
        }

        public bool Contains(MotionCommand item)
        {
            return this.storage.Contains(item);
        }

        public void CopyTo(MotionCommand[] array, int arrayIndex)
        {
            this.storage.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get
            {
                return this.storage.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(MotionCommand item)
        {
            return this.storage.Remove(item);
        }

        public IEnumerator<MotionCommand> GetEnumerator()
        {
            return this.storage.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.storage.GetEnumerator();
        }

        #endregion
    }
}
