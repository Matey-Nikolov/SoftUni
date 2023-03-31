using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string URL { get; set; }
        public string PhoneNumber { get; set; }
        public Smartphone(string url, string phoneNumber)
        {
            URL = url;
            PhoneNumber = phoneNumber;
        }

        public void Call()
        {

        }
    }
}