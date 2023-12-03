namespace BridgeDesignPattern2
{
    public class Checkbox : UIControl
    {
        private readonly bool isChecked;

        public Checkbox(IRenderingEngine renderingEngine, bool isChecked) : base(renderingEngine)
        {
            this.isChecked = isChecked;
        }

        public override void Draw()
        {
            renderingEngine.RenderCheckbox(isChecked);
        }
    }
}
