using System;


namespace PacmanGame
{
    public class Map
    {
        public Cell[,] area = new Cell[31, 28]; //array of map

        //Indexer of map
        public Cell this[int x, int y]
        {
            get
            {
                if (x < 0) return area[y, 27];
                else if (x > 27) return area[y, 0];
                else return area[y, x];
            }
            set
            {
                area[y, x] = value;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x + 1, y + 1);
                Console.Write(value);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Render of something
        public void RenderObject(Coordinate coordinate, Object obj)
        {
            if (coordinate.x < 0) coordinate.x = 27;
            else if (coordinate.x > 27) coordinate.x = 0;

            if (obj is Pacman) Console.ForegroundColor = ConsoleColor.Yellow;
            else if (obj is SmartGhost) Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(coordinate.x + 1, coordinate.y + 1);
            Console.Write(obj.GetSymbol());
            Console.ForegroundColor = ConsoleColor.White;
            area[coordinate.y, coordinate.x] = obj;
        }

      

        //Methods for new maps
       
        //Manually render of map
        public void RenderMap()
        {
            //Border
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(1, 1);
            for (int i = 0; i < 28; i++)
            {
                Console.Write(Wall.wallSymbol);
                area[0, i] = new Wall(0, i);
            }
            Console.SetCursorPosition(1, 31);
            for (int i = 0; i < 28; i++)
            {
                Console.Write(Wall.wallSymbol);
                area[30, i] = new Wall(30, i);
            }
            for (int i = 2; i < 15; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(Wall.wallSymbol);
                area[i - 1, 0] = new Wall(i - 1, 0);
                Console.SetCursorPosition(28, i);
                Console.Write(Wall.wallSymbol);
                area[i - 1, 27] = new Wall(i - 1, 27); ;
            }
            for (int i = 16; i < 31; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(Wall.wallSymbol);
                area[i - 1, 0] = new Wall(i - 1, 0); 
                Console.SetCursorPosition(28, i);
                Console.Write(Wall.wallSymbol);
                area[i - 1, 27] = new Wall(i - 1, 27); 
            }

            //Walls

            //left 1/3 part
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(3, i);
                for (int j = 3; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1); 
                }
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(3, i);
                for (int j = 3; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 10; i < 15; i++)
            {
                Console.SetCursorPosition(2, i);
                for (int j = 2; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 16; i < 21; i++)
            {
                Console.SetCursorPosition(2, i);
                for (int j = 2; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(2, i);
                for (int j = 2; j < 4; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(3, i);
                for (int j = 3; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 24; i < 27; i++)
            {
                Console.SetCursorPosition(5, i);
                for (int j = 5; j < 7; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            //left 2/3 part
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(8, i);
                for (int j = 8; j < 13; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 15; i++)
            {
                Console.SetCursorPosition(8, i);
                for (int j = 8; j < 10; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 10; i < 12; i++)
            {
                Console.SetCursorPosition(10, i);
                for (int j = 10; j < 13; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 16; i < 21; i++)
            {
                Console.SetCursorPosition(8, i);
                for (int j = 8; j < 10; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(8, i);
                for (int j = 8; j < 13; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 28; i++)
            {
                Console.SetCursorPosition(8, i);
                for (int j = 8; j < 10; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(3, i);
                for (int j = 3; j < 13; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            //left 3/3 part
            for (int i = 2; i < 6; i++)
            {
                Console.SetCursorPosition(14, i);
                for (int j = 14; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 12; i++)
            {
                Console.SetCursorPosition(14, i);
                for (int j = 14; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 13; i < 14; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 14; i < 17; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 12; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 17; i < 18; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 19; i < 21; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 21; i < 24; i++)
            {
                Console.SetCursorPosition(14, i);
                for (int j = 14; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(11, i);
                for (int j = 11; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 27; i < 30; i++)
            {
                Console.SetCursorPosition(14, i);
                for (int j = 14; j < 15; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            //right 1/3 part
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 27; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 27; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 10; i < 15; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 28; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 16; i < 21; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 28; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(26, i);
                for (int j = 26; j < 28; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 27; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 24; i < 27; i++)
            {
                Console.SetCursorPosition(23, i);
                for (int j = 23; j < 25; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            //right 2/3 part
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(17, i);
                for (int j = 17; j < 22; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 15; i++)
            {
                Console.SetCursorPosition(20, i);
                for (int j = 20; j < 22; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 10; i < 12; i++)
            {
                Console.SetCursorPosition(17, i);
                for (int j = 17; j < 20; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 16; i < 21; i++)
            {
                Console.SetCursorPosition(20, i);
                for (int j = 20; j < 22; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(17, i);
                for (int j = 17; j < 22; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 28; i++)
            {
                Console.SetCursorPosition(20, i);
                for (int j = 20; j < 22; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(17, i);
                for (int j = 17; j < 27; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            //right 3/3 part
            for (int i = 2; i < 6; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 16; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 7; i < 12; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 16; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 13; i < 14; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 14; i < 17; i++)
            {
                Console.SetCursorPosition(18, i);
                for (int j = 18; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 17; i < 18; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 19; i < 21; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 21; i < 24; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 16; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 19; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }
            for (int i = 27; i < 30; i++)
            {
                Console.SetCursorPosition(15, i);
                for (int j = 15; j < 16; j++)
                {
                    Console.Write(Wall.wallSymbol);
                    area[i - 1, j - 1] = new Wall(i - 1, j - 1);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        //Manually render of jewels
        public void RenderJewels()
        {
            //top horizontal lines
            Console.SetCursorPosition(2, 2);
            for (int i = 1; i < 13; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[1, i] = new Jewel(1, i);
            }
            Console.SetCursorPosition(16, 2);
            for (int i = 15; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[1, i] = new Jewel(1, i);
            }
            //second top horizontal line
            Console.SetCursorPosition(2, 6);
            for (int i = 1; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[5, i] = new Jewel(5, i);
            }
            //top vertical lines
            for (int i = 3; i < 10; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 1] = new Jewel(i - 1, 1);
            }
            for (int i = 3; i < 28; i++)
            {
                Console.SetCursorPosition(7, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 6] = new Jewel(i - 1, 6);
            }
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(13, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 12] = new Jewel(i - 1, 12);
            }
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(16, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 15] = new Jewel(i - 1, 15);
            }
            for (int i = 3; i < 28; i++)
            {
                Console.SetCursorPosition(22, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 21] = new Jewel(i - 1, 21);
            }
            for (int i = 3; i < 10; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 26] = new Jewel(i - 1, 26);
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 9] = new Jewel(i - 1, 9);
            }
            for (int i = 7; i < 9; i++)
            {
                Console.SetCursorPosition(19, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 18] = new Jewel(i - 1, 18);
            }
            //third top horizontal lines
            Console.SetCursorPosition(3, 9);
            for (int i = 2; i < 6; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[8, i] = new Jewel(8, i);
            }
            Console.SetCursorPosition(23, 9);
            for (int i = 22; i < 26; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[8, i] = new Jewel(8, i);
            }
            Console.SetCursorPosition(10, 9);
            for (int i = 9; i < 13; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[8, i] = new Jewel(8, i);
            }
            Console.SetCursorPosition(16, 9);
            for (int i = 15; i < 19; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[8, i] = new Jewel(8, i);
            }
            //bottom horizontal line
            Console.SetCursorPosition(2, 30);
            for (int i = 1; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[29, i] = new Jewel(29, i);
            }
            //second bottom horizontal lines
            Console.SetCursorPosition(2, 27);
            for (int i = 1; i < 7; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[26, i] = new Jewel(26, i);
            }
            Console.SetCursorPosition(22, 27);
            for (int i = 21; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[26, i] = new Jewel(26, i);
            }
            Console.SetCursorPosition(10, 27);
            for (int i = 9; i < 13; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[26, i] = new Jewel(26, i);
            }
            Console.SetCursorPosition(16, 27);
            for (int i = 15; i < 19; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[26, i] = new Jewel(26, i);
            }
            //bottom vertical lines
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 1] = new Jewel(i - 1, 1);
            }
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(13, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 12] = new Jewel(i - 1, 12);
            }
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(16, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 15] = new Jewel(i - 1, 15);
            }
            for (int i = 28; i < 30; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 26] = new Jewel(i - 1, 26);
            }
            //second bottom vertical lines
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(4, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 3] = new Jewel(i - 1, 3);
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 9] = new Jewel(i - 1, 9);
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(19, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 18] = new Jewel(i - 1, 18);
            }
            for (int i = 25; i < 27; i++)
            {
                Console.SetCursorPosition(25, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 24] = new Jewel(i - 1, 24);
            }

            //third bottom horizontal lines
            Console.SetCursorPosition(2, 24);
            for (int i = 1; i < 4; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[23, i] = new Jewel(23, i);
            }
            Console.SetCursorPosition(25, 24);
            for (int i = 24; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[23, i] = new Jewel(23, i);
            }
            Console.SetCursorPosition(8, 24);
            for (int i = 7; i < 13; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[23, i] = new Jewel(23, i);
            }
            Console.SetCursorPosition(16, 24);
            for (int i = 15; i < 21; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[23, i] = new Jewel(23, i);
            }

            //third bottom vertical lines
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 1] = new Jewel(i - 1, 1);
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(13, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 12] = new Jewel(i - 1, 12);
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(16, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 15] = new Jewel(i - 1, 15);
            }
            for (int i = 22; i < 24; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write(Jewel.jewelSkin);
                area[i - 1, 26] = new Jewel(i - 1, 26);
            }

            //fourth horizontal lines
            Console.SetCursorPosition(2, 21);
            for (int i = 1; i < 13; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[20, i] = new Jewel(20, i);
            }
            Console.SetCursorPosition(16, 21);
            for (int i = 15; i < 27; i++)
            {
                Console.Write(Jewel.jewelSkin);
                area[20, i] = new Jewel(20, i);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
