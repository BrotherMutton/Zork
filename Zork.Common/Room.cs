using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;


namespace Zork
{
    public class Room : IEquatable<Room>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        public Dictionary<Directions, string> NeighborNames { get; } = new Dictionary<Directions, string>();

        public Room(string name) => Name = name;

        [JsonIgnore]
        public IReadOnlyDictionary<Directions, Room> Neighbors => _neighbors;
    
        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }
            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public void AssignNeighbor(Directions direction, Room neighbor)
        {
            _neighbors[direction] = neighbor;
            NeighborNames[direction] = neighbor.Name;
        }

        public void RemoveNeighbor(Directions direction)
        {
            _neighbors.Remove(direction);
            NeighborNames.Remove(direction);
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room && this == room;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world)
        {
            _neighbors.Clear();

            foreach (var entry in NeighborNames)
            {
                _neighbors.Add(entry.Key, world.GetRoomsByName()[entry.Value]);

            }
        }

        private Dictionary<Directions, Room> _neighbors = new Dictionary<Directions, Room>();
    }
}
