using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftEng
{
    public class Character
    {
        private int answerSelect;
        private string  line;
        string[] elements;
        private bool dialogEnd, dialogDisplay;
        private double dialogLine = 1, nextDialog = 0;
        private List<string> characteristics = new List<string>(); //lista me xarakthristika kathe xarakthra(auta tha ginonte display se kapoio menu kai tha prosdidoun suntomes periektikes plhrofories gia ton xarakthra kai tha ananewnonte kathws o paixths mathainei perisotera)

        public Character (int id, string name, int age, bool alive, string description, string dialogPath, List<string> characteristics)
        {
            Id = id;
            Name = name;
            Age = age;
            Alive = alive;
            Description = description;
            DialogPath = dialogPath;
            this.characteristics = characteristics;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Alive { get; set; }
        public string Description { get; set; }
        public string DialogPath { get; set; }

        public List<string> GetCharacteristics() { return characteristics; }
        public void AddCharacteristic(string newCharacteristic) { characteristics.Add(newCharacteristic); }
        public void RemoveCharacteristic(string characteristic) { characteristics.Remove(characteristic); }

        //Methodos Dialog, Kaleite se kathe interruction me xarakthra. H parakatw sunarthsh xrisimopioitai gia na entopisei poio ap ta pollapla path ths suzhthshs tha xriastei
        public void Dialog()
        {
            dialogDisplay = true;
            dialogEnd = false;
            while (dialogEnd != true )
            {
                line = System.IO.File.ReadLines(@DialogPath).Skip(Convert.ToInt32(dialogLine)).Take(1).First(); //Kanei skip ta lines tou arxeiou pou apoteloun palia suzhthsh, h non taken path
                elements = line.Split(';');                                     //Xorizoume ta lines se entela 
                if (elements[0] != "Dialog")
                {

                    if (dialogDisplay == true)
                    {
                        Console.WriteLine(elements[0] + "\n1:" + elements[1] + "\n2:" + elements[2]);       //Pros to parwn einai WriteLine alla otan proxorisoume sto grafiko periballon tha allaksei
                        answerSelect = Int32.Parse(Console.ReadLine());                                     //To idio alla me ReadLine
                    }

                    if(answerSelect == 1 & elements[3] != "|")                                              //Path gia prwth apanthsh
                    {
                        dialogLine += Math.Pow(2, nextDialog);
                    }
                    else if(answerSelect == 2 & elements[3] != "|")                                         //Path gia deuterh apanthsh 
                    {
                        dialogLine += 2 * Math.Pow(2, nextDialog);
                    }
                    else if (elements[3] == "|")                                                            //Otan sunantaei auto to sumbolo sto 4o entelo shmenei pws o dialogos eftase sto telos tou
                    {
                        dialogDisplay = false;
                        dialogLine++;
                    }
                    nextDialog++;
                }
                else
                {
                    dialogEnd = true;
                    dialogLine++;
                }
            }
            nextDialog = 0;
        }
    }
}
