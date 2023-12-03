namespace BridgeDesignPattern2
{
    public class Button : UIControl
    {
        private readonly string text;

        public Button(IRenderingEngine renderingEngine, string text) : base(renderingEngine)
        {
            this.text = text;
        }

        public override void Draw()
        {
            renderingEngine.RenderButton(text);
        }
    }
}
