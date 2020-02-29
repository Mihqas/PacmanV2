

namespace PacmanGame
{
    interface IMovable
    {
        void ChangePositionByDirection(EnumDirection Direction);

        void Step();

    }
}
