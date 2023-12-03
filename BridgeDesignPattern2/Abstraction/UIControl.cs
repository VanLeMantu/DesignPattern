namespace BridgeDesignPattern2
{
    public abstract class UIControl
    {
        protected IRenderingEngine renderingEngine;

        protected UIControl(IRenderingEngine renderingEngine)
        {
            this.renderingEngine = renderingEngine;
        }

        public abstract void Draw();
    }
}
