namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Hechizo que aporta ataque y defensa al libro de hechizos.
    /// </summary>
    public class Spell
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
