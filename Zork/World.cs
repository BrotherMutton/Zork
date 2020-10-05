using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class World
    {
        public Room[,] Rooms { get; set; }

        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Room room in Rooms)
            {
                mRoomsByName.Add(room.Name, room);
            }
        }

        private Dictionary<string, Room> mRoomsByName = new Dictionary<string, Room>();
    }
}
