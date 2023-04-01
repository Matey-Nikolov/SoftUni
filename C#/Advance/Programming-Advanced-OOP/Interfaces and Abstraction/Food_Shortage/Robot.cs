namespace Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    public class Robot : IIdentifiable
    {
        public BigInteger Id { get; set; }
        public string Model { get; set; }
    }
}