namespace BridgeDesignPattern2
{
    public class WindowsRenderingEngine : IRenderingEngine
    {
        public void RenderButton(string text)
        {
            Console.WriteLine("WindowsRenderingEngine.RenderButton()");
        }

        public void RenderCheckbox(bool isChecked)
        {
            Console.WriteLine("WindowsRenderingEngine.RenderCheckbox()");
        }
    }
}
