namespace Ucu.Poo.RolePlayGame
{
    public class MagicStaff : IMagicItem
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public MagicStaff(int attackValue, int defenseValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}
