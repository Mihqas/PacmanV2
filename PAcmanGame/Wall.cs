using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    class Wall:Cell
    {
        public static char wallSymbol = '█'; //symbol of wall
                                             //Pacman symbol
        public Wall(Coordinate coordinate) : base(coordinate)
        {

        }

        public Wall(int x, int y) : base(new Coordinate(x,y))
        {

        }
    }
}
