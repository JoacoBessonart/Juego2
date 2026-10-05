namespace Ucu.Poo.RolePlayGame
{
    public abstract class Item
    {
        public virtual int AttackValue { get; protected set; }

        public virtual int DefenseValue { get; protected set; }

        protected Item(int attackValue, int defenseValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}
