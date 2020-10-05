using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Room
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName ="Neighbors")]
        public Dictionary<Directions, string> NeighborNames;

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors;

        public Room(string name = null, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
        }
        
    }
}
