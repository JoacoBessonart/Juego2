namespace Ucu.Poo.RolePlayGame
{
    public class Drake : Enemy
    {
        public Spellbook Spellbook { get; private set; }

        public Drake(string name, int victoryPoints)
            : base(name, victoryPoints)
        {
            this.Spellbook = new Spellbook();
            this.Spellbook.AddSpell(new Spell(45, 0));
        }

        public override int GetAttackValue()
        {
            return base.GetAttackValue() + this.Spellbook.AttackValue;
        }

        public override int GetDefenseValue()
        {
            return base.GetDefenseValue() + this.Spellbook.DefenseValue;
        }
    }
}
