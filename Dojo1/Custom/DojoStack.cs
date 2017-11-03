using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1.Custom
{
    class DojoStackNode<T>
    {
        public T Value { get; }
        public DojoStackNode<T> Prev { get; }

        public DojoStackNode(T val, DojoStackNode<T> prev)
        {
            this.Value = val;
            this.Prev = prev;
        }
    }


    public class DojoStack<T>
    {
        
        private DojoStackNode<T> _current = null;


        public DojoStack()
        {
            
        }

        public DojoStack(T obj)
        {
            this.Push(obj);
        }

        public void Push(T obj)
        {
            if (this._current == null)
            {
                this._current = new DojoStackNode<T>(obj, null);
            }
            else
            {
                var newNode = new DojoStackNode<T>(obj, this._current);
                this._current = newNode;
            }
            
        }

        public T Pop()
        {
            if (this._current == null)
                throw new Exception("Stack has no elements!");

            var val = this._current.Value;

            this._current = this._current.Prev;

            return val;
        }

        public T Peek()
        {
            if (this._current == null)
                throw new Exception("Stack has no elements!");

            return this._current.Value;
        }


    }
}
