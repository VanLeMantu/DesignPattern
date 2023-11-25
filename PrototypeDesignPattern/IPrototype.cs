namespace PrototypeDesignPattern
{
    public interface IPrototype
    {
        IPrototype Clone(IPrototype prototype);
        IPrototype CloneSelf();
    }
}