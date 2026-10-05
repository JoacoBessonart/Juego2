namespace Ucu.Poo.RolePlayGame
{
    public abstract class Hero : Character
    {
        public int VictoryPoints { get; private set; }

        protected Hero(string name)
            : base(name)
        {
            this.VictoryPoints = 0;
        }

        public void AddVictoryPoints(int victoryPoints)
        {
            this.VictoryPoints += victoryPoints;
        }
    }
}
