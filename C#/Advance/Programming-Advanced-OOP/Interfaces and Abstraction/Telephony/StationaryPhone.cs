namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StationaryPhone : ICallable
    {
        public string PhoneNumber { get; set; }
        public StationaryPhone(string phoneNumber)
        { 
            PhoneNumber = phoneNumber;
        }

        public void Call() 
        { 
            Console.WriteLine($"Calling... {PhoneNumber}");
        }
    }
}
