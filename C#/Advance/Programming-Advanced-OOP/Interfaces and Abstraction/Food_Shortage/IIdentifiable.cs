namespace Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public interface IIdentifiable
    {
        BigInteger Id { get; }
    }
}