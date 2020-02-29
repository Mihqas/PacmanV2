using System;
using System.Collections.Generic;

namespace PacmanGame
{
    class SmartGhost : Object, IMovable
    {
        public static char smartGhostSymbol = 'X'; //symbol of ghost

        //Ghost constructor
        public SmartGhost(Coordinate coordinate, EnumDirection Direction):base(coordinate)
        {
            currentStatePlace = new Jewel(coordinate);
            objectDirection = Direction;
            Program.map.RenderObject(coordinate , this);
        }

        //Ghost symbol
        public override char GetSymbol()
        {
            return smartGhostSymbol;
        }

        //Detect possible directions
        public void DetectDirection()
        {
            List<EnumDirection> variantsOfDirection = new List<EnumDirection>();
            if (objectDirection == EnumDirection.Up)
            {
                if (!(Program.map[coordinate.x, coordinate.y - 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Up);
                }
                if (!(Program.map[coordinate.x - 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Left);
                }
                if (!(Program.map[coordinate.x + 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Right);
                }
            }
            else if (objectDirection == EnumDirection.Down)
            {
                if (!(Program.map[coordinate.x, coordinate.y + 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Down);
                }
                if (!(Program.map[coordinate.x - 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Left);
                }
                if (!(Program.map[coordinate.x + 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Right);
                }
            }
            else if (objectDirection == EnumDirection.Left)
            {
                if (!(Program.map[coordinate.x, coordinate.y - 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Up);
                }
                if (!(Program.map[coordinate.x - 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Left);
                }
                if (!(Program.map[coordinate.x, coordinate.y + 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Down);
                }
            }
            else
            {
                if (!(Program.map[coordinate.x, coordinate.y - 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Up);
                }
                if (!(Program.map[coordinate.x, coordinate.y + 1] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Down);
                }
                if (!(Program.map[coordinate.x + 1, coordinate.y] is Wall))
                {
                    variantsOfDirection.Add(EnumDirection.Right);
                }
            }

            //Choise direction by Pacman position
            Pacman pacman = Program.pacman;

            if (coordinate.x < pacman.coordinate.x && objectDirection != EnumDirection.Left && variantsOfDirection.Contains(EnumDirection.Right))
            {
                objectDirection = EnumDirection.Right;
            }
            else if (coordinate.x > pacman.coordinate.x && objectDirection != EnumDirection.Right && variantsOfDirection.Contains(EnumDirection.Left))
            {
                objectDirection = EnumDirection.Left;
            }
            else if (coordinate.y > pacman.coordinate.y && objectDirection != EnumDirection.Down && variantsOfDirection.Contains(EnumDirection.Up))
            {
                objectDirection = EnumDirection.Up;
            }
            else if (coordinate.y < pacman.coordinate.y && objectDirection != EnumDirection.Up && variantsOfDirection.Contains(EnumDirection.Down))
            {
                objectDirection = EnumDirection.Down;
            }
            else
            {
                Random random = new Random();
                int index = random.Next(variantsOfDirection.Count);
                objectDirection = variantsOfDirection[index];
            }
        }

        public void ChangePositionByDirection(EnumDirection Direction)
        {
                //edge of game area
                if (coordinate.x > 27) coordinate.x = 0;
                else if (coordinate.x < 0) coordinate.x = 27;

                Program.map.RenderObject(coordinate, this);
                if (Direction == EnumDirection.Left) coordinate.x--;
                if (Direction == EnumDirection.Right) coordinate.x++;
                if (Direction == EnumDirection.Up) coordinate.y--;
                if (Direction == EnumDirection.Down) coordinate.y++;

                //When ghosts meet
                if (!(Program.map[coordinate.x, coordinate.y] is SmartGhost))
                {
                    currentStatePlace = Program.map[coordinate.x, coordinate.y];
                }
                //Render game character
                Program.map.RenderObject(coordinate, this);
            
        }

        public void KillPacman()
        {
            if (Program.pacman.coordinate.x == coordinate.x && Program.pacman.coordinate.y == coordinate.y)
            {
                Program.gameOver = true;
            }
        }

        //Next Step
        public void Step()
        {
            KillPacman();
            DetectDirection();
            ChangePositionByDirection(objectDirection);
            KillPacman();
        }
    }
}
