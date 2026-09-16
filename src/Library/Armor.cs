namespace Ucu.Poo.RolePlayGame
{
    public class Armor : IItems
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Armor(int defenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = defenseValue;
        }
    }
}
