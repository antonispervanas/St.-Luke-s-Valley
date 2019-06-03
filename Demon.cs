using System.Collections.Generic;

namespace SoftEng
{
    public class Demon : Game
    {
        private int victimId;
        private List<string> characteristics = new List<string>();
        //Constructor //
        public Demon (int id, string name, string type, bool exorcised, string description, List<string> characteristics)
        {
            Id = id;
            Name = name;
            Type = type;
            Exorcised = exorcised;
            Description = description;
            this.characteristics = characteristics;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Exorcised { get; set; }
        public string Description { get; set; }

        public List<string> GetCharacteristics() { return characteristics; }
        public void AddCharacteristic(string newCharacteristic) { characteristics.Add(newCharacteristic); }
        public void RemoveCharacteristic(string characteristic) { characteristics.Remove(characteristic); }

        //Methodos anixneushs xarakthra pou exei daimonistei ap ton suggekrimeno daimona
        public void Possess(int victimId)
        {
            
        }
    }
}
