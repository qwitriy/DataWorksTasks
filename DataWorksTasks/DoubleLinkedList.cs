using System.Collections;
using System.Collections.Generic;

namespace DataWorksTasks
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
    {
        public DoubleLinkedNode<T> First { get; set; }
        public DoubleLinkedNode<T> Last { get; set; }

        public void Reverse()
        {
            var last = Last;
            for (var node = First; node != null; node = node.Prev)
            {
                var temp = node.Next;
                node.Next = node.Prev;
                node.Prev = temp;
            }

            Last = First;
            First = last;
        }

        public void AddFirst(T value)
        {
            var node = new DoubleLinkedNode<T>
            {
                Value = value,
                Next = First
            };

            if (First == null)
            {
                Last = node;
            }
            else
            {
                First.Prev = node;
            }

            First = node;
        }

        public void AddLast(T value)
        {
            var node = new DoubleLinkedNode<T>
            {
                Value = value,
                Prev = Last
            };

            if (First == null)
            {
                First = node;
            }
            else
            {
                Last.Next = node;

            }
            
            Last = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = First;
            while(node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
    public class DoubleLinkedNode<T> : IDoubleLinkedNode<T>
    {
        public T Value { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }
    }
    public interface IDoubleLinkedNode<T>
    {
        T Value { get; set; }
        DoubleLinkedNode<T> Next { get; set; }
        DoubleLinkedNode<T> Prev { get; set; } 
    }
    public interface IDoubleLinkedList<T>
    {
        DoubleLinkedNode<T> First { get; set; }
        DoubleLinkedNode<T> Last { get; set; }
        void Reverse();
        //insert new DoubleLinkedListNode with given value at the start of the list
        void AddFirst(T value);
        //insert new DoubleLinkedListNode with given value at the end of the list
        void AddLast(T value);
    }
}