using CompositeDesignPattern.Interface;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        private readonly List<IEmployee> _subordinates = new();
        private string _name;
        private string _position;

        public Manager(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        public IEmployee GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{_position} - {_name}");
            foreach (var employee in _subordinates)
            {
                employee.DisplayDetails();
            }
        }
    }
}
