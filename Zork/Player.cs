using System.Reflection;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        public Room CurrentRoom { get; private set; }

        public Room PreviousRoom { get; set; }

        public int Score { get; set; }

        public int Moves { get; set; }

        public Player(World world, string startingLocation)
        {
            World = world;
            Assert.IsTrue(world != null, "World cannot be null");

            CurrentRoom = World.RoomsByName[startingLocation];
            Assert.IsTrue(world.RoomsByName.ContainsKey(startingLocation), "Starting location not found in the world.");

            for (int row = 0; row < World.Rooms.GetLength(0); row++)
            {
                for (int column = 0; column < World.Rooms.GetLength(0); column++)
                {
                    if (World.Rooms[row, column] == CurrentRoom)
                    {
                        Location = (row, column);
                        return;
                    }
                }
            }
        }

        public bool Move(Directions direction)
        {

            bool isValidMove = true;
            switch (direction)
            {
                case Directions.NORTH when Location.Row < World.Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Directions.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Directions.EAST when Location.Column < World.Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Directions.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    isValidMove = false;
                    break;
            }

            if(isValidMove)
            {
                PreviousRoom = CurrentRoom;
                CurrentRoom = World.Rooms[Location.Row, Location.Column];
            }

            return isValidMove;
        }

        private (int Row, int Column) Location;
    }
}
