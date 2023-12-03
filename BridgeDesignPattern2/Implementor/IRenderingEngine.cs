namespace BridgeDesignPattern2
{
    public interface IRenderingEngine
    {
        void RenderButton(string text);
        void RenderCheckbox(bool isChecked);
    }
}
