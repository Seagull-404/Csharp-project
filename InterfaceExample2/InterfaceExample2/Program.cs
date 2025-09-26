using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var user =new PhoneUser(new NokiaPhone());
            user.UsePhone();
        }
    }

    class PhoneUser {

        private IPhone _phone;

        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dial();
            _phone.Pickup();
            _phone.Send();
            _phone.Receive();

        }

    
    }
    interface IPhone
    {
        void Dial();
        void Pickup();
        void Send();
        void Receive();
    }

    class NokiaPhone : IPhone
    {
        public void Dial()
        {
            Console.WriteLine("calling....");
        }

        public void Pickup()
        {
            Console.WriteLine("Hello  I'm....");
        }

        public void Receive()
        {
            Console.WriteLine("Message ring....");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }
    class Xiaomi : IPhone
    {
        public void Dial()
        {
            Console.WriteLine("calling....");  
        }

        public void Pickup()
        {
            Console.WriteLine("Hello  I'm....");
        }

        public void Receive()
        {
            Console.WriteLine("Message ring....");
        }

        public void Send()
        {
            Console.WriteLine ("Hello!");
        }
    }
}
