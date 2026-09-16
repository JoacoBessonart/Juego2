namespace Ucu.Poo.RolePlayGame
{
    public class Spell : IItem
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Spell(int attackValue, int defenseValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}
