using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Zork
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Room> Rooms { get; set; } = new List<Room>();

        public IReadOnlyDictionary<string, Room> GetRoomsByName() => mRoomsByName;

        public World()
        {
            Rooms = new List<Room>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        private Dictionary<string, Room> mRoomsByName;
    }
}
