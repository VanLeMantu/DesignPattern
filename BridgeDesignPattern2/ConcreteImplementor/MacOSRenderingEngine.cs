namespace BridgeDesignPattern2
{
    internal class MacOSRenderingEngine : IRenderingEngine
    {
        public void RenderButton(string text)
        {
            Console.WriteLine("MacOSRenderingEngine.RenderButton()");
        }

        public void RenderCheckbox(bool isChecked)
        {
            Console.WriteLine("MacOSRenderingEngine.RenderCheckbox()");
        }
    }
}
