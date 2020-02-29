using System;
using System.Threading;

namespace PacmanGame
{
    class Pacman : Object, IMovable
    {
        public char pacmanSkin = 'C';
        //Pacman constructor
        public Pacman(Coordinate coordinate):base(coordinate)
        {
            objectDirection = EnumDirection.Left;
            Program.map.RenderObject(coordinate, this);
        }

        //Processing keystrokes
        static ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo();

        public void Control(Thread background)
        {
            while (background.IsAlive)
            {
                KeyInfo = Console.ReadKey(true);

                if (KeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    objectDirection = EnumDirection.Left;
                }
                else if (KeyInfo.Key == ConsoleKey.RightArrow)
                {
                    objectDirection = EnumDirection.Right;
                }
                else if (KeyInfo.Key == ConsoleKey.UpArrow)
                {
                    objectDirection = EnumDirection.Up;
                }
                else if (KeyInfo.Key == ConsoleKey.DownArrow)
                {
                    objectDirection = EnumDirection.Down;
                }
            }
        }

        //Pacman symbol
        public override char GetSymbol()
        {
            return pacmanSkin;
        }

        //Moving pacman
        public void ChangePositionByDirection(EnumDirection Direction)
        {
            if (coordinate.x > 27) coordinate.x = 0;
            else if (coordinate.x < 0) coordinate.x = 27;
            Program.map.RenderObject(coordinate, this);
            if (Direction == EnumDirection.Left) coordinate.x--;
            if (Direction == EnumDirection.Right) coordinate.x++;
            if (Direction == EnumDirection.Up) coordinate.y--;
            if (Direction == EnumDirection.Down) coordinate.y++;
            CalcScore();
            Program.map.RenderObject(coordinate, this);
        }

        //Score for jewels
        public void CalcScore()
        {
            if (Program.map[coordinate.x, coordinate.y] is Jewel)
            {
                Program.score += 10;
            }
        }

        //Next Step
        public void Step()
        {
           
            Cell newPosition = GetCellByDirection(objectDirection);
            if (!(newPosition is Wall))
            {

                ChangePositionByDirection(objectDirection);
                previousObjectDirection = objectDirection;
            }
            else
            {
                newPosition = GetCellByDirection(previousObjectDirection);
                if (!(newPosition is Wall))
                {
                    ChangePositionByDirection(previousObjectDirection);
                }
            }

        }
    }
}
