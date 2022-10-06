namespace Generics
{
    public class SimpleStack<TypePlaceHolder>
    {
        private readonly TypePlaceHolder[] _items;
        private int _currentIndex = -1;
        public SimpleStack() => _items = new TypePlaceHolder[10];
        public int Count => _currentIndex +1;
        public void Push(TypePlaceHolder item) => _items[++_currentIndex] = item;

        public TypePlaceHolder Pop() => _items[_currentIndex--];

    }
}