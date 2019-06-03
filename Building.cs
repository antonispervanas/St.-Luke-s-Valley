namespace SoftEng
{
    public abstract class Building
    {
        protected Building(int id, string name, string description, bool unlocked)
        {
            Id = id;
            Name = name;
            Description = description;
            Unlocked = unlocked;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Unlocked { get; set; }

        public abstract void Select(); //methodos epiloghs kthriou kai antistoixhs drashs
    }
}
