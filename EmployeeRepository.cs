using Coffee.StorageApp.Entities;

namespace Coffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items = new();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void save()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
