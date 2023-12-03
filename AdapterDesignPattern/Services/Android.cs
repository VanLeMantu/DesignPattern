using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Services
{
    public class Android : IMicroUsbPhone
    {
        private bool connector;

        public void UseMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected");
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
                Console.WriteLine("Connect MicroUsb first");
            }
        }
    }
}
