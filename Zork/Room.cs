namespace Zork
{
    class Room
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Room(string name = null)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
