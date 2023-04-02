using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Model { get; set; }
        public BigInteger Id { get; set; }

        public Robot(string model, BigInteger id)
        {
            Model = model;
            Id = id;
        }
    }
}