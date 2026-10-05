namespace Ucu.Poo.RolePlayGame
{
    public abstract class Enemy : Character
    {
        public int VictoryPoints { get; private set; }

        protected Enemy(string name, int victoryPoints)
            : base(name)
        {
            this.VictoryPoints = victoryPoints;
        }

        public void ReceiveAttack(Hero attacker)
        {
            base.ReceiveAttack(attacker);

            if (this.Health == 0)
            {
                attacker.AddVictoryPoints(this.VictoryPoints);
            }
        }
    }
}
