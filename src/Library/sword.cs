namespace Ucu.Poo.RolePlayGame
{
    public class Sword : IItems
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Sword(int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = 0;
        }
    }
}
