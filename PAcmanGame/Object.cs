using System;

namespace PacmanGame
{
    //Absract class for game characters
    public abstract class Object:Cell
    {
        public Cell currentStatePlace;
        public EnumDirection objectDirection = EnumDirection.Right;
        public EnumDirection previousObjectDirection = EnumDirection.Right;
      
        public Random randomize = new Random();

        public Object(Coordinate coordinate) : base(coordinate)
        {

        }

        public abstract char GetSymbol();

        public Cell GetCellByDirection(EnumDirection Direction)
        {
            if (Direction == EnumDirection.Left) return Program.map[coordinate.x - 1, coordinate.y];
            if (Direction == EnumDirection.Right) return Program.map[coordinate.x + 1, coordinate.y];
            if (Direction == EnumDirection.Up) return Program.map[coordinate.x, coordinate.y - 1];
            return Program.map[coordinate.x, coordinate.y + 1];
        }

    }
}
