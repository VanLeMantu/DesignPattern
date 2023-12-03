using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Services
{
    public class IPhone : ILightningPhone
    {
        private bool connector;

        public void UseLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharging started");
                Console.WriteLine("Recharging finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }
}
