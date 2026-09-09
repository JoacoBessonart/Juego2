namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Bastón mágico que aporta ataque y defensa.
    /// </summary>
    public class MagicStaff
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
