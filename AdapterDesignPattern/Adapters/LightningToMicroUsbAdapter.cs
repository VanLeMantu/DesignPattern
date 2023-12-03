using AdapterDesignPattern.Services;

namespace AdapterDesignPattern.Adapters
{
    public class LightningToMicroUsbAdapter : IMicroUsbPhone
    {
        private readonly ILightningPhone _lightningPhone;

        public LightningToMicroUsbAdapter(ILightningPhone lightningPhone)
        {
            _lightningPhone = lightningPhone;
        }

        public void UseMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            _lightningPhone.UseLightning();
        }

        public void Recharge()
        {
            _lightningPhone.Recharge();
        }
    }
}
