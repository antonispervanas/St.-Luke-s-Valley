using System.Collections.Generic;

namespace SoftEng
{
    public class House : Building
    {
        private List<int> residents = new List<int>(); //h residents einai mia lista me ta id twn katoikwn

        public House(int id, string name, string description, bool unlocked, List<int> residents) : base(id, name, description, unlocked)
        {
            this.residents = residents;
        }

        public List<int> GetResidents() { return residents; }
        public void AddResident(int id) { residents.Add(Id); } //edw exoume tis aparaithtes methodous get, add kai remove
        public void RemoveResident(int id) { residents.Remove(id); }

        public override void Select() => throw new System.NotImplementedException();
    }
}
