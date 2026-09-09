namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Hacha que aporta ataque.
    /// </summary>
    public class Axe
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Axe(int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = 0;
        }
    }
}
