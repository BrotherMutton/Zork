namespace Zork
{
    class Room
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Room(string name = null, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
