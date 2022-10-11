﻿using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> box;

        public Box()
        {
            box = new List<T>();
        }

        public void Add(T element)
        {
            box.Add(element);
        } 

        public void Clear()
        {
            box.Clear();
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {string.Join(" ", box)}";
        }
    }
}