using System;
using System.Collections.Generic;

namespace SoftEng
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); //sth main tha dhmiourgeite ena antikeimeno game sto opoio tha ekteleitai megalo meros tou paixnidiou
            //-----------------------------------------------------Characters-------------------------------------------------//
            string characterPath = @"D:\Alekos\Desktop\Alekos\St. Luke's Valley\Data\Characters.txt";       //Path arxeiou xarakthrwn
            string line;
            int data;
            string[] elements;
            List<string> Characteristics = new List<string>();          //Lista prosorinhs apothikeush xarakthristikwn gia kathe xarakthra
            System.IO.StreamReader characterFile = new System.IO.StreamReader(characterPath);       //Diabazei apo txt arxeio dedomena gia tous xarakthres

            while ((line = characterFile.ReadLine()) != null)           //Diabazei mia mia tis grammes tou txt arxeiou
            {
                elements = line.Split(';');                             //Dhmiourgounte entela gia tous xarakthres
                for (data = 6; data < elements.Length; data++)          //Apothikeush xarakthristikwn se mia lista
                {
                    Characteristics.Add(elements[data]);                
                }
                Character character = new Character(Int32.Parse(elements[0]), elements[1], Int32.Parse(elements[2]), elements[3] == "TRUE", elements[4], @elements[5], Characteristics);    //Dhmiourgia xarakthra
                game.AddCharacter(character);                           //Add xarakthra sthn lista
                Array.Clear(elements,0,elements.Length);                //Katharismos array entelwn
                Characteristics.Clear();                                //Katharismos listas xarakthristikwn
            }

            characterFile.Close();                                      //Klhsimo txt arxeiou xarakthrwn
            //-----------------------------------------------------DEMONS-------------------------------------------------//
            string demonPath = @"D:\Alekos\Desktop\Alekos\St. Luke's Valley\Data\Demons.txt";       //Path arxeiou Daimonwn
            List<string> DemonCharacteristics = new List<string>();     //Dhmiourgeia prosorinhs listas Xarakthristikwn Daimona
            System.IO.StreamReader demonFile = new System.IO.StreamReader(demonPath);               //Diabazei apo txt arxeio dedomena gia tous daimones              
            while ((line = demonFile.ReadLine()) != null)               // Diabazei mia mia tis grammes tou txt arxeiou
            {
                elements = line.Split(';');                             //Dhmiourgounte entela gia tous daimones
                for (data = 5; data < elements.Length; data++)          //Apothikeush xarakthristikwn se mia lista
                {
                    DemonCharacteristics.Add(elements[data]);
                }
                Demon demon = new Demon(Int32.Parse(elements[0]), elements[1], elements[2], elements[3] == "TRUE", elements[4], DemonCharacteristics);      //Dhmiourgia Daimona
                game.AddDemon(demon);                                   //Add daimona sthn lista
                Array.Clear(elements, 0, elements.Length);              //Katharismos array entelwn
                DemonCharacteristics.Clear();                           //Katharismos listas xarakthristikwn
            }

            demonFile.Close();                                          //Klhsimo txt arxeiou xarakthrwn

            //-----------------------------------------------------HOUSES-------------------------------------------------//
            string housePath = @"D:\Alekos\Desktop\Alekos\St. Luke's Valley\Data\Houses.txt";       //Path arxeiou Spitiwn
            List<int> HouseResidents = new List<int>();                 //Dhmiourgeia prosorinhs listas Katoikwn Spitiou
            System.IO.StreamReader houseFile = new System.IO.StreamReader(housePath);               //Diabazei apo txt arxeio dedomena gia ta spitia
            while ((line = houseFile.ReadLine()) != null)               // Diabazei mia mia tis grammes tou txt arxeiou
            {
                elements = line.Split(';');                             //Dhmiourgounte entela gia ta spitia
                for (data = 4; data < elements.Length; data++)          //Apothikeush katoikwn se mia lista
                {
                    HouseResidents.Add(Int32.Parse(elements[data]));
                }
                House house = new House(Int32.Parse(elements[0]), elements[1], elements[2], elements[3] == "TRUE", HouseResidents); ;       //Dhmiourgia Spitiou
                game.AddHouse(house);                                   //Add spiti sthn lista
                Array.Clear(elements, 0, elements.Length);              //Katharismos array entelwn
                HouseResidents.Clear();                                 //Katharismos listas katoikwn
            }

            houseFile.Close();                                          //Klhsimo txt arxeiou spitiwn
        }
    }
}