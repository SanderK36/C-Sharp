namespace TowerOfHanoi;

    public class Disc
    {
        private int _size;

        public Disc(int size)
        {
            _size = size;
        }

        public override string ToString()
        {
            return "".PadLeft(_size, '#');
        }

        public int GetZize()
        {
            return _size;
        }
    }

