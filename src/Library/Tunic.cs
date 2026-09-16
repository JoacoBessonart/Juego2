namespace Ucu.Poo.RolePlayGame
{
    public class Tunic : IItem
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Tunic(int defenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = defenseValue;
        }
    }
}
