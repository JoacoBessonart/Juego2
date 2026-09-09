namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Libro que puede contener hechizos.
    /// </summary>
    public class Spellbook
    {
        public Spell[] Spells { get; private set; }

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
