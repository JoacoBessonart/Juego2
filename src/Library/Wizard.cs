namespace Ucu.Poo.RolePlayGame
{
    public class Wizard : Character
    {
        public InventoryMagic InventoryMagic { get; private set; }

        public Wizard(string name)
            : base(name)
        {
            this.InventoryMagic = new InventoryMagic();
        }

        public override int GetAttackValue()
        {
            return base.GetAttackValue() + this.InventoryMagic.GetAttackValue();
        }

        public override int GetDefenseValue()
        {
            return base.GetDefenseValue() + this.InventoryMagic.GetDefenseValue();
        }
    }
}
