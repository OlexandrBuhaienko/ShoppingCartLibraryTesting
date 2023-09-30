namespace ShoppingCartLibrary
{
    [Serializable]
    public class ShoppingCart : IDisposable
    {
        private List<Item> _items = new List<Item>();
        public List<Item> Items
        {
            get
            {
                List<Item> returnedItems = new List<Item>(_items);
                return returnedItems;
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }
        public void Add(Item item)
        {
            _items.Add(item);
        }
        public void Remove(int index)
        {
            _items.RemoveAt(index);
        }
        public void Dispose()
        {
            //cleanup
        }
    }
}