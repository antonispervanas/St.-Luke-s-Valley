using System.Collections.Generic;
using System.Linq;

namespace SoftEng
{
    public class Game
    {
        private string date, time;
        private int hp = 100;
        private List<Character> CharacterList = new List<Character>(); //dhmiourgoume tis listes me ola ta stoixeia tou paixnidiou
        private List<Demon> DemonList = new List<Demon>(); //kai ftiaxnoume epishs apo katw methodous add, remove kai get gia kathe mia
        private List<House> HouseList = new List<House>();

        public void AddCharacter(Character character) { CharacterList.Add(character); }
        public void AddDemon(Demon demon) { DemonList.Add(demon); }
        public void AddHouse(House house) { HouseList.Add(house); }

        public void RemoveCharacter(int id) { CharacterList.Remove(CharacterList.First(character => character.Id == id)); }
        public void RemoveDemon(int id) { DemonList.Remove(DemonList.First(demon => demon.Id == id)); }
        public void RemoveHouse(int id) { HouseList.Remove(HouseList.First(house => house.Id == id)); }

        public List<Character> GetCharacterList() { return CharacterList; }
        public List<Demon> GetDemonList() { return DemonList; }
        public List<House> GetHouseList() { return HouseList; }

        public void ChangeTime() //elegxos pou tha ulopoiei thn metavash metaksu diadikasias meras-nuxtas
        {
            if (time == "Day")
            {
                time = "Night";
                StartNight();
            }
            else
            {
                time = "Day";
                StartDay();
            }
        }

        private void StartNight()   //Grafiko periballon + enarksh diadikasiwn nuxtas
        {

        }
        private void StartDay()     //Grafiko periballon + enarksh diadikasiwn meras
        {

        }
    }
}
