namespace Ucu.Poo.RolePlayGame
{
    public class Spellbook : IMagicItem
    {
        public Spell[] Spells { get; private set; }

        public int AttackValue
        {
            get
            {
                return this.GetAttackValue();
            }
        }

        public int DefenseValue
        {
            get
            {
                return this.GetDefenseValue();
            }
        }

        public Spellbook()
        {
            this.Spells = new Spell[0];
        }

        public void AddSpell(Spell spell)
        {
            Spell[] newSpells = new Spell[this.Spells.Length + 1];

            for (int index = 0; index < this.Spells.Length; index++)
            {
                newSpells[index] = this.Spells[index];
            }

            newSpells[newSpells.Length - 1] = spell;
            this.Spells = newSpells;
        }

        public int GetAttackValue()
        {
            int total = 0;

            foreach (Spell spell in this.Spells)
            {
                total += spell.AttackValue;
            }

            return total;
        }

        public int GetDefenseValue()
        {
            int total = 0;

            foreach (Spell spell in this.Spells)
            {
                total += spell.DefenseValue;
            }

            return total;
        }
    }
}
