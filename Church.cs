namespace SoftEng
{
    public class Church : Building
    {
        public Church(int id, string name, string description, bool unlocked) : base(id, name, description, unlocked)
        {
        }

        public override void Select() => throw new System.NotImplementedException();

        private void Pray() //h leitourgia Pray tha ekteleitai otan o xrhsths episkeutei thn ekklhsia to bradu kai tha auksanei to HP tou paixtei
        {
        	
        }
    }
}
