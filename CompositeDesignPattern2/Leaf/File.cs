using CompositeDesignPattern2.Interface;

namespace CompositeDesignPattern2.Leaf
{
    public class File : IFileSystemItem
    {
        private readonly long _size;

        public File(long size)
        {
            _size = size;
        }

        public long GetSize()
        {
            return _size;
        }
    }
}
