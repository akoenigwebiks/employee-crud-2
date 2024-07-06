namespace employee_crud.Utils
{
    internal class CrudGeneric<T>
    {
        private readonly List<T> _items;

        public CrudGeneric()
        {
            _items = new List<T>();
        }

        // Create
        public void Create(T item)
        {
            _items.Add(item);
        }

        // Read
        public List<T> ReadAll()
        {
            return new List<T>(_items);
        }

        public T? ReadById(Func<T, bool> predicate)
        {
            return _items.FirstOrDefault(predicate);
        }

        // Update
        public bool Update(Func<T, bool> predicate, T newItem)
        {
            var index = _items.FindIndex(new Predicate<T>(predicate));
            if (index < 0)
            {
                return false;
            }

            _items[index] = newItem;
            return true;

        }

        // Delete
        public bool Delete(Func<T, bool> predicate)
        {
            var item = _items.FirstOrDefault(predicate);
            if (item != null)
            {
                _items.Remove(item);
                return true;
            }
            return false;
        }
    }
}
