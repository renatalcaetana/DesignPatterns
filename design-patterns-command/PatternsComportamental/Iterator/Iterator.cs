using DesignPatters.PatternsComportamental.Iterator.Interfaces;

namespace DesignPatters.PatternsComportamental.Iterator
{
    public class Iterator : IIterator
    {
        private IAggregate _aggregate;
        private int _position;

        public Iterator(IAggregate aggregate, int position = 0)
        {
            _aggregate = aggregate;
            _position = position;
        }

        public string Next 
        { 
            get
            {
                return _aggregate[_position++];
            }
        
        }

        public bool HasNext
        {
            get
            {
                return _position <= _aggregate.Limit;
            }

        }
    }
}
