﻿namespace ClassBoxData
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value; 
            }
        }
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public double SurfaceArea() 
        { 
            return  (2 * length * width) + (2 * length * height) + (2 * width * height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * length * height) + (2 * width * height);
        }

        public double Volume()
        {
            return length * height * width;
        }
    }
}