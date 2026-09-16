namespace Ucu.Poo.RolePlayGame
{
    public class Axe : IItem
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Axe(int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = 0;
        }
    }
}
