﻿namespace GenericScale
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        
        public bool AreEqual()
        {
            if (left.Equals(right))
            {
                return true;
            }

            return false;
        }
    }
}