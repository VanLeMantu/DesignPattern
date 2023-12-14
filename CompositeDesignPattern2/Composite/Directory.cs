using CompositeDesignPattern2.Interface;

namespace CompositeDesignPattern2.Composite
{
    public class Directory : IFileSystemItem
    {
        private List<IFileSystemItem> _children = new List<IFileSystemItem>();

        public void Add(IFileSystemItem item)
        {
            _children.Add(item);
        }

        public long GetSize()
        {
            long totalSize = 0;
            foreach (var item in _children)
            {
                totalSize += item.GetSize();
            }
            return totalSize;
        }
    }
}
