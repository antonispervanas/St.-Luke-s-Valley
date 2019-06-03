using System.Collections.Generic;

namespace SoftEng
{
    public class Tavern : Building
    {
        private List<int> currentlyPresent = new List<int>(); //lista pou tha periexei ta id oswn einai sthn taverna kathe vradu

        public Tavern(int id, string name, string description, bool unlocked, List<int> currentlyPresent) : base(id, name, description, unlocked)
        {
            this.currentlyPresent = currentlyPresent;
        }

        public List<int> GetCurrentlyPresent() { return currentlyPresent; } //methodoi get, add kai clear(gia thn epomenh mera)
        public void AddCurrentlyPresent(int id) { currentlyPresent.Add(id); }
        public void ClearCurrentlyPresent() { currentlyPresent.Clear(); }

        public override void Select() => throw new System.NotImplementedException();
    }
}
