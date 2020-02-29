
namespace PacmanGame
{
    class Jewel:Cell
    {
        public static char jewelSkin = '·'; //symbol of jewel

        public Jewel(Coordinate coordinate):base(coordinate)
        {

        }

        public Jewel(int x, int y) : base(new Coordinate(x, y))
        {

        }

    }
}
