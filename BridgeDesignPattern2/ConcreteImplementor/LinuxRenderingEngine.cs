namespace BridgeDesignPattern2
{
    public class LinuxRenderingEngine : IRenderingEngine
    {
        public void RenderButton(string text)
        {
            Console.WriteLine("LinuxRenderingEngine.RenderButton()");
        }

        public void RenderCheckbox(bool isChecked)
        {
            Console.WriteLine("LinuxRenderingEngine.RenderCheckbox()");
        }
    }
}
