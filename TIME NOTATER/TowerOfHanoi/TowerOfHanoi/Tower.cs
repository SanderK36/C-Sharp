namespace TowerOfHanoi
{
    internal class Tower
    {
        private Disc[] _discs;
        private int _position;

        public Tower(int position, int firstDiscSize, int secondDiscSize, int thirdDiscSize)
        {
            _position = position;
            _discs = new Disc[3];
            _discs[0] = new Disc(firstDiscSize);
            _discs[1] = new Disc(secondDiscSize);
            _discs[2] = new Disc(thirdDiscSize);
        }
    }
}
